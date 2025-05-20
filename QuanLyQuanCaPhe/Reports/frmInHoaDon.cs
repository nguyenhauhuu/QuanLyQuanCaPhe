using Microsoft.EntityFrameworkCore;
using Microsoft.Reporting.WinForms;
using QRCoder;
using QuanLyQuanCaPhe.Data;
using System.Data;
using System.Drawing.Imaging;
using static QuanLyQuanCaPhe.Data.HoaDonChiTiet;

namespace QuanLyQuanCaPhe.Reports
{
    public partial class frmInHoaDon : Form
    {
        QLQCPContext context = new QLQCPContext();
        QLQCPDataset.DanhSachHoaDonChiTietDataTable danhSachHoaDonChiTietDataTable = new QLQCPDataset.DanhSachHoaDonChiTietDataTable();
        string reportsFolder = Application.StartupPath.Replace("bin\\Debug\\net8.0-windows", "Reports");
        int id; // Mã hóa đơn 

        public frmInHoaDon(int maHoaDon = 0)
        {
            InitializeComponent();
            id = maHoaDon;
        }

        private async void frmInHoaDon_Load(object sender, EventArgs e)
        {

            var hoaDon = context.HoaDon.Include(r => r.TaiKhoan).Include(r => r.HoaDonChiTiet)
                .Where(r => r.ID == id).SingleOrDefault();

            if (hoaDon != null)
            {
                var hoaDonChiTiet = context.HoaDonChiTiet.Where(r => r.HoaDonID == id).Select(r => new DanhSachHoaDonChiTiet
                {
                    ID = r.ID,
                    HoaDonID = r.HoaDonID,
                    ThucUongID = r.ThucUongID,
                    TenThucUong = r.ThucUong.TenThucUong,
                    SoLuong = r.SoLuong,
                    Gia = r.ThucUong.DonGia,
                    ThanhTien = r.SoLuong * r.ThucUong.DonGia
                }).ToList();

                danhSachHoaDonChiTietDataTable.Clear();
                foreach (var row in hoaDonChiTiet)
                {
                    danhSachHoaDonChiTietDataTable.AddDanhSachHoaDonChiTietRow(row.ID,
                        row.HoaDonID,
                        row.ThucUongID,
                        row.TenThucUong,
                        row.SoLuong,
                        row.Gia,
                        row.ThanhTien);
                }

                ReportDataSource reportDataSource = new ReportDataSource();
                reportDataSource.Name = "DanhSachHoaDonChiTiet";
                reportDataSource.Value = danhSachHoaDonChiTietDataTable;

                reportViewer.LocalReport.ReportPath = Path.Combine(reportsFolder, "rptInHoaDon.rdlc");
                reportViewer.LocalReport.DataSources.Clear();
                reportViewer.LocalReport.DataSources.Add(reportDataSource);


                string bankId = "VCB";
                string accountNo = "1032306591";
                string template = "compact"; // hoặc default
                decimal amount = 100000;
                string addInfo = "ThanhToan";

                string url = $"https://img.vietqr.io/image/{bankId}-{accountNo}-{template}.png?amount={amount}&addInfo={Uri.EscapeDataString(addInfo)}";

                using HttpClient client = new HttpClient();
                byte[] qrImage = await client.GetByteArrayAsync(url);


                IList<ReportParameter> param = new List<ReportParameter>
                {
                    new ReportParameter("IDHoaDon", hoaDon.ID.ToString()),
                    new ReportParameter("QRCodeImage", Convert.ToBase64String(qrImage)),
                    new ReportParameter("NhanVien", hoaDon.TaiKhoan.TenDayDu),
                    new ReportParameter("TongCong", hoaDon.TongCong.ToString()),
                    new ReportParameter("GiamGia", hoaDon.GiamGia.ToString()),
                    new ReportParameter("ThanhTien", hoaDon.HoaDonChiTiet.Sum(r => r.SoLuong * r.Gia).ToString())
                };
                reportViewer.LocalReport.SetParameters(param);

                reportViewer.SetDisplayMode(DisplayMode.PrintLayout);
                reportViewer.ZoomMode = ZoomMode.Percent;
                reportViewer.ZoomPercent = 100;

                reportViewer.RefreshReport();
            }
        }
    }
}