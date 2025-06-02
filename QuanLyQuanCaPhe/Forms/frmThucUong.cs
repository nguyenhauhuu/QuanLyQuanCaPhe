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
    public partial class frmThucUong : Form
    {
        QLQCPContext context = new QLQCPContext(); // Khởi tạo biến ngữ cảnh CSDL 
        int id;
        public frmThucUong()
        {
            InitializeComponent();
            helpProvider1.SetHelpString(this, "https://chanhdang.com/helper");
            this.HelpRequested += (s, e) =>
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(helpProvider1.GetHelpString(this)!) { UseShellExecute = true });
                e.Handled = true;
            };
        }

        private void LayDanhMucVaoComboBox()
        {
            var danhMuc = context.DanhMuc.ToList();

            if (danhMuc.Count == 0)
            {
                // Thêm một phần tử mặc định báo "Chưa có danh mục"
                danhMuc.Add(new DanhMuc { ID = 0, TenDanhMuc = "Chưa có danh mục" });
            }

            cboDanhMuc.DataSource = danhMuc;
            cboDanhMuc.ValueMember = "ID";
            cboDanhMuc.DisplayMember = "TenDanhMuc";

            // Nếu muốn chọn phần tử đầu tiên mặc định
            cboDanhMuc.SelectedIndex = 0;

        }

        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;
            txtTenThucUong.Enabled = giaTri;
            cboDanhMuc.Enabled = giaTri;
            numGia.Enabled = giaTri;

            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
        }

        private void frmThucUong_Load(object sender, EventArgs e)
        {
            LayDanhMucVaoComboBox();
            BatTatChucNang(false);
            dataGridView.AutoGenerateColumns = false;

            var thucUong = context.ThucUong.Select(r => new
            {
                r.ID,
                r.TenThucUong,
                r.DanhMucID,
                r.DanhMuc!.TenDanhMuc,
                r.DonGia
            }).ToList();

            dataGridView.DataSource = thucUong;

            txtTenThucUong.DataBindings.Clear();
            txtTenThucUong.DataBindings.Add("Text", thucUong, "TenThucUong", false, DataSourceUpdateMode.Never);

            txtID.DataBindings.Clear();
            txtID.DataBindings.Add("Text", thucUong, "ID", false, DataSourceUpdateMode.Never);

            cboDanhMuc.DataBindings.Clear();
            cboDanhMuc.DataBindings.Add("SelectedValue", thucUong, "DanhMucID", false, DataSourceUpdateMode.Never);

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            id = 0;
            BatTatChucNang(true);
            txtTenThucUong.Text = "";
            txtID.Text = "";
            txtTenThucUong.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow != null)
            {
                BatTatChucNang(true);
                id = Convert.ToInt32(dataGridView.CurrentRow?.Cells[0].Value?.ToString());
                txtTenThucUong.Focus();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để cập nhật.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (cboDanhMuc.Text == "Chưa có danh mục")
            {
                MessageBox.Show("Vui lòng thêm danh mục!!!!");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtTenThucUong.Text))
                MessageBox.Show("Vui lòng nhập tên thức uống?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (id == 0)
                {
                    ThucUong thucUong = new ThucUong();
                    thucUong.TenThucUong = txtTenThucUong.Text;
                    thucUong.DanhMucID = Convert.ToInt32(cboDanhMuc.SelectedValue);
                    thucUong.DonGia = Convert.ToInt32(numGia.Value);
                    context.ThucUong.Add(thucUong);

                    context.SaveChanges();
                }
                else
                {
                    ThucUong thucUong = context.ThucUong.Find(id)!;
                    if (thucUong != null)
                    {
                        thucUong.DanhMucID = Convert.ToInt32(cboDanhMuc.SelectedValue);
                        thucUong.TenThucUong = txtTenThucUong.Text;
                        thucUong.DonGia = Convert.ToInt32(numGia.Value);
                        context.ThucUong.Update(thucUong);

                        context.SaveChanges();
                    }
                }

                frmThucUong_Load(sender, e);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow != null)
            {
                if (MessageBox.Show("Xác nhận xóa " + txtTenThucUong.Text + "?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    id = Convert.ToInt32(dataGridView.CurrentRow?.Cells[0].Value?.ToString());
                    ThucUong thucUong = context.ThucUong.Find(id)!;
                    if (thucUong != null)
                    {
                        context.ThucUong.Remove(thucUong);
                        context.SaveChanges();
                    }
                    frmThucUong_Load(sender, e);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmThucUong_Load(sender, e);
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
                                ThucUong thucUong = new ThucUong();
                                thucUong.DanhMucID = Convert.ToInt32(r["DanhMucId"]);
                                thucUong.TenThucUong = r["TenThucUong"].ToString() ?? "N/A";
                                context.ThucUong.Add(thucUong);
                            }
                            context.SaveChanges();

                            MessageBox.Show("Đã nhập thành công " + table.Rows.Count + " dòng.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            frmThucUong_Load(sender, e);
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
            saveFileDialog.FileName = "ThucUong_" + DateTime.Now.ToShortDateString().Replace("/", "_") + ".xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Đọc dữ liệu từ CSDL và lưu vào một bảng tạm 
                    DataTable table = new DataTable();

                    table.Columns.AddRange(new DataColumn[] {
                        new DataColumn("ID", typeof(int)),
                        new DataColumn("DanhMucID", typeof(int)),
                        new DataColumn("TenThucUong", typeof(string))

                       });

                    var thucUong = context.ThucUong.ToList();
                    if (thucUong != null)
                    {
                        foreach (var p in thucUong)
                            table.Rows.Add(p.ID, p.DanhMucID, p.TenThucUong);
                    }

                    // Gán bảng tạm vào Sheet 1 của tập tin Excel 
                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        var sheet = wb.Worksheets.Add(table, "ThucUong");
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
            var thucUong = context.ThucUong
            .Where(r => r.TenThucUong.Contains(txtTuKhoa.Text))
            .ToList();
            dataGridView.DataSource = thucUong;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
