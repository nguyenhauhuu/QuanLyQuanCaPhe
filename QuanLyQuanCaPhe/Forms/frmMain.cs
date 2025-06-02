using DocumentFormat.OpenXml.InkML;
using QuanLyQuanCaPhe.Data;
using QuanLyQuanCaPhe.Reports;
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
using BC = BCrypt.Net.BCrypt;


namespace QuanLyQuanCaPhe.Forms
{
    public partial class frmMain : Form
    {
        bool sidebarExpend;
        bool ThongkeBaoCaoCollapsed;
        bool QuanLyCollapsed;
        bool HeThongCollapsed;
        bool TroGiupCollapsed;

        QLQCPContext context = new QLQCPContext();
        frmDangNhap? dangNhap = null;
        frmOrder? order = null;
        frmBan? ban = null;
        frmDanhMuc? danhMuc = null;
        frmThucUong? thucUong = null;
        frmNguyenLieu? nguyenLieu = null;
        frmKho? kho = null;
        frmTaiKhoan? taiKhoan = null;
        frmThongTinTaiKhoan? thongTinTaiKhoan = null;
        frmThongKeDoanhThu? thongKeDoanhThu = null;
        frmThongKeThucUong? thongKeThucUong = null;


        string tenHienThi = "";
        int idTaiKhoan;
        public frmMain()
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




        public void ChuaPhanQuyen()
        {
            OrderContainer.Visible = false;
            ThongKeBaoCaoContainer.Visible = false;
            QuanLyContainer.Visible = false;
            HeThongContainer.Visible = false;
            TroGiupContainer.Visible = false;
            DangNhapContainer.Visible = true;
            lblTieuDe.Text = "";

            if (dangNhap != null)
            {
                dangNhap.txtTenDangNhap.Text = "";
                dangNhap.txtMatKhau.Text = "";
                dangNhap.txtMatKhau.Focus();
            }

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
        private void DangNhap()
        {
        LamLai:
            if (dangNhap == null || dangNhap.IsDisposed)
                dangNhap = new frmDangNhap();


            if (dangNhap.ShowDialog() == DialogResult.OK)
            {
                string tenDangNhap = dangNhap.txtTenDangNhap.Text;
                string matKhau = dangNhap.txtMatKhau.Text;

                if (tenDangNhap.Trim() == "")
                {
                    MessageBox.Show("Tên đăng nhập không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dangNhap.txtTenDangNhap.Focus();
                    goto LamLai;
                }
                else if (matKhau.Trim() == "")
                {
                    MessageBox.Show("Mật khẩu không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dangNhap.txtMatKhau.Focus();
                    goto LamLai;
                }
                else
                {
                    var taikhoan = context.TaiKhoan.Where(r => r.TenDangNhap == tenDangNhap).SingleOrDefault();

                    if (taikhoan == null)
                    {
                        MessageBox.Show("Tên đăng nhập không chính xác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        dangNhap.txtTenDangNhap.Focus();
                        goto LamLai;
                    }
                    else
                    {
                        if (BC.Verify(matKhau, taikhoan.MatKhau))
                        {
                            idTaiKhoan = taikhoan.ID;
                            tenHienThi = taikhoan.TenDayDu;

                            if (taikhoan.QuyenTruyCap == "admin")
                                QuyenAdmin();
                            else if (taikhoan.QuyenTruyCap == "user")
                                QuyenUser();
                            else
                                ChuaPhanQuyen();
                        }
                        else
                        {
                            MessageBox.Show("Mật khẩu không chính xác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            dangNhap.txtMatKhau.Focus();
                            goto LamLai;
                        }
                    }
                }
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            ChuaPhanQuyen();
            DangNhap();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            DangNhap();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.pnlFormLoader.Controls.Clear();
            ChuaPhanQuyen();
            DangNhap();
        }

        private void btnThongTinTaiKhoan_Click(object sender, EventArgs e)
        {
            lblTieuDe.Text = "Thông tin tài khoản";
            this.pnlFormLoader.Controls.Clear();
            thongTinTaiKhoan = new frmThongTinTaiKhoan(idTaiKhoan) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            thongTinTaiKhoan.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(thongTinTaiKhoan);
            thongTinTaiKhoan.Show();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThongKeDoanhThu_Click(object sender, EventArgs e)
        {
            lblTieuDe.Text = "Thống kê doanh thu";
            this.pnlFormLoader.Controls.Clear();
            thongKeDoanhThu = new frmThongKeDoanhThu() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            thongKeDoanhThu.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(thongKeDoanhThu);
            thongKeDoanhThu.Show();
        }

        private void btnThongKeThucUong_Click(object sender, EventArgs e)
        {
            lblTieuDe.Text = "Thống kê thức uống";
            this.pnlFormLoader.Controls.Clear();
            thongKeThucUong = new frmThongKeThucUong() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            thongKeThucUong.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(thongKeThucUong);
            thongKeThucUong.Show();
        }

        private void btnBan_Click(object sender, EventArgs e)
        {
            lblTieuDe.Text = "Quản lý bàn";
            this.pnlFormLoader.Controls.Clear();
            ban = new frmBan() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            ban.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(ban);
            ban.Show();
        }

        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            lblTieuDe.Text = "Quản lý danh mục";
            this.pnlFormLoader.Controls.Clear();
            danhMuc = new frmDanhMuc() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            danhMuc.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(danhMuc);
            danhMuc.Show();
        }

        private void btnThucUong_Click(object sender, EventArgs e)
        {
            lblTieuDe.Text = "Quản lý thức uống";
            this.pnlFormLoader.Controls.Clear();
            thucUong = new frmThucUong() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            thucUong.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(thucUong);
            thucUong.Show();
        }

        private void btnNguyenLieu_Click(object sender, EventArgs e)
        {
            lblTieuDe.Text = "Quản lý nguyên liệu";
            this.pnlFormLoader.Controls.Clear();
            nguyenLieu = new frmNguyenLieu() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            nguyenLieu.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(nguyenLieu);
            nguyenLieu.Show();
        }

        private void btnKho_Click(object sender, EventArgs e)
        {
            lblTieuDe.Text = "Quản lý kho";
            this.pnlFormLoader.Controls.Clear();
            kho = new frmKho() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            kho.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(kho);
            kho.Show();
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            lblTieuDe.Text = "Quản lý tài khoản";
            this.pnlFormLoader.Controls.Clear();
            taiKhoan = new frmTaiKhoan() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            taiKhoan.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(taiKhoan);
            taiKhoan.Show();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            lblTieuDe.Text = "Order";
            this.pnlFormLoader.Controls.Clear();
            order = new frmOrder(idTaiKhoan) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            order.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(order);
            order.Show();
        }

        private void btnHuongDanSuDung_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://chanhdang.com/helper",
                UseShellExecute = true
            });
        }
    }
}
