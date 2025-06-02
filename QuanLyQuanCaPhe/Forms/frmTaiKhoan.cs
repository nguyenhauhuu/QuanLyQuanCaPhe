using ClosedXML.Excel;
using QuanLyQuanCaPhe.Data;
using SlugGenerator;
using System.Configuration;
using System.Data;
using BC = BCrypt.Net.BCrypt;


namespace QuanLyQuanCaPhe.Forms
{
    public partial class frmTaiKhoan : Form
    {
        QLQCPContext context = new QLQCPContext(); // Khởi tạo biến ngữ cảnh CSDL 
        int id;
        string imageName = "no-image.jpg"; // Hình ảnh mặc định
        string imageFolder = Application.StartupPath.Replace("bin\\Debug\\net8.0-windows", "Images");
        public frmTaiKhoan()
        {
            InitializeComponent();
            helpProvider1.SetHelpString(this, "https://chanhdang.com/helper#QLTK");
            this.HelpRequested += (s, e) =>
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(helpProvider1.GetHelpString(this)!) { UseShellExecute = true });
                e.Handled = true;
            };
        }

        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;
            txtTenDangNhap.Enabled = giaTri;
            txtTenDayDu.Enabled = giaTri;
            dtpNgaySinh.Enabled = giaTri;
            cboQuyenTruyCap.Enabled = giaTri;
            picHinhAnh.Enabled = giaTri;
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

            picHinhAnh.DataBindings.Clear();
            Binding hinhAnh = new Binding("ImageLocation", taiKhoan, "HinhAnh", false, DataSourceUpdateMode.Never);
            hinhAnh.Format += (s, e) =>
            {
                e.Value = Path.Combine(imageFolder, e.Value?.ToString() ?? "");
            };
            picHinhAnh.DataBindings.Add(hinhAnh);

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
            picHinhAnh.Image = null;
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
            TaiKhoan taiKhoan = new TaiKhoan();
            if (string.IsNullOrWhiteSpace(txtTenDangNhap.Text))
                MessageBox.Show("Vui lòng nhập tên đăng nhập?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (string.IsNullOrWhiteSpace(txtTenDayDu.Text))
                MessageBox.Show("Vui lòng nhập tên đầy đủ?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (id == 0)
                {
                    if (context.TaiKhoan.FirstOrDefault(r => r.TenDangNhap == txtTenDangNhap.Text) != null)
                    {
                        MessageBox.Show("Tên tài khoản đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    taiKhoan = new TaiKhoan();
                    taiKhoan.TenDangNhap = txtTenDangNhap.Text;
                    taiKhoan.TenDayDu = txtTenDayDu.Text;
                    taiKhoan.QuyenTruyCap = cboQuyenTruyCap.Text;
                    taiKhoan.NgaySinh = dtpNgaySinh.Value.Date;
                    taiKhoan.HinhAnh = imageName;
                    taiKhoan.MatKhau = BC.HashPassword(ConfigurationManager.AppSettings["MatKhauMacDinh"]);
                    context.TaiKhoan.Add(taiKhoan);
                    context.SaveChanges();
                }
                else
                {
                    taiKhoan = context.TaiKhoan.Find(id)!;
                    if (taiKhoan != null)
                    {
                        taiKhoan.TenDangNhap = txtTenDangNhap.Text;
                        taiKhoan.TenDayDu = txtTenDayDu.Text;
                        taiKhoan.QuyenTruyCap = cboQuyenTruyCap.Text;
                        taiKhoan.NgaySinh = dtpNgaySinh.Value;
                        taiKhoan.HinhAnh = imageName;
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
                        // Xóa hình ảnh (nếu có)
                        if (!string.IsNullOrEmpty(taiKhoan.HinhAnh))
                        {
                            string imagePath = Path.Combine(imageFolder, taiKhoan.HinhAnh);
                            if (File.Exists(imagePath))
                            {
                                System.GC.Collect();
                                System.GC.WaitForPendingFinalizers();
                                File.Delete(imagePath);
                            }
                        }
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
                                TaiKhoan taiKhoan = new TaiKhoan();
                                taiKhoan.TenDangNhap = r["TenDangNhap"].ToString() ?? "N/A";
                                taiKhoan.TenDayDu = r["TenDayDu"].ToString() ?? "N/A";
                                taiKhoan.QuyenTruyCap = r["QuyenTruyCap"].ToString() ?? "N/A";
                                taiKhoan.NgaySinh = Convert.ToDateTime(r["NgaySinh"].ToString());
                                taiKhoan.HinhAnh = r["HinhAnh"].ToString() ?? "N/A";
                                context.TaiKhoan.Add(taiKhoan);
                            }
                            context.SaveChanges();

                            MessageBox.Show("Đã nhập thành công " + table.Rows.Count + " dòng.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            frmTaiKhoan_Load(sender, e);
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
            saveFileDialog.FileName = "TaiKhoan_" + DateTime.Now.ToShortDateString().Replace("/", "_") + ".xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Đọc dữ liệu từ CSDL và lưu vào một bảng tạm 
                    DataTable table = new DataTable();

                    table.Columns.AddRange(new DataColumn[] {
                        new DataColumn("ID", typeof(int)),
                        new DataColumn("TenDangNhap", typeof(string)),
                        new DataColumn("TenDayDu", typeof(string)),
                        new DataColumn("NgaySinh", typeof(DateTime)),
                        new DataColumn("QuyenTruyCap", typeof(string)),
                        new DataColumn("HinhAnh", typeof(string)),
                       });

                    var taiKhoan = context.TaiKhoan.ToList();
                    if (taiKhoan != null)
                    {
                        foreach (var p in taiKhoan)
                            table.Rows.Add(p.ID, p.TenDangNhap, p.TenDayDu, p.NgaySinh, p.QuyenTruyCap, p.HinhAnh);
                    }

                    // Gán bảng tạm vào Sheet 1 của tập tin Excel 
                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        var sheet = wb.Worksheets.Add(table, "TaiKhoan");
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

        private void dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView.Columns[e.ColumnIndex].Name == "HinhAnh")
            {
                string imagePath = Path.Combine(imageFolder, e.Value?.ToString() ?? "");
                if (File.Exists(imagePath))
                {
                    Image image = Image.FromFile(imagePath);
                    image = new Bitmap(image, 24, 24);
                    e.Value = image;
                }
            }

        }

        private void dataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
            return;

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

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            var taiKhoan = context.TaiKhoan
            .Where(r => r.TenDayDu.Contains(txtTuKhoa.Text))
            .ToList();
            dataGridView.DataSource = taiKhoan;
        }

        private void btnKhoiPhucMatKhau_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show($"Bạn có chắc chắn muốn khôi phục mật khẩu tài khoản id {id} không?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                var taiKhoan = context.TaiKhoan.Find(id)!;
                if (taiKhoan != null)
                {
                    taiKhoan.MatKhau = BC.HashPassword(ConfigurationManager.AppSettings["MatKhauMacDinh"]);
                    context.TaiKhoan.Update(taiKhoan);
                    context.SaveChanges();
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
