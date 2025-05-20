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
        }

        private void frmThongKeThucUong_Load(object sender, EventArgs e)
        {
            var danhSachThucUong = context.HoaDonChiTiet
                .GroupBy(r => r.ThucUong.TenThucUong)
                .Select(g => new
                {
                    TenThucUong = g.Key,
                    SoLuong = g.Sum(x => x.SoLuong)
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
    }
}
