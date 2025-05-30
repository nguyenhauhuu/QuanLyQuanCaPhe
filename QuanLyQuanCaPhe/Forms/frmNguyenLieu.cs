using ClosedXML.Excel;
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
            txtID.Text = "";
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

        private void btnNhap_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Nhập dữ liệu từ tập tin Excel";
            openFileDialog.Filter = "Tập tin Excel|*.xls;*.xlsx";
            openFileDialog.Multiselect = false;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (XLWorkbook workbook = new XLWorkbook(openFileDialog.FileName))
                    {
                        IXLWorksheet worksheet = workbook.Worksheet(1);
                        bool firstRow = true;
                        string readRange = "";
                        DataTable table = new DataTable();

                        // Đọc Sheet 1 và lưu dữ liệu vào một bảng tạm 
                        foreach (IXLRow row in worksheet.RowsUsed())
                        {
                            // Đọc dòng tiêu đề (dòng đầu tiên) 
                            if (firstRow)
                            {
                                readRange = string.Format("{0}:{1}", 1, row.LastCellUsed().Address.ColumnNumber);
                                foreach (IXLCell cell in row.Cells(readRange))
                                    table.Columns.Add(cell.Value.ToString());
                                firstRow = false;
                            }
                            else // Đọc các dòng nội dung (các dòng tiếp theo) 
                            {
                                table.Rows.Add();
                                int cellIndex = 0;
                                foreach (IXLCell cell in row.Cells(readRange))
                                {
                                    table.Rows[table.Rows.Count - 1][cellIndex] = cell.Value.ToString();
                                    cellIndex++;
                                }
                            }
                        }

                        // Đọc dữ liệu từ bảng tạm và lưu vào CSDL 
                        if (table.Rows.Count > 0)
                        {
                            foreach (DataRow r in table.Rows)
                            {
                                NguyenLieu nguyenLieu = new NguyenLieu();
                                nguyenLieu.TenNguyenLieu = r["TenNguyenLieu"].ToString() ?? "N/A";
                                context.NguyenLieu.Add(nguyenLieu);
                            }
                            context.SaveChanges();

                            MessageBox.Show("Đã nhập thành công " + table.Rows.Count + " dòng.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            frmNguyenLieu_Load(sender, e);
                        }
                        else
                            MessageBox.Show("Tập tin Excel rỗng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Xuất dữ liệu ra tập tin Excel";
            saveFileDialog.Filter = "Tập tin Excel|*.xls;*.xlsx";
            saveFileDialog.FileName = "NguyenLieu_" + DateTime.Now.ToShortDateString().Replace("/", "_") + ".xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Đọc dữ liệu từ CSDL và lưu vào một bảng tạm 
                    DataTable table = new DataTable();

                    table.Columns.AddRange(new DataColumn[] {
                        new DataColumn("ID", typeof(int)),
                        new DataColumn("TenNguyenLieu", typeof(string))

                       });

                    var nguyenLieu = context.NguyenLieu.ToList();
                    if (nguyenLieu != null)
                    {
                        foreach (var p in nguyenLieu)
                            table.Rows.Add(p.ID, p.TenNguyenLieu);
                    }

                    // Gán bảng tạm vào Sheet 1 của tập tin Excel 
                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        var sheet = wb.Worksheets.Add(table, "NguyenLieu");
                        sheet.Columns().AdjustToContents();
                        wb.SaveAs(saveFileDialog.FileName);

                        MessageBox.Show("Đã xuất dữ liệu ra tập tin Excel thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            var nguyenLieu = context.NguyenLieu
            .Where(r => r.TenNguyenLieu.Contains(txtTuKhoa.Text))
            .ToList();
            dataGridView.DataSource = nguyenLieu;
        }
    }
}
