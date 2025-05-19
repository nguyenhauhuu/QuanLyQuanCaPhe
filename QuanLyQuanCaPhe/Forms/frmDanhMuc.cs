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
    public partial class frmDanhMuc : Form
    {
        QLQCPContext context = new QLQCPContext(); // Khởi tạo biến ngữ cảnh CSDL 
        int id;
        public frmDanhMuc()
        {
            InitializeComponent();
        }

        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;
            txtTenDanhMuc.Enabled = giaTri;

            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
        }

        private void frmDanhMuc_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            dataGridView.AutoGenerateColumns = false;

            var DanhMuc = context.DanhMuc.ToList();
            dataGridView.DataSource = DanhMuc;

            txtTenDanhMuc.DataBindings.Clear();
            txtTenDanhMuc.DataBindings.Add("Text", DanhMuc, "TenDanhMuc", false, DataSourceUpdateMode.Never);

            txtID.DataBindings.Clear();
            txtID.DataBindings.Add("Text", DanhMuc, "ID", false, DataSourceUpdateMode.Never);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            id = 0;
            BatTatChucNang(true);
            txtTenDanhMuc.Text = "";
            txtID.Text = "";
            txtTenDanhMuc.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow != null)
            {
                BatTatChucNang(true);
                id = Convert.ToInt32(dataGridView.CurrentRow?.Cells[0].Value?.ToString());
                txtTenDanhMuc.Focus();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để cập nhật.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenDanhMuc.Text))
                MessageBox.Show("Vui lòng nhập tên loại sản phẩm?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (id == 0)
                {
                    DanhMuc danhMuc = new DanhMuc();
                    danhMuc.TenDanhMuc = txtTenDanhMuc.Text;
                    context.DanhMuc.Add(danhMuc);

                    context.SaveChanges();
                }
                else
                {
                    DanhMuc danhMuc = context.DanhMuc.Find(id)!;
                    if (danhMuc != null)
                    {
                        danhMuc.TenDanhMuc = txtTenDanhMuc.Text;
                        context.DanhMuc.Update(danhMuc);

                        context.SaveChanges();
                    }
                }

                frmDanhMuc_Load(sender, e);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow != null)
            {
                if (MessageBox.Show("Xác nhận xóa " + txtTenDanhMuc.Text + "?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    id = Convert.ToInt32(dataGridView.CurrentRow?.Cells[0].Value?.ToString());
                    DanhMuc danhMuc = context.DanhMuc.Find(id)!;
                    if (danhMuc != null)
                    {
                        context.DanhMuc.Remove(danhMuc);
                        context.SaveChanges();
                    }
                    frmDanhMuc_Load(sender, e);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmDanhMuc_Load(sender, e);
        }
    }
}
