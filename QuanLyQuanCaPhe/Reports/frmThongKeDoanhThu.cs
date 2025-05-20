using DocumentFormat.OpenXml.InkML;
using Microsoft.Reporting.WinForms;
using QuanLyQuanCaPhe.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static QuanLyQuanCaPhe.Reports.QLQCPDataset;

namespace QuanLyQuanCaPhe.Reports
{
    public partial class frmThongKeDoanhThu : Form
    {
        QLQCPContext context = new QLQCPContext();
        QLQCPDataset.DanhSachHoaDonDataTable danhSachHoaDonDataTable = new QLQCPDataset.DanhSachHoaDonDataTable();
        string reportsFolder = Application.StartupPath.Replace("bin\\Debug\\net8.0-windows", "Reports");

        public frmThongKeDoanhThu()
        {
            InitializeComponent();
        }

        private void btnLocKetQua_Click(object sender, EventArgs e)
        {
            var danhSachHoaDon = context.HoaDon.Select(r => new
            {
                r.ID,
                r.TaiKhoanID,
                TenDayDu = r.TaiKhoan.TenDayDu,
                r.BanID,
                TenBan = r.Ban.TenBan,
                r.NgayLap,
                r.GiamGia,
                r.TongCong, 
                r.TrangThaiThanhToan
            });

            danhSachHoaDon = danhSachHoaDon.Where(r => r.NgayLap >= dtpTuNgay.Value && r.NgayLap <= dtpDenNgay.Value);

            danhSachHoaDonDataTable.Clear();
            foreach (var r in danhSachHoaDon)
            {
                danhSachHoaDonDataTable.AddDanhSachHoaDonRow(
                    r.ID,
                    r.TaiKhoanID,
                    r.TenDayDu,
                    r.BanID,
                    r.TenBan,
                    r.NgayLap,
                    r.GiamGia,
                    r.TongCong,
                    r.TrangThaiThanhToan
                    );
            }

            ReportDataSource reportDataSource = new ReportDataSource();
            reportDataSource.Name = "DanhSachHoaDon";
            reportDataSource.Value = danhSachHoaDonDataTable;

            reportViewer.LocalReport.DataSources.Clear();
            reportViewer.LocalReport.DataSources.Add(reportDataSource);
            reportViewer.LocalReport.ReportPath = Path.Combine(reportsFolder, "rptThongKeDoanhThu.rdlc");

            ReportParameter reportParameter = new ReportParameter("MoTaKetQuaHienThi", "Từ ngày " + dtpTuNgay.Text + " - Đến ngày: " + dtpDenNgay.Text);
            reportViewer.LocalReport.SetParameters(reportParameter);

            reportViewer.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer.ZoomMode = ZoomMode.Percent;
            reportViewer.ZoomPercent = 100;

            reportViewer.RefreshReport();
        }
    }
}
