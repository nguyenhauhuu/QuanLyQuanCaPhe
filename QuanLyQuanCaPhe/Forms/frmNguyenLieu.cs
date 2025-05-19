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

namespace QuanLyQuanCaPhe.Forms
{
    public partial class frmNguyenLieu : Form
    {
        QLQCPContext context = new QLQCPContext(); // Khởi tạo biến ngữ cảnh CSDL 
        int id;
        public frmNguyenLieu()
        {
            InitializeComponent();
        }

        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;
            txtTenNguyenLieu.Enabled = giaTri;

            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
        }

        private void frmNguyenLieu_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            dataGridView.AutoGenerateColumns = false;

            var NguyenLieu = context.NguyenLieu.ToList();
            dataGridView.DataSource = NguyenLieu;

            txtTenNguyenLieu.DataBindings.Clear();
            txtTenNguyenLieu.DataBindings.Add("Text", NguyenLieu, "TenNguyenLieu", false, DataSourceUpdateMode.Never);

            txtID.DataBindings.Clear();
            txtID.DataBindings.Add("Text", NguyenLieu, "ID", false, DataSourceUpdateMode.Never);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            id = 0;
            BatTatChucNang(true);
            txtTenNguyenLieu.Text = "";
            txtTenNguyenLieu.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow != null)
            {
                BatTatChucNang(true);
                id = Convert.ToInt32(dataGridView.CurrentRow?.Cells[0].Value?.ToString());
                txtTenNguyenLieu.Focus();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để cập nhật.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenNguyenLieu.Text))
                MessageBox.Show("Vui lòng nhập tên loại sản phẩm?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (id == 0)
                {
                    NguyenLieu nguyenLieu = new NguyenLieu();
                    nguyenLieu.TenNguyenLieu = txtTenNguyenLieu.Text;
                    context.NguyenLieu.Add(nguyenLieu);

                    context.SaveChanges();
                }
                else
                {
                    NguyenLieu nguyenLieu = context.NguyenLieu.Find(id)!;
                    if (nguyenLieu != null)
                    {
                        nguyenLieu.TenNguyenLieu = txtTenNguyenLieu.Text;
                        context.NguyenLieu.Update(nguyenLieu);

                        context.SaveChanges();
                    }
                }

                frmNguyenLieu_Load(sender, e);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow != null)
            {
                if (MessageBox.Show("Xác nhận xóa " + txtTenNguyenLieu.Text + "?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    id = Convert.ToInt32(dataGridView.CurrentRow?.Cells[0].Value?.ToString());
                    NguyenLieu nguyenLieu = context.NguyenLieu.Find(id)!;
                    if (nguyenLieu != null)
                    {
                        context.NguyenLieu.Remove(nguyenLieu);
                        context.SaveChanges();
                    }
                    frmNguyenLieu_Load(sender, e);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmNguyenLieu_Load(sender, e);
        }
    }
}
