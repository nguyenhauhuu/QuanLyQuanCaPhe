using QuanLyQuanCaPhe.Forms;
using QuanLyQuanCaPhe.Data;

using System.Diagnostics;
using BC = BCrypt.Net.BCrypt;


namespace QuanLyQuanCaPhe
{
    public partial class frmMain : Form
    {

        QLQCPContext context = new QLQCPContext();
        frmDangNhap? dangNhap = null;
        frmChucNang chucNang = null;
        string tenHienThi = "";

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
                chucNang = new frmChucNang();
                chucNang.MdiParent = this;
                chucNang.Show();
            }
            else
                chucNang.Activate();

        }
    }
}