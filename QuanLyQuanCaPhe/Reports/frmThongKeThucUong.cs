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
    public partial class frmThongKeThucUong : Form
    {
        QLQCPContext context = new QLQCPContext();
        QLQCPDataset.ThongKeThucUongDataTable thongKeThucUongDataTable = new QLQCPDataset.ThongKeThucUongDataTable();
        string reportsFolder = Application.StartupPath.Replace("bin\\Debug\\net8.0-windows", "Reports");

        public frmThongKeThucUong()
        {
            InitializeComponent();
            helpProvider1.SetHelpString(this, "https://chanhdang.com/helper#TKThucUong");
            this.HelpRequested += (s, e) =>
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(helpProvider1.GetHelpString(this)!) { UseShellExecute = true });
                e.Handled = true;
            };
        }

        private void frmThongKeThucUong_Load(object sender, EventArgs e)
        {
            var danhSachThucUong = context.HoaDonChiTiet
                .Select(g => new
                {
                    TenThucUong = g.ThucUong.TenThucUong,
                    SoLuong = g.SoLuong
                })
                .ToList();



            thongKeThucUongDataTable.Clear();
            foreach (var r in danhSachThucUong)
            {
                thongKeThucUongDataTable.AddThongKeThucUongRow(
                       r.TenThucUong,
                       r.SoLuong
                    );
            }

            ReportDataSource reportDataSource = new ReportDataSource();
            reportDataSource.Name = "dsThongKeThucUong";
            reportDataSource.Value = thongKeThucUongDataTable;

            reportViewer.LocalReport.DataSources.Clear();
            reportViewer.LocalReport.DataSources.Add(reportDataSource);
            reportViewer.LocalReport.ReportPath = Path.Combine(reportsFolder, "rptThongKeThucUong.rdlc");

            ReportParameter reportParameter = new ReportParameter("MoTaKetQuaHienThi", "(Tất cả các nước)");
            reportViewer.LocalReport.SetParameters(reportParameter);

            reportViewer.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer.ZoomMode = ZoomMode.Percent;
            reportViewer.ZoomPercent = 100;

            reportViewer.RefreshReport();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            var dsThucUong = context.HoaDonChiTiet
                .Where(r => r.HoaDon.NgayLap >= dtpTuNgay.Value && r.HoaDon.NgayLap <= dtpDenNgay.Value)

                // 2. Group theo tên thức uống
                .GroupBy(r => r.ThucUong.TenThucUong)

                // 3. Tính tổng số lượng
                .Select(g => new
                {
                    TenThucUong = g.Key,
                    SoLuong = g.Sum(x => x.SoLuong)
                });

            if (cboTieuChi.SelectedIndex == 1) //Top5
            {
                dsThucUong = dsThucUong.OrderByDescending(x => x.SoLuong).Take(5);
             }
            else if (cboTieuChi.SelectedIndex == 2) // Bottom 5
            {
                dsThucUong = dsThucUong.OrderBy(x => x.SoLuong).Take(5);
            }

            var danhSachThucUong = dsThucUong.ToList();

            thongKeThucUongDataTable.Clear();
            foreach (var r in danhSachThucUong)
            {
                thongKeThucUongDataTable.AddThongKeThucUongRow(
                       r.TenThucUong,
                       r.SoLuong
                    );
            }

            string moTa;

            if (cboTieuChi.SelectedIndex == 0)
            {
                moTa = "(Tất cả các thức uống)";
            }
            else if (cboTieuChi.SelectedIndex == 1)
            {
                moTa = "(Top 5 thức uống bán chạy nhất)";
            }
            else // cboTieuChi.SelectedIndex == 2
            {
                moTa = "(Bottom 5 thức uống bán chậm nhất)";
            }

            ReportDataSource reportDataSource = new ReportDataSource();
            reportDataSource.Name = "dsThongKeThucUong";
            reportDataSource.Value = thongKeThucUongDataTable;

            reportViewer.LocalReport.DataSources.Clear();
            reportViewer.LocalReport.DataSources.Add(reportDataSource);
            reportViewer.LocalReport.ReportPath = Path.Combine(reportsFolder, "rptThongKeThucUong.rdlc");

            ReportParameter reportParameter = new ReportParameter("MoTaKetQuaHienThi", moTa);
            reportViewer.LocalReport.SetParameters(reportParameter);

            reportViewer.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer.ZoomMode = ZoomMode.Percent;
            reportViewer.ZoomPercent = 100;

            reportViewer.RefreshReport();
        }
    }
}
