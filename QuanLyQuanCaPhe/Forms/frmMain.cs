using QuanLyQuanCaPhe.Data;
using QuanLyQuanCaPhe.Forms;
using QuanLyQuanCaPhe.Reports;
using System.Diagnostics;
using System.Windows.Forms;
using BC = BCrypt.Net.BCrypt;


namespace QuanLyQuanCaPhe
{
    public partial class frmMain : Form
    {
        public HelpProvider HelpProvider;

        QLQCPContext context = new QLQCPContext();
        frmDangNhap? dangNhap = null;
        frmChucNang? chucNang = null;
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
        public void ChuaPhanQuyen()
        {
            mnuDangNhap.Visible = true;

            mnuDangXuat.Visible = false;
            mnuChucNang.Visible = false;
            mnuQuanLy.Visible = false;
            mnuThongTinTaiKhoan.Visible = false;

            lblTrangThai.Text = "Chưa đăng nhập.";
        }
        public void QuyenAdmin()
        {
            mnuDangNhap.Visible = false;

            mnuDangXuat.Visible = true;

            mnuQuanLy.Visible = true;
            mnuChucNang.Visible = true;
            mnuThongTinTaiKhoan.Visible = true;

            lblTrangThai.Text = "Xin chào: " + tenHienThi;
        }

        public void QuyenUser()
        {
            mnuDangNhap.Visible = false;
            mnuQuanLy.Visible = false;
            mnuChucNang.Visible = true;
            mnuThongTinTaiKhoan.Visible = true;
            lblTrangThai.Text = "Xin chào: " + tenHienThi;
        }
        private void lblLienKet_Click(object sender, EventArgs e)
        {
            ProcessStartInfo info = new ProcessStartInfo();
            info.FileName = "explorer.exe";
            info.Arguments = "https://chanhdang.com";
            Process.Start(info);
        }

        private void mnuDangXuat_Click(object sender, EventArgs e)
        {
            foreach (Form child in MdiChildren)
            {
                child.Close();
            }
            ChuaPhanQuyen();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            ChuaPhanQuyen();
            DangNhap();
        }

        private void mnuDangNhap_Click(object sender, EventArgs e)
        {
            DangNhap();
        }

        private void mnuChucNang_Click(object sender, EventArgs e)
        {
            if (chucNang == null || chucNang.IsDisposed)
            {
                chucNang = new frmChucNang(idTaiKhoan);
                chucNang.MdiParent = this;
                chucNang.Show();
            }
            else
                chucNang.Activate();
        }

        private void mnuBan_Click(object sender, EventArgs e)
        {
            if (ban == null || ban.IsDisposed)
            {
                ban = new frmBan();
                ban.MdiParent = this;
                ban.Show();
            }
            else
                ban.Activate();
        }

        private void mnuDanhMuc_Click(object sender, EventArgs e)
        {
            if (danhMuc == null || danhMuc.IsDisposed)
            {
                danhMuc = new frmDanhMuc();
                danhMuc.MdiParent = this;
                danhMuc.Show();
            }
            else
                danhMuc.Activate();
        }

        private void mnuThucUong_Click(object sender, EventArgs e)
        {
            if (thucUong == null || thucUong.IsDisposed)
            {
                thucUong = new frmThucUong();
                thucUong.MdiParent = this;
                thucUong.Show();
            }
            else
                thucUong.Activate();
        }

        private void mnuTaiKhoan_Click(object sender, EventArgs e)
        {
            if (taiKhoan == null || taiKhoan.IsDisposed)
            {
                taiKhoan = new frmTaiKhoan();
                taiKhoan.MdiParent = this;
                taiKhoan.Show();
            }
            else
                taiKhoan.Activate();
        }

        private void mnuDoanhThu_Click(object sender, EventArgs e)
        {
            if (thongKeDoanhThu == null || thongKeDoanhThu.IsDisposed)
            {
                thongKeDoanhThu = new frmThongKeDoanhThu();
                thongKeDoanhThu.MdiParent = this;
                thongKeDoanhThu.Show();
            }
            else
                thongKeDoanhThu.Activate();
        }

        private void mnuThongKeThucUong_Click(object sender, EventArgs e)
        {
            if (thongKeThucUong == null || thongKeThucUong.IsDisposed)
            {
                thongKeThucUong = new frmThongKeThucUong();
                thongKeThucUong.MdiParent = this;
                thongKeThucUong.Show();
            }
            else
                thongKeThucUong.Activate();
        }

        private void mnuHuongDanSuDung_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://nguyenhauhuu.github.io/demo/",
                UseShellExecute = true
            });
        }

        private void mnuThongTinTaiKhoan_Click(object sender, EventArgs e)
        {
            if (thongTinTaiKhoan == null || thongTinTaiKhoan.IsDisposed)
            {
                thongTinTaiKhoan = new frmThongTinTaiKhoan(idTaiKhoan);
                thongTinTaiKhoan.MdiParent = this;
                thongTinTaiKhoan.Show();
            }
            else
                thongTinTaiKhoan.Activate();

            Logger.GhiLog($"Tài khoản ID {idTaiKhoan} đã truy cập thông tin cá nhân");
        }

        private void mnuNguyenLieu_Click(object sender, EventArgs e)
        {
            if (nguyenLieu == null || nguyenLieu.IsDisposed)
            {
                nguyenLieu = new frmNguyenLieu();
                nguyenLieu.MdiParent = this;
                nguyenLieu.Show();
            }
            else
                nguyenLieu.Activate();
        }

        private void mnuKho_Click(object sender, EventArgs e)
        {
            if (kho   == null || kho.IsDisposed)
            {
                kho = new frmKho();
                kho.MdiParent = this;
                kho.Show();
            }
            else
                kho.Activate();
        }
    }
}