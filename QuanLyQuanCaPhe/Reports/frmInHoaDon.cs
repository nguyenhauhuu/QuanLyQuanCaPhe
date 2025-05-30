using Microsoft.Reporting.WinForms;
using QuanLyQuanCaPhe.Data;
using System.Configuration;
using System.Data;
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

            var hoaDon = context.HoaDon
                .Select(r => new
                {
                    r.ID,
                    r.TaiKhoanID,
                    r.TaiKhoan.TenDayDu,
                    r.BanID,
                    r.Ban.TenBan,
                    r.NgayLap,
                    r.GiamGia,
                    r.TrangThaiThanhToan,

                    TongTien = context.HoaDonChiTiet
                          .Where(ct => ct.HoaDonID == r.ID)
                          .Sum(ct => ct.SoLuong * ct.DonGia),

                    TongThanhToan = context.HoaDonChiTiet
                          .Where(ct => ct.HoaDonID == r.ID)
                          .Sum(ct => ct.SoLuong * ct.DonGia) * (1 - r.GiamGia / 100m)
                })
                .FirstOrDefault(r=> r.ID == id);  

            if (hoaDon != null)
            {
                var hoaDonChiTiet = context.HoaDonChiTiet.Where(r => r.HoaDonID == id).Select(r => new DanhSachHoaDonChiTiet
                {
                    ID = r.ID,
                    HoaDonID = r.HoaDonID,
                    ThucUongID = r.ThucUongID,
                    TenThucUong = r.ThucUong.TenThucUong,
                    SoLuong = r.SoLuong,
                    DonGia = r.ThucUong.DonGia,
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
                        row.DonGia,
                        row.ThanhTien);
                }

                ReportDataSource reportDataSource = new ReportDataSource();
                reportDataSource.Name = "DanhSachHoaDonChiTiet";
                reportDataSource.Value = danhSachHoaDonChiTietDataTable;

                reportViewer.LocalReport.ReportPath = Path.Combine(reportsFolder, "rptInHoaDon.rdlc");
                reportViewer.LocalReport.DataSources.Clear();
                reportViewer.LocalReport.DataSources.Add(reportDataSource);


                string bankId = ConfigurationManager.AppSettings["IDNganHang"]!;
                string accountNo = ConfigurationManager.AppSettings["STKNganHang"]!;
                string addInfo = ConfigurationManager.AppSettings["ThongTinThanhToan"]!;
                string url = $"https://img.vietqr.io/image/{bankId}-{accountNo}-compact.png?amount={hoaDon.TongThanhToan}&addInfo=<{addInfo}>";

                using HttpClient client = new HttpClient();
                byte[] qrImage = await client.GetByteArrayAsync(url);


                IList<ReportParameter> param = new List<ReportParameter>
                {
                    new ReportParameter("IDHoaDon", hoaDon.ID.ToString()),
                    new ReportParameter("QRCodeImage", Convert.ToBase64String(qrImage)),
                    new ReportParameter("NhanVien", hoaDon.TenDayDu),
                    new ReportParameter("TongTien", hoaDon.TongTien.ToString()),
                    new ReportParameter("GiamGia", hoaDon.GiamGia.ToString()),
                    new ReportParameter("TenQuanCaPhe",  ConfigurationManager.AppSettings["TenQuan"]),
                    new ReportParameter("DiaChi",  ConfigurationManager.AppSettings["DiaChi"]),
                    new ReportParameter("SDT",  ConfigurationManager.AppSettings["SDT"]!),
                    new ReportParameter("TongThanhToan", hoaDon.TongThanhToan.ToString())
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