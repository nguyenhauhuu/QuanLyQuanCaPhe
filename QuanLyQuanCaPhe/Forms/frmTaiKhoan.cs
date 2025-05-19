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
using BC = BCrypt.Net.BCrypt;


namespace QuanLyQuanCaPhe.Forms
{
    public partial class frmTaiKhoan : Form
    {
        QLQCPContext context = new QLQCPContext(); // Khởi tạo biến ngữ cảnh CSDL 
        int id;
        public frmTaiKhoan()
        {
            InitializeComponent();
        }

        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;
            txtTenDangNhap.Enabled = giaTri;
            txtTenDayDu.Enabled = giaTri;
            dtpNgaySinh.Enabled = giaTri;
            cboQuyenTruyCap.Enabled = giaTri;

            txtTenDangNhap.Enabled = giaTri;


            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
        }

        private void frmTaiKhoan_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            dataGridView.AutoGenerateColumns = false;

            var taiKhoan = context.TaiKhoan.ToList();
            dataGridView.DataSource = taiKhoan;

            txtTenDangNhap.DataBindings.Clear();
            txtTenDangNhap.DataBindings.Add("Text", taiKhoan, "TenDangNhap", false, DataSourceUpdateMode.Never);

            txtID.DataBindings.Clear();
            txtID.DataBindings.Add("Text", taiKhoan, "ID", false, DataSourceUpdateMode.Never);

            txtTenDayDu.DataBindings.Clear();
            txtTenDayDu.DataBindings.Add("Text", taiKhoan, "TenDayDu", false, DataSourceUpdateMode.Never);

            dtpNgaySinh.DataBindings.Clear();
            dtpNgaySinh.DataBindings.Add("Value", taiKhoan, "NgaySinh", false, DataSourceUpdateMode.Never);

            cboQuyenTruyCap.DataBindings.Clear();
            cboQuyenTruyCap.DataBindings.Add("Text", taiKhoan, "QuyenTruyCap", false, DataSourceUpdateMode.Never);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            id = 0;
            BatTatChucNang(true);
            txtTenDangNhap.Text = "";
            txtTenDayDu.Text = "";
            txtID.Text = "";
            dtpNgaySinh.Value = DateTime.Now;
            cboQuyenTruyCap.Text = "";
            txtTenDangNhap.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow != null)
            {
                BatTatChucNang(true);
                id = Convert.ToInt32(dataGridView.CurrentRow?.Cells[0].Value?.ToString());
                txtTenDangNhap.Focus();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để cập nhật.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenDangNhap.Text))
                MessageBox.Show("Vui lòng nhập tên loại sản phẩm?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (id == 0)
                {
                    TaiKhoan taiKhoan = new TaiKhoan();
                    taiKhoan.TenDangNhap = txtTenDangNhap.Text;
                    taiKhoan.TenDayDu=txtTenDayDu.Text;
                    taiKhoan.QuyenTruyCap=cboQuyenTruyCap.Text;
                    taiKhoan.NgaySinh = dtpNgaySinh.Value.Date;
                    taiKhoan.MatKhau = BC.HashPassword("123");
                    context.TaiKhoan.Add(taiKhoan);
                    context.SaveChanges();
                }
                else
                {
                    TaiKhoan taiKhoan = context.TaiKhoan.Find(id)!;
                    if (taiKhoan != null)
                    {
                        taiKhoan.TenDangNhap = txtTenDangNhap.Text;
                        taiKhoan.TenDayDu = txtTenDayDu.Text;
                        taiKhoan.QuyenTruyCap = cboQuyenTruyCap.Text;
                        taiKhoan.NgaySinh = dtpNgaySinh.Value;
                        context.TaiKhoan.Update(taiKhoan);

                        context.SaveChanges();
                    }
                }

                frmTaiKhoan_Load(sender, e);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow != null)
            {
                if (MessageBox.Show("Xác nhận xóa " + txtTenDangNhap.Text + "?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    id = Convert.ToInt32(dataGridView.CurrentRow?.Cells[0].Value?.ToString());
                    TaiKhoan taiKhoan = context.TaiKhoan.Find(id)!;
                    if (taiKhoan != null)
                    {
                        context.TaiKhoan.Remove(taiKhoan);
                        context.SaveChanges();
                    }
                    frmTaiKhoan_Load(sender, e);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmTaiKhoan_Load(sender, e);
        }
    }
}
