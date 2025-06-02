using QuanLyQuanCaPhe.Data;
using SlugGenerator;
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
    public partial class frmThongTinTaiKhoan : Form
    {
        int id;
        QLQCPContext context = new QLQCPContext();
        TaiKhoan taiKhoan = new TaiKhoan();
        string imageFolder = Application.StartupPath.Replace("bin\\Debug\\net8.0-windows", "Images");
        string imageName = "no-image.jpg";


        public frmThongTinTaiKhoan(int idTaiKhoan)
        {
            InitializeComponent();
            id = idTaiKhoan;
            taiKhoan = context.TaiKhoan.Find(id)!;
            helpProvider1.SetHelpString(this, "https://nguyenhauhuu.github.io/demo/");
            this.HelpRequested += (s, e) =>
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(helpProvider1.GetHelpString(this)!) { UseShellExecute = true });
                e.Handled = true;
            };
        }
        private void LoadThongTinTaiKhoan()
        {
            txtTenDayDu.Text = taiKhoan.TenDayDu;
            dtpNgaySinh.Value = taiKhoan.NgaySinh;
            imageName = taiKhoan.HinhAnh ?? "no-image.jpg";
            string imagePath = Path.Combine(imageFolder, imageName);
            picHinhAnh.Image = Image.FromFile(imagePath);
        }
        private void BatTatChucNang(bool giatri)
        {
            txtTenDayDu.Enabled = giatri;
            dtpNgaySinh.Enabled = giatri;
            picHinhAnh.Enabled = giatri;
            btnSua.Enabled = !giatri;
            btnLuu.Enabled = giatri;

        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            BatTatChucNang(true);
            txtTenDayDu.Focus();
        }

        private void frmThongTinTaiKhoan_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            LoadThongTinTaiKhoan();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            taiKhoan.TenDayDu = txtTenDayDu.Text;
            taiKhoan.NgaySinh = dtpNgaySinh.Value;
            taiKhoan.HinhAnh = imageName;
            context.TaiKhoan.Update(taiKhoan);
            context.SaveChanges();
        }

        private void picHinhAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Chọn hình ảnh sản phẩm";
            openFileDialog.Filter = "Tập tin hình ảnh|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog.Multiselect = false;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = Path.GetFileNameWithoutExtension(openFileDialog.FileName);
                string ext = Path.GetExtension(openFileDialog.FileName);
                // Lưu tên file hình vào biến toàn cục
                imageName = fileName.GenerateSlug() + ext;
                // Sao chép file hình vào thư mục Images
                string fileSavePath = Path.Combine(imageFolder, imageName);
                File.Copy(openFileDialog.FileName, fileSavePath, true);
                // Hiện hình ảnh đã chọn lên PictureBox
                picHinhAnh.Image = Image.FromFile(fileSavePath);
            }
        }

        private void btnCapNhatMatKhau_Click(object sender, EventArgs e)
        {
            string matKhauHienTai = txtMatKhauHienTai.Text.Trim();
            string matKhauMoi = txtMatKhauMoi.Text.Trim();
            string xacNhanMatKhau = txtXacNhanMatKhau.Text.Trim();
            if (matKhauMoi != xacNhanMatKhau)
            {
                MessageBox.Show("Mật khẩu mới và xác nhận mật khẩu không trùng nhau!");
            }
            else if (matKhauMoi == "")
            {
                MessageBox.Show("Mật khẩu mới không được bỏ trống");
            }
            else if (!BC.Verify(matKhauHienTai, taiKhoan.MatKhau))
            {
                MessageBox.Show("Mật khẩu hiện tại không đúng!");
            }
            else
            {
                taiKhoan.MatKhau = BC.HashPassword(matKhauMoi);
                context.TaiKhoan.Update(taiKhoan);
                context.SaveChanges();
                MessageBox.Show("Cập nhật mật khẩu thành công!");
            }
        }
    }
}
