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

namespace QuanLyQuanCaPhe.Forms
{
    public partial class frmXacNhanThanhToan : Form
    {
        QLQCPContext context = new QLQCPContext();
        int id;
        decimal tongCong;
        public frmXacNhanThanhToan()
        {
            InitializeComponent();
        }
        public frmXacNhanThanhToan(int maHoaDon)
        {
            InitializeComponent();
            id = maHoaDon;
            helpProvider1.SetHelpString(this, "https://chanhdang.com/helper#ThanhToan");
            this.HelpRequested += (s, e) =>
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(helpProvider1.GetHelpString(this)!) { UseShellExecute = true });
                e.Handled = true;
            };
        }

        private void frmXacNhanThanhToan_Load(object sender, EventArgs e)
        {
            var hoaDon = context.HoaDon
                .Select(r => new
                {
                    r.ID,
                    r.TaiKhoanID,
                    r.BanID,
                    r.NgayLap,
                    r.GiamGia,
                    r.TrangThaiThanhToan,

                    TongTien = context.HoaDonChiTiet
                          .Where(ct => ct.HoaDonID == r.ID)
                          .Sum(ct => ct.SoLuong * ct.DonGia),

                    TongThanhToan = context.HoaDonChiTiet
                          .Where(ct => ct.HoaDonID == r.ID)
                          .Sum(ct => ct.SoLuong * ct.DonGia) * (1 - r.GiamGia / 100m)
                })
                .FirstOrDefault(r => r.ID == id);

            txtID.Text = hoaDon!.ID.ToString();
            tongCong = hoaDon.TongThanhToan;
            txtThanhTien.Text = tongCong.ToString("#,##0") + " đ";
        }

        private void cboHinhThucThanhToan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboHinhThucThanhToan.Text == "Tiền mặt")
            {
                txtTienKhachDua.Enabled = true;
            }
            else
            {
                txtTienKhachDua.Enabled = false;
            }
        }

        private void txtTienKhachDua_TextChanged(object sender, EventArgs e)
        {
            string text = txtTienKhachDua.Text.Replace(",", "").Replace("đ", "").Trim();

            if (decimal.TryParse(text, out decimal value))
            {
                txtTienKhachDua.TextChanged -= txtTienKhachDua_TextChanged!; // ngắt sự kiện để tránh lặp vô hạn

                txtTienKhachDua.Text = value.ToString("#,##0");
                txtTienKhachDua.SelectionStart = txtTienKhachDua.Text.Length; // đưa con trỏ về cuối

                txtTienKhachDua.TextChanged += txtTienKhachDua_TextChanged!;
            }

            // Cập nhật tiền thừa
            decimal tienThua = value - tongCong;
            txtTienThua.Text = tienThua.ToString("#,##0") + " đ";
        }



        private void txtTienKhachDua_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            var hoaDon = context.HoaDon.Find(id);
            var ban = context.Ban.Find(hoaDon!.BanID);
            if (cboHinhThucThanhToan.Text == "Chuyển khoản")
            {
                frmInHoaDon inHoaDon = new frmInHoaDon(id);
                inHoaDon.ShowDialog();
                hoaDon!.TrangThaiThanhToan = 2;
                ban!.TrangThai = 0;
                context.HoaDon.Update(hoaDon);
                context.Ban.Update(ban);
                context.SaveChanges();
                this.Close();

            }
            else if (cboHinhThucThanhToan.Text == "Tiền mặt")
            {
                if (Convert.ToInt32(txtTienKhachDua.Text.Replace(",", "").Trim()) < Convert.ToInt32(txtThanhTien.Text.Replace(",", "").Replace("đ", "").Trim()))
                {
                    MessageBox.Show("Tiền khách đưa bé hơn tiền cần thanh toán");
                    return;
                }
                frmInHoaDon inHoaDon = new frmInHoaDon(id);
                inHoaDon.ShowDialog();
                hoaDon!.TrangThaiThanhToan = 1;
                ban!.TrangThai = 0;
                context.HoaDon.Update(hoaDon);
                context.Ban.Update(ban);
                context.SaveChanges();
                this.Close();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn phương thức thanh toán");
            }
        }

        private void txtTienKhachDua_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnXacNhan_Click(sender, e);
            }
        }
    }
}
