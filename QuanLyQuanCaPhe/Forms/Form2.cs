using DocumentFormat.OpenXml.InkML;
using QuanLyQuanCaPhe.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace QuanLyQuanCaPhe.Forms
{
    public partial class Form2 : Form
    {
        bool sidebarExpend;
        bool ThongkeBaoCaoCollapsed;
        bool QuanLyCollapsed;
        bool HeThongCollapsed;
        bool TroGiupCollapsed;
        public Form2()
        {
            InitializeComponent();
        }


        private void lblLienKet_Click(object sender, EventArgs e)
        {
            ProcessStartInfo info = new ProcessStartInfo();
            info.FileName = "explorer.exe";
            info.Arguments = "https://chanhdang.com";
            Process.Start(info);
        }
        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpend)
            {
                //if sidebar is expend, minisize
                sidebar.Width -= 10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpend = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpend = true;
                    sidebarTimer.Stop();
                }
            }
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void btnBaoCaoThongKe_Click(object sender, EventArgs e)
        {
            ThongKeBaoCaoTimer.Start();
        }


        private void ThongKeBaoCaoTimer_Tick(object sender, EventArgs e)
        {
            if (ThongkeBaoCaoCollapsed)
            {
                //if container is collapsed, minisize
                ThongKeBaoCaoContainer.Height -= 10;
                if (ThongKeBaoCaoContainer.Height == ThongKeBaoCaoContainer.MinimumSize.Height)
                {
                    ThongkeBaoCaoCollapsed = false;
                    ThongKeBaoCaoTimer.Stop();
                }
            }
            else
            {
                ThongKeBaoCaoContainer.Height += 10;
                if (ThongKeBaoCaoContainer.Height == ThongKeBaoCaoContainer.MaximumSize.Height)
                {
                    ThongkeBaoCaoCollapsed = true;
                    ThongKeBaoCaoTimer.Stop();
                }
            }
        }

        private void QuanLyTimer_Tick(object sender, EventArgs e)
        {
            if (QuanLyCollapsed)
            {
                //if container is collapsed, minisize
                QuanLyContainer.Height -= 10;
                if (QuanLyContainer.Height == QuanLyContainer.MinimumSize.Height)
                {
                    QuanLyCollapsed = false;
                    QuanLyTimer.Stop();
                }
            }
            else
            {
                QuanLyContainer.Height += 10;
                if (QuanLyContainer.Height == QuanLyContainer.MaximumSize.Height)
                {
                    QuanLyCollapsed = true;
                    QuanLyTimer.Stop();
                }
            }
        }

        private void btnQuanLy_Click(object sender, EventArgs e)
        {
            QuanLyTimer.Start();
        }

        private void HeThongTimer_Tick(object sender, EventArgs e)
        {
            if (HeThongCollapsed)
            {
                //if container is collapsed, minisize
                HeThongContainer.Height -= 10;
                if (HeThongContainer.Height == HeThongContainer.MinimumSize.Height)
                {
                    HeThongCollapsed = false;
                    HeThongTimer.Stop();
                }
            }
            else
            {
                HeThongContainer.Height += 10;
                if (HeThongContainer.Height == HeThongContainer.MaximumSize.Height)
                {
                    HeThongCollapsed = true;
                    HeThongTimer.Stop();
                }
            }
        }

        private void TroGiupTimer_Tick(object sender, EventArgs e)
        {
            if (TroGiupCollapsed)
            {
                //if container is collapsed, minisize
                TroGiupContainer.Height -= 10;
                if (TroGiupContainer.Height == TroGiupContainer.MinimumSize.Height)
                {
                    TroGiupCollapsed = false;
                    TroGiupTimer.Stop();
                }
            }
            else
            {
                TroGiupContainer.Height += 10;
                if (TroGiupContainer.Height == TroGiupContainer.MaximumSize.Height)
                {
                    TroGiupCollapsed = true;
                    TroGiupTimer.Stop();
                }
            }
        }

        private void btnHeThong_Click(object sender, EventArgs e)
        {
            HeThongTimer.Start();
        }

        private void btnTroGiup_Click(object sender, EventArgs e)
        {
            TroGiupTimer.Start();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            ThongKeBaoCaoContainer.Visible = false;

        }
       

        public void ChuaPhanQuyen()
        {
            OrderContainer.Visible = false;
            ThongKeBaoCaoContainer.Visible = false;
            QuanLyContainer.Visible = false;
            HeThongContainer.Visible = false;
            TroGiupContainer.Visible = false;
            DangNhapContainer.Visible = true;
            lblTieuDe.Text = "";
        }

        public void QuyenAdmin()
        {
            OrderContainer.Visible = true;
            ThongKeBaoCaoContainer.Visible = true;
            QuanLyContainer.Visible = true;
            HeThongContainer.Visible = true;
            TroGiupContainer.Visible = true;
            DangNhapContainer.Visible = false;
        }

        public void QuyenUser()
        {
            OrderContainer.Visible = true;
            ThongKeBaoCaoContainer.Visible = false;
            QuanLyContainer.Visible = false;
            HeThongContainer.Visible = true;
            TroGiupContainer.Visible = true;
            DangNhapContainer.Visible = false;
        }


    }
}
