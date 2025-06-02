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
    public partial class frmKho : Form
    {
        QLQCPContext context = new QLQCPContext(); // Khởi tạo biến ngữ cảnh CSDL 
        int id;
        public frmKho()
        {
            InitializeComponent();
        }
        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;
            cboNguyenLieu.Enabled = giaTri;
            cboDonVi.Enabled = giaTri;
            numGia.Enabled = giaTri;
            numSoLuong.Enabled = giaTri;
            txtMoTa.Enabled = giaTri;
            dtpNgayHetHan.Enabled = giaTri;

            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
        }
        private void LayNguyenLieuVaoComboBox()
        {
            var nguyenLieu = context.NguyenLieu.ToList();

            if (nguyenLieu.Count == 0)
            {
                // Thêm một phần tử mặc định báo "Chưa có nguyên liệu"
                nguyenLieu.Add(new NguyenLieu { ID = 0, TenNguyenLieu = "Chưa có nguyên liệu" });
            }

            cboNguyenLieu.DataSource = nguyenLieu;
            cboNguyenLieu.ValueMember = "ID";
            cboNguyenLieu.DisplayMember = "TenNguyenLieu";

            // Nếu muốn chọn phần tử đầu tiên mặc định
            cboNguyenLieu.SelectedIndex = 0;
        }

        private void frmKho_Load(object sender, EventArgs e)
        {
            LayNguyenLieuVaoComboBox();
            BatTatChucNang(false);
            dataGridView.AutoGenerateColumns = false;

            var kho = context.Kho.Select(r => new
            {
                r.ID,
                r.NguyenLieuID,
                r.NguyenLieu.TenNguyenLieu,
                r.MoTa,
                r.SoLuong,
                r.Gia,
                r.DonVi,
                r.NgayHetHan
            }).ToList();

            dataGridView.DataSource = kho;

            txtMoTa.DataBindings.Clear();
            txtMoTa.DataBindings.Add("Text", kho, "MoTa", false, DataSourceUpdateMode.Never);

            txtID.DataBindings.Clear();
            txtID.DataBindings.Add("Text", kho, "ID", false, DataSourceUpdateMode.Never);

            cboNguyenLieu.DataBindings.Clear();
            cboNguyenLieu.DataBindings.Add("SelectedValue", kho, "NguyenLieuID", false, DataSourceUpdateMode.Never);

            cboDonVi.DataBindings.Clear();
            cboDonVi.DataBindings.Add("SelectedValue", kho, "DonVi", false, DataSourceUpdateMode.Never);

            numSoLuong.DataBindings.Clear();
            numSoLuong.DataBindings.Add("Value", kho, "SoLuong", false, DataSourceUpdateMode.Never);

            numGia.DataBindings.Clear();
            numGia.DataBindings.Add("Value", kho, "Gia", false, DataSourceUpdateMode.Never);

            dtpNgayHetHan.DataBindings.Clear();
            dtpNgayHetHan.DataBindings.Add("Value", kho, "NgayHetHan", false, DataSourceUpdateMode.Never);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            id = 0;
            BatTatChucNang(true);
            txtMoTa.Text = "";
            txtID.Text = "";
            txtMoTa.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow != null)
            {
                BatTatChucNang(true);
                id = Convert.ToInt32(dataGridView.CurrentRow?.Cells[0].Value?.ToString());
                txtMoTa.Focus();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để cập nhật.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (cboNguyenLieu.Text == "Chưa có nguyên liệu")
            {
                MessageBox.Show("Chưa có nguyên liệu, vui lòng thêm nguyên liệu");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtMoTa.Text))
                MessageBox.Show("Vui lòng nhập mô tả?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (id == 0)
                {
                    Kho kho = new Kho();
                    kho.MoTa = txtMoTa.Text;
                    kho.NguyenLieuID = Convert.ToInt32(cboNguyenLieu.SelectedValue);
                    kho.SoLuong = Convert.ToInt32(numSoLuong.Value);
                    kho.Gia = Convert.ToInt32(numGia.Value);
                    kho.DonVi = cboDonVi.Text;
                    kho.NgayHetHan = dtpNgayHetHan.Value;
                    context.Kho.Add(kho);

                    context.SaveChanges();
                }
                else
                {
                    Kho kho = context.Kho.Find(id)!;
                    if (kho != null)
                    {
                        kho.MoTa = txtMoTa.Text;
                        kho.NguyenLieuID = Convert.ToInt32(cboNguyenLieu.SelectedValue);
                        kho.SoLuong = Convert.ToInt32(numSoLuong.Value);
                        kho.Gia = Convert.ToInt32(numGia.Value);
                        kho.DonVi = cboDonVi.Text;
                        kho.NgayHetHan = dtpNgayHetHan.Value;
                        context.Kho.Update(kho);

                        context.SaveChanges();
                    }
                }

                frmKho_Load(sender, e);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow != null)
            {
                if (MessageBox.Show("Xác nhận xóa " + txtMoTa.Text + "?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    id = Convert.ToInt32(dataGridView.CurrentRow?.Cells[0].Value?.ToString());
                    Kho kho = context.Kho.Find(id)!;
                    if (kho != null)
                    {
                        context.Kho.Remove(kho);
                        context.SaveChanges();
                    }
                    frmKho_Load(sender, e);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmKho_Load(sender, e);
        }



        private void dataGridView_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            var row = dataGridView.Rows[e.RowIndex];

            if (row.Cells["NgayHetHan"].Value is DateTime ngayHetHan)
            {
                if (ngayHetHan < DateTime.Now)
                {
                    row.DefaultCellStyle.ForeColor = Color.Red;
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            var kho = context.Kho
            .Where(r => r.MoTa.Contains(txtTuKhoa.Text))
            .ToList();
            dataGridView.DataSource = kho;
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
                                Kho kho = new Kho();
                                kho.NguyenLieuID = Convert.ToInt32(r["NguyenLieuID"]);
                                kho.MoTa = r["MoTa"].ToString() ?? "N/A";
                                kho.SoLuong = Convert.ToInt32(r["SoLuong"]);
                                kho.DonVi = r["DonVi "].ToString() ?? "N/A";
                                kho.Gia = Convert.ToDecimal(r["Gia"]);
                                context.Kho.Add(kho);
                            }
                            context.SaveChanges();

                            MessageBox.Show("Đã nhập thành công " + table.Rows.Count + " dòng.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            frmKho_Load(sender, e);
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
            saveFileDialog.FileName = "Kho_" + DateTime.Now.ToShortDateString().Replace("/", "_") + ".xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Đọc dữ liệu từ CSDL và lưu vào một bảng tạm 
                    DataTable table = new DataTable();

                    table.Columns.AddRange(new DataColumn[] {
                        new DataColumn("ID", typeof(int)),
                        new DataColumn("NguyenLieuID", typeof(int)),
                        new DataColumn("MoTa", typeof(string)),
                        new DataColumn("SoLuong", typeof(int)),
                        new DataColumn("DonVi", typeof(string)),
                        new DataColumn("Gia", typeof(decimal))

                       });

                    var kho = context.Kho.ToList();
                    if (kho != null)
                    {
                        foreach (var p in kho)
                            table.Rows.Add(p.ID, p.NguyenLieuID, p.MoTa, p.SoLuong, p.DonVi, p.Gia);
                    }

                    // Gán bảng tạm vào Sheet 1 của tập tin Excel 
                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        var sheet = wb.Worksheets.Add(table, "Kho");
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

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
