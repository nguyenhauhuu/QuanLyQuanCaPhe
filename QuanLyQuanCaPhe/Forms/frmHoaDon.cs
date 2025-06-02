using ClosedXML.Excel;
using DocumentFormat.OpenXml.InkML;
using DocumentFormat.OpenXml.Office2010.Excel;
using Microsoft.EntityFrameworkCore;
using QuanLyQuanCaPhe.Data;
using QuanLyQuanCaPhe.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static QuanLyQuanCaPhe.Data.HoaDonChiTiet;

namespace QuanLyQuanCaPhe.Forms
{
    public partial class frmHoaDon : Form
    {
        QLQCPContext context = new QLQCPContext(); // Khởi tạo biến ngữ cảnh CSDL 

        public frmHoaDon()
        {
            InitializeComponent();
            helpProvider1.SetHelpString(this, "https://nguyenhauhuu.github.io/demo/hoadonbanhang.html");
            this.HelpRequested += (s, e) =>
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(helpProvider1.GetHelpString(this)!) { UseShellExecute = true });
                e.Handled = true;
            };
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            dataGridView.AutoGenerateColumns = false;

            var hoaDon = context.HoaDon.Select(r => new
            {
                r.ID,
                r.TaiKhoanID,
                r.TaiKhoan.TenDayDu,
                r.BanID,
                r.Ban.TenBan,
                r.NgayLap,
                r.GiamGia,
                // Tính tổng thanh toán = tổng tiền trừ đi phần giảm giá (%)
                TongThanhToan = context.HoaDonChiTiet
                    .Where(ct => ct.HoaDonID == r.ID)
                    .Sum(ct => ct.SoLuong * ct.DonGia) * (1 - r.GiamGia / 100m),
                InHoaDon = "In hoá đơn"
            }).ToList();
            dataGridView.DataSource = hoaDon;
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Nhập dữ liệu từ tập tin Excel";
            openFileDialog.Filter = "Tập tin Excel|*.xls;*.xlsx";
            openFileDialog.Multiselect = false;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (XLWorkbook workbook = new XLWorkbook(openFileDialog.FileName))
                    {
                        // Xử lý sheet Hóa đơn (Sheet 1)
                        IXLWorksheet sheet1 = workbook.Worksheet(1);
                        bool firstRowHoaDon = true;
                        string readRangeHoaDon = "";
                        DataTable tableHoaDon = new DataTable();
                        // Đọc Sheet 1 và lưu dữ liệu vào một bảng tạm
                        foreach (IXLRow row in sheet1.RowsUsed())
                        {
                            // Đọc dòng tiêu đề (dòng đầu tiên)
                            if (firstRowHoaDon)
                            {
                                readRangeHoaDon = string.Format("{0}:{1}", 1, row.LastCellUsed().Address.ColumnNumber);
                                foreach (IXLCell cell in row.Cells(readRangeHoaDon))
                                    tableHoaDon.Columns.Add(cell.Value.ToString());
                                firstRowHoaDon = false;
                            }
                            else // Đọc các dòng nội dung (các dòng tiếp theo)
                            {
                                tableHoaDon.Rows.Add();
                                int cellIndex = 0;
                                foreach (IXLCell cell in row.Cells(readRangeHoaDon))
                                {
                                    tableHoaDon.Rows[tableHoaDon.Rows.Count - 1][cellIndex] = cell.Value.ToString();
                                    cellIndex++;
                                }
                            }
                        }
                        // Đọc dữ liệu từ bảng tạm và lưu vào CSDL
                        if (tableHoaDon.Rows.Count > 0)
                        {
                            using (var transaction = context.Database.BeginTransaction())
                            {
                                foreach (DataRow r in tableHoaDon.Rows)
                                {
                                    HoaDon hoaDon = new HoaDon();
                                    hoaDon.ID = Convert.ToInt32(r["ID"]);
                                    hoaDon.TaiKhoanID = Convert.ToInt32(r["TaiKhoanID "]);
                                    hoaDon.BanID = Convert.ToInt32(r["BanID"]);
                                    hoaDon.NgayLap = DateTime.Parse(r["NgayLap"].ToString() ?? "N/A");
                                    hoaDon.GiamGia = Convert.ToDecimal(r["GiamGia"]);
                                    hoaDon.TrangThaiThanhToan = Convert.ToInt32(r["TrangThaiThanhToan"]);
                                    context.HoaDon.Add(hoaDon);
                                }
                                context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT HoaDon ON");
                                context.SaveChanges();
                                context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT HoaDon OFF");
                                transaction.Commit();
                            }
                            // Xử lý sheet Chi tiết hóa đơn (Sheet 2)
                            IXLWorksheet sheet2 = workbook.Worksheet(2);
                            bool firstRowChiTietHoaDon = true;
                            string readRangeChiTietHoaDon = "";
                            DataTable tableChiTietHoaDon = new DataTable();
                            // Đọc Sheet 2 và lưu dữ liệu vào một bảng tạm
                            foreach (IXLRow row in sheet2.RowsUsed())
                            {
                                // Đọc dòng tiêu đề (dòng đầu tiên)
                                if (firstRowChiTietHoaDon)
                                {
                                    readRangeChiTietHoaDon = string.Format("{0}:{1}", 1, row.LastCellUsed().Address.ColumnNumber);
                                    foreach (IXLCell cell in row.Cells(readRangeChiTietHoaDon))
                                        tableChiTietHoaDon.Columns.Add(cell.Value.ToString());
                                    firstRowChiTietHoaDon = false;
                                }
                                else // Đọc các dòng nội dung (các dòng tiếp theo)
                                {
                                    tableChiTietHoaDon.Rows.Add();
                                    int cellIndex = 0;
                                    foreach (IXLCell cell in row.Cells(readRangeChiTietHoaDon))
                                    {
                                        tableChiTietHoaDon.Rows[tableChiTietHoaDon.Rows.Count - 1][cellIndex] = cell.Value.ToString();
                                        cellIndex++;
                                    }
                                }
                            }
                            // Đọc dữ liệu từ bảng tạm và lưu vào CSDL
                            if (tableChiTietHoaDon.Rows.Count > 0)
                            {
                                foreach (DataRow r in tableChiTietHoaDon.Rows)
                                {
                                    HoaDonChiTiet ct = new HoaDonChiTiet();
                                    ct.HoaDonID = Convert.ToInt32(r["HoaDonID"].ToString());
                                    ct.ThucUongID = Convert.ToInt32(r["ThucUongID"].ToString());
                                    ct.SoLuong = Convert.ToInt32(r["SoLuong"].ToString());
                                    ct.DonGia = Convert.ToDecimal(r["DonGia"].ToString());
                                    ct.GhiChu = r["GhiChu"].ToString();
                                    context.HoaDonChiTiet.Add(ct);
                                }
                                context.SaveChanges();
                                MessageBox.Show("Đã nhập thành công " + tableHoaDon.Rows.Count + " dòng.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                frmHoaDon_Load(sender, e);
                            }
                        }
                        else
                            MessageBox.Show("Tập tin Excel rỗng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Xuất dữ liệu ra tập tin Excel";
            saveFileDialog.Filter = "Tập tin Excel|*.xls;*.xlsx";
            saveFileDialog.FileName = "HoaDon_" + DateTime.Now.ToShortDateString().Replace("/", "_") + ".xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Xuất dữ liệu Hóa đơn ra Sheet 1 (HoaDon)
                    DataTable tableHoaDon = new DataTable();
                    tableHoaDon.Columns.AddRange(new DataColumn[] {
                        new DataColumn("ID", typeof(int)),
                        new DataColumn("TaiKhoanID", typeof(int)),
                        new DataColumn("NguoiLap", typeof(string)),
                        new DataColumn("BanID", typeof(int)),
                        new DataColumn("TenBan", typeof(string)),
                        new DataColumn("NgayLap", typeof(DateTime)),
                        new DataColumn("GiamGia", typeof(decimal)),
                        new DataColumn("TrangThaiThanhToan", typeof(int)),
                        new DataColumn("TongThanhToan", typeof(decimal)),
                        });
                    var hd = context.HoaDon.Select(r => new
                    {
                        r.ID,
                        r.TaiKhoanID,
                        NguoiLap = r.TaiKhoan.TenDayDu,
                        r.BanID,
                        r.Ban.TenBan,
                        r.NgayLap,
                        r.GiamGia,
                        r.TrangThaiThanhToan,
                        // Tính tổng thanh toán = tổng tiền trừ đi phần giảm giá (%)
                        TongThanhToan = context.HoaDonChiTiet
                            .Where(ct => ct.HoaDonID == r.ID)
                            .Sum(ct => ct.SoLuong * ct.DonGia) * (1 - r.GiamGia / 100m),
                    }).ToList();
                    if (hd != null)
                    {
                        foreach (var p in hd)
                            tableHoaDon.Rows.Add(p.ID,
                            p.TaiKhoanID,
                            p.NguoiLap,
                            p.BanID,
                            p.TenBan,
                            p.NgayLap,
                            p.GiamGia,
                            p.TrangThaiThanhToan,
                            p.TongThanhToan);
                    }
                    // Xuất dữ liệu Hóa đơn chi tiết ra Sheet 2 (HoaDon_ChiTiet)
                    DataTable tableHoaDonChiTiet = new DataTable();
                    tableHoaDonChiTiet.Columns.AddRange(new DataColumn[] {
                        new DataColumn("ID", typeof(int)),
                        new DataColumn("HoaDonID", typeof(int)),
                        new DataColumn("ThucUongID", typeof(int)),
                        new DataColumn("TenThucUong", typeof(string)),
                        new DataColumn("SoLuong", typeof(int)),
                        new DataColumn("DonGia", typeof(decimal)),
                        new DataColumn("GhiChu", typeof(string)),
                        new DataColumn("ThanhTien", typeof(decimal))
                        });
                    var ct = context.HoaDonChiTiet.Select(r => new DanhSachHoaDonChiTiet
                    {
                        ID = r.ID,
                        HoaDonID = r.HoaDonID,
                        ThucUongID = r.ThucUongID,
                        TenThucUong = r.ThucUong.TenThucUong,
                        SoLuong = r.SoLuong,
                        DonGia = r.DonGia,
                        GhiChu = r.GhiChu,
                        ThanhTien = r.SoLuong * r.DonGia
                    }).ToList();
                    if (ct != null)
                    {
                        foreach (var p in ct)
                            tableHoaDonChiTiet.Rows.Add(p.ID,
                            p.HoaDonID,
                            p.ThucUongID,
                            p.TenThucUong,
                            p.SoLuong,
                            p.DonGia,
                            p.GhiChu,
                            p.ThanhTien);
                    }
                    // Gán các bảng tạm vào từng Sheet của tập tin Excel
                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        var sheet1 = wb.Worksheets.Add(tableHoaDon, "HoaDon");
                        sheet1.Columns().AdjustToContents();
                        var sheet2 = wb.Worksheets.Add(tableHoaDonChiTiet, "HoaDonChiTiet");
                        sheet2.Columns().AdjustToContents();
                        wb.SaveAs(saveFileDialog.FileName);
                        MessageBox.Show("Đã xuất dữ liệu ra tập tin Excel thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTuKhoa.Text.Trim(); // Lấy từ khóa người dùng nhập

            // Kiểm tra xem từ khóa có trống không
            if (string.IsNullOrEmpty(tuKhoa))
            {
                frmHoaDon_Load(sender, e);
                return;
            }

            // Truy vấn tìm kiếm dữ liệu hóa đơn từ CSDL
            var hoaDonList = context.HoaDon
                .Where(r => r.TaiKhoan.TenDayDu.Contains(tuKhoa) || // Tìm kiếm theo tên tài khoản
                            r.Ban.TenBan.Contains(tuKhoa) ||           // Tìm kiếm theo tên bàn
                            r.ID.ToString().Contains(tuKhoa))          // Tìm kiếm theo ID hóa đơn
                .Select(r => new
                {
                    r.ID,
                    r.TaiKhoan.TenDayDu,  // Tên khách hàng
                    r.Ban.TenBan,         // Tên bàn
                    r.NgayLap,            // Ngày lập hóa đơn
                    r.GiamGia,            // Giảm giá
                                          // Tính tổng thanh toán = Tổng tiền trừ đi giảm giá
                    TongThanhToan = context.HoaDonChiTiet
                        .Where(ct => ct.HoaDonID == r.ID)
                        .Sum(ct => ct.SoLuong * ct.DonGia) * (1 - r.GiamGia / 100m),
                    InHoaDon = "In hoá đơn"
                }).ToList();

            // Gán dữ liệu vào DataGridView
            dataGridView.DataSource = hoaDonList;
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView.Columns["InHoaDon"].Index)
            {
                int hoaDonID = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells["ID"].Value);

                var result = MessageBox.Show($"Bạn có chắc chắn muốn in hoá đơn {hoaDonID} không?", "Xác nhận", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    frmInHoaDon inHoaDon = new frmInHoaDon(hoaDonID);
                    inHoaDon.ShowDialog();
                }
            }
        }
    }
}
