using DocumentFormat.OpenXml.Office2010.Excel;
using DocumentFormat.OpenXml.Wordprocessing;
using QuanLyQuanCaPhe.Data;
using QuanLyQuanCaPhe.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BC = BCrypt.Net.BCrypt;


namespace QuanLyQuanCaPhe.Forms
{
    public partial class Form1 : Form
    {
        QLQCPContext context = new QLQCPContext();
        frmDangNhap? dangNhap = null;
        frmChucNang? chucNang = null;
        frmBan? ban = null;
        frmDanhMuc? danhMuc = null;

        frmThucUong? thucUong = null;
        frmTaiKhoan? taiKhoan = null;
        frmThongKeDoanhThu? thongKeDoanhThu = null;
        frmThongKeThucUong? thongKeThucUong = null;
        frmThongTinTaiKhoan? thongTinTaiKhoan = null;
        string tenHienThi = "";
        int idTaiKhoan;




        public Form1()
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
                            Logger.GhiLog($"Tài khoản ID {idTaiKhoan} đã đăng nhập");
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
            btnBan.Visible = false;
            btnDanhMuc.Visible = false;
            btnTaiKhoan.Visible = false;
            btnThucUong.Visible = false;
            btnThongKeDoanhThu.Visible = false;
            btnTaiKhoan.Visible = false;
            btnDangXuat.Visible = false;
            btnBanNuoc.Visible = false;
            btnThongKeThucUong.Visible = false;

            lblTenDayDu.Text = "Chưa đăng nhập.";
        }
        public void QuyenAdmin()
        {
            btnBan.Visible = true;
            btnDanhMuc.Visible = true;
            btnTaiKhoan.Visible = true;
            btnThucUong.Visible = true;
            btnThongKeDoanhThu.Visible = true;
            btnThongKeThucUong.Visible = true;
            btnTaiKhoan.Visible = true;
            btnDangXuat.Visible = true;
            btnDangNhap.Visible = false;
            btnBanNuoc.Visible = true; ;
            lblTenDayDu.Text = tenHienThi;
        }

        public void QuyenUser()
        {
            btnBanNuoc.Visible = true;
            btnDangXuat.Visible = true;
            btnDangNhap.Visible = false;
            lblTenDayDu.Text = tenHienThi;
        }


        private void btnBan_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Quản lý bàn";
            this.pnlFormLoader.Controls.Clear();
            ban = new frmBan() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            ban.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(ban);
            ban.Show();
            Logger.GhiLog($"Tài khoản ID {idTaiKhoan} đã click vào danh sách bàn");

        }

        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Quản lý danh mục";
            this.pnlFormLoader.Controls.Clear();
            danhMuc = new frmDanhMuc() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            danhMuc.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(danhMuc);
            danhMuc.Show();
            Logger.GhiLog($"Tài khoản ID {idTaiKhoan} đã click vào danh mục");

        }

        private void btnThucUong_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Quản lý thức uống";
            this.pnlFormLoader.Controls.Clear();
            thucUong = new frmThucUong() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            thucUong.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(thucUong);
            thucUong.Show();
            Logger.GhiLog($"Tài khoản ID {idTaiKhoan} đã click vào thức uống");

        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Quản lý tài khoản";
            this.pnlFormLoader.Controls.Clear();
            taiKhoan = new frmTaiKhoan() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            taiKhoan.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(taiKhoan);
            taiKhoan.Show();
            Logger.GhiLog($"Tài khoản ID {idTaiKhoan} đã click vào quản lý tài khoản");

        }

        private void btnBanNuoc_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Bán nước";
            this.pnlFormLoader.Controls.Clear();
            chucNang = new frmChucNang(idTaiKhoan) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            chucNang.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(chucNang);
            chucNang.Show();
            Logger.GhiLog($"Tài khoản ID {idTaiKhoan} đã click vào bán nước");

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ChuaPhanQuyen();
            DangNhap();

            string fileName = context.TaiKhoan.Find(idTaiKhoan)?.HinhAnh ?? "no-image.jpg";
            string imageFolder = Application.StartupPath.Replace("bin\\Debug\\net8.0-windows", "Images");
            string imagePath = Path.Combine(imageFolder, fileName);


            picHinhAnh.Image = Image.FromFile(imagePath);


        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            DangNhap();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "TIÊU ĐỀ";
            this.pnlFormLoader.Controls.Clear();
            ChuaPhanQuyen();
            DangNhap();
            Logger.GhiLog($"Tài khoản ID {idTaiKhoan} đã đăng xuất");

        }

        private void btnThongKeDoanhThu_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Thong ke doanh thu";
            this.pnlFormLoader.Controls.Clear();
            thongKeDoanhThu = new frmThongKeDoanhThu() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            thongKeDoanhThu.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(thongKeDoanhThu);
            thongKeDoanhThu.Show();
            Logger.GhiLog($"Tài khoản ID {idTaiKhoan} đã click vào thống kê doanh thu");

        }

        private void btnThongKeThucUong_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Thong ke thuc uong";
            this.pnlFormLoader.Controls.Clear();
            thongKeThucUong = new frmThongKeThucUong() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            thongKeThucUong.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(thongKeThucUong);
            thongKeThucUong.Show();
            Logger.GhiLog($"Tài khoản ID {idTaiKhoan} đã click vào thống kê thức uống");

        }

        private void picHinhAnh_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Thông tin tài khoản";
            this.pnlFormLoader.Controls.Clear();
            thongTinTaiKhoan = new frmThongTinTaiKhoan(idTaiKhoan) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            thongTinTaiKhoan.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(thongTinTaiKhoan);
            thongTinTaiKhoan.Show();
            Logger.GhiLog($"Tài khoản ID {idTaiKhoan} đã truy cập thông tin cá nhân");
        }
    }
}
