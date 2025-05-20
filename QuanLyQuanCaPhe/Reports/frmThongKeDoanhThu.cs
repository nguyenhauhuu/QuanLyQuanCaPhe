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

namespace QuanLyQuanCaPhe.Reports
{
    public partial class frmThongKeDoanhThu : Form
    {
        QLQCPContext context = new QLQCPContext();
        QLQCPDataSet.DanhSachHoaDonDataTable danhSachHoaDonDataTable = new QLQCPDataSet.DanhSachHoaDonDataTable();
        string reportsFolder = Application.StartupPath.Replace("bin\\Debug\\net8.0-windows", "Reports");
        public frmThongKeDoanhThu()
        {
            InitializeComponent();
        }

        private void frmThongKeDoanhThu_Load(object sender, EventArgs e)
        {
            var danhSachHoaDon = context.HoaDon.Select(r => new
            {
                r.ID,
                r.TaiKhoanID,
                r.TaiKhoan.TenDayDu,
                r.BanID,
                r.Ban.TenBan,
                r.GiamGia,
                r.TongCong,
                r.NgayLap
            }).ToList();

            danhSachHoaDonDataTable.Clear();
            foreach (var row in danhSachHoaDon)
            {
                danhSachHoaDonDataTable.AddDanhSachHoaDonRow(
                    row.ID,
                    row.TaiKhoanID,
                    row.TenDayDu,
                    row.BanID,
                    row.TenBan,
                    row.GiamGia,
                    row.TongCong,
                    row.NgayLap)
;
            }

            ReportDataSource reportDataSource = new ReportDataSource();
            reportDataSource.Name = "dsHoaDon";
            reportDataSource.Value = danhSachHoaDonDataTable;

            reportViewer.LocalReport.DataSources.Clear();
            reportViewer.LocalReport.DataSources.Add(reportDataSource);
            reportViewer.LocalReport.ReportPath = Path.Combine(reportsFolder, "rptThongKeDoanhThu.rdlc");

            reportViewer.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer.ZoomMode = ZoomMode.Percent;
            reportViewer.ZoomPercent = 100;

            reportViewer.RefreshReport();
        }
    }
}
