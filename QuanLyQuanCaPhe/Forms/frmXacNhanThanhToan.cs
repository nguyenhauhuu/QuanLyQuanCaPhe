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
        }

        private void frmXacNhanThanhToan_Load(object sender, EventArgs e)
        {
            var hoaDon = context.HoaDon.Find(id);
            txtID.Text = hoaDon!.ID.ToString();
            tongCong = hoaDon.TongCong;
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
            decimal tienThua = tongCong - Convert.ToDecimal(txtTienKhachDua.Text);
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
            if (cboHinhThucThanhToan.Text !="Tiền mặt")
            {
                frmInHoaDon inHoaDon = new frmInHoaDon(id);
                inHoaDon.ShowDialog();
                hoaDon!.TrangThaiThanhToan = 2;
                ban!.TrangThai = "Trống";
                context.HoaDon.Update(hoaDon);
                context.Ban.Update(ban);
                context.SaveChanges();
            }
            else if (cboHinhThucThanhToan.Text == "Tiền mặt")
            {
                hoaDon!.TrangThaiThanhToan = 1;
                ban!.TrangThai = "Trống";
                context.HoaDon.Update(hoaDon);
                context.Ban.Update(ban);
                context.SaveChanges();
            }

            this.Close();
        }
    }
}
