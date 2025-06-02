namespace QuanLyQuanCaPhe.Forms
{
    partial class frmTaiKhoan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTaiKhoan));
            lblTenDayDu = new Label();
            lblID = new Label();
            panel1 = new Panel();
            btnKhoiPhucMatKhau = new Button();
            btnThoat = new Button();
            cboQuyenTruyCap = new ComboBox();
            btnHuyBo = new Button();
            dtpNgaySinh = new DateTimePicker();
            btnLuu = new Button();
            txtID = new TextBox();
            btnXoa = new Button();
            txtTenDayDu = new TextBox();
            btnSua = new Button();
            btnThem = new Button();
            txtTenDangNhap = new TextBox();
            groupBox1 = new GroupBox();
            picHinhAnh = new PictureBox();
            toolStrip1 = new ToolStrip();
            txtTuKhoa = new ToolStripTextBox();
            btnTimKiem = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnNhap = new ToolStripButton();
            btnXuat = new ToolStripButton();
            label2 = new Label();
            lblTenDangNhap = new Label();
            label1 = new Label();
            dataGridView = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            TenDangNhap = new DataGridViewTextBoxColumn();
            TenDayDu = new DataGridViewTextBoxColumn();
            NgaySinh = new DataGridViewTextBoxColumn();
            HinhAnh = new DataGridViewImageColumn();
            QuyenTruyCap = new DataGridViewTextBoxColumn();
            helpProvider1 = new HelpProvider();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picHinhAnh).BeginInit();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // lblTenDayDu
            // 
            lblTenDayDu.AutoSize = true;
            lblTenDayDu.Font = new Font("Segoe UI", 9.75F);
            lblTenDayDu.Location = new Point(19, 203);
            lblTenDayDu.Name = "lblTenDayDu";
            lblTenDayDu.Size = new Size(75, 17);
            lblTenDayDu.TabIndex = 6;
            lblTenDayDu.Text = "Tên đầy đủ:";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Segoe UI", 9.75F);
            lblID.Location = new Point(140, 62);
            lblID.Name = "lblID";
            lblID.Size = new Size(23, 17);
            lblID.TabIndex = 2;
            lblID.Text = "ID:";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnKhoiPhucMatKhau);
            panel1.Controls.Add(btnThoat);
            panel1.Controls.Add(cboQuyenTruyCap);
            panel1.Controls.Add(btnHuyBo);
            panel1.Controls.Add(dtpNgaySinh);
            panel1.Controls.Add(btnLuu);
            panel1.Controls.Add(txtID);
            panel1.Controls.Add(btnXoa);
            panel1.Controls.Add(txtTenDayDu);
            panel1.Controls.Add(btnSua);
            panel1.Controls.Add(btnThem);
            panel1.Controls.Add(txtTenDangNhap);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(toolStrip1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lblTenDangNhap);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblTenDayDu);
            panel1.Controls.Add(lblID);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(725, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(337, 567);
            panel1.TabIndex = 2;
            // 
            // btnKhoiPhucMatKhau
            // 
            btnKhoiPhucMatKhau.BackColor = Color.MediumPurple;
            btnKhoiPhucMatKhau.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKhoiPhucMatKhau.Location = new Point(20, 521);
            btnKhoiPhucMatKhau.Name = "btnKhoiPhucMatKhau";
            btnKhoiPhucMatKhau.Size = new Size(288, 46);
            btnKhoiPhucMatKhau.TabIndex = 18;
            btnKhoiPhucMatKhau.Text = "Khôi phục mật khẩu";
            btnKhoiPhucMatKhau.UseVisualStyleBackColor = false;
            btnKhoiPhucMatKhau.Click += btnKhoiPhucMatKhau_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.FromArgb(255, 200, 155);
            btnThoat.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThoat.Location = new Point(179, 464);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(129, 46);
            btnThoat.TabIndex = 17;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // cboQuyenTruyCap
            // 
            cboQuyenTruyCap.Font = new Font("Segoe UI", 9.75F);
            cboQuyenTruyCap.FormattingEnabled = true;
            cboQuyenTruyCap.Items.AddRange(new object[] { "user", "admin" });
            cboQuyenTruyCap.Location = new Point(131, 273);
            cboQuyenTruyCap.Name = "cboQuyenTruyCap";
            cboQuyenTruyCap.Size = new Size(177, 25);
            cboQuyenTruyCap.TabIndex = 11;
            // 
            // btnHuyBo
            // 
            btnHuyBo.BackColor = Color.LightGray;
            btnHuyBo.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHuyBo.Location = new Point(20, 464);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(129, 46);
            btnHuyBo.TabIndex = 16;
            btnHuyBo.Text = "Hủy";
            btnHuyBo.UseVisualStyleBackColor = false;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            dtpNgaySinh.Font = new Font("Segoe UI", 9.75F);
            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpNgaySinh.Location = new Point(131, 236);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(177, 25);
            dtpNgaySinh.TabIndex = 9;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.FromArgb(147, 197, 253);
            btnLuu.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLuu.Location = new Point(179, 400);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(129, 46);
            btnLuu.TabIndex = 15;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Font = new Font("Segoe UI", 9.75F);
            txtID.Location = new Point(140, 82);
            txtID.Name = "txtID";
            txtID.Size = new Size(100, 25);
            txtID.TabIndex = 3;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.LightPink;
            btnXoa.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoa.Location = new Point(20, 400);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(129, 46);
            btnXoa.TabIndex = 14;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // txtTenDayDu
            // 
            txtTenDayDu.Font = new Font("Segoe UI", 9.75F);
            txtTenDayDu.Location = new Point(131, 199);
            txtTenDayDu.Name = "txtTenDayDu";
            txtTenDayDu.Size = new Size(177, 25);
            txtTenDayDu.TabIndex = 7;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.LightBlue;
            btnSua.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSua.Location = new Point(179, 336);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(129, 46);
            btnSua.TabIndex = 13;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.LightGreen;
            btnThem.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThem.Location = new Point(20, 336);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(129, 46);
            btnThem.TabIndex = 12;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Font = new Font("Segoe UI", 9.75F);
            txtTenDangNhap.Location = new Point(131, 163);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(177, 25);
            txtTenDangNhap.TabIndex = 5;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(picHinhAnh);
            groupBox1.Location = new Point(13, 28);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(121, 127);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Hình ảnh";
            // 
            // picHinhAnh
            // 
            picHinhAnh.Dock = DockStyle.Fill;
            picHinhAnh.Location = new Point(3, 19);
            picHinhAnh.Margin = new Padding(2);
            picHinhAnh.Name = "picHinhAnh";
            picHinhAnh.Size = new Size(115, 105);
            picHinhAnh.SizeMode = PictureBoxSizeMode.StretchImage;
            picHinhAnh.TabIndex = 12;
            picHinhAnh.TabStop = false;
            picHinhAnh.Click += picHinhAnh_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { txtTuKhoa, btnTimKiem, toolStripSeparator1, btnNhap, btnXuat });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(337, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // txtTuKhoa
            // 
            txtTuKhoa.Name = "txtTuKhoa";
            txtTuKhoa.Size = new Size(100, 25);
            // 
            // btnTimKiem
            // 
            btnTimKiem.Image = (Image)resources.GetObject("btnTimKiem.Image");
            btnTimKiem.ImageTransparentColor = Color.Magenta;
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(47, 22);
            btnTimKiem.Text = "Tìm";
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // btnNhap
            // 
            btnNhap.Image = (Image)resources.GetObject("btnNhap.Image");
            btnNhap.ImageTransparentColor = Color.Magenta;
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(65, 22);
            btnNhap.Text = "Nhập...";
            btnNhap.Click += btnNhap_Click;
            // 
            // btnXuat
            // 
            btnXuat.Image = (Image)resources.GetObject("btnXuat.Image");
            btnXuat.ImageTransparentColor = Color.Magenta;
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(60, 22);
            btnXuat.Text = "Xuất...";
            btnXuat.Click += btnXuat_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F);
            label2.Location = new Point(20, 277);
            label2.Name = "label2";
            label2.Size = new Size(99, 17);
            label2.TabIndex = 10;
            label2.Text = "Quyền truy cập:";
            // 
            // lblTenDangNhap
            // 
            lblTenDangNhap.AutoSize = true;
            lblTenDangNhap.Font = new Font("Segoe UI", 9.75F);
            lblTenDangNhap.Location = new Point(19, 167);
            lblTenDangNhap.Name = "lblTenDangNhap";
            lblTenDangNhap.Size = new Size(98, 17);
            lblTenDangNhap.TabIndex = 4;
            lblTenDangNhap.Text = "Tên đăng nhập:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F);
            label1.Location = new Point(19, 240);
            label1.Name = "label1";
            label1.Size = new Size(69, 17);
            label1.TabIndex = 8;
            label1.Text = "Ngày sinh:";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AllowUserToResizeColumns = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { ID, TenDangNhap, TenDayDu, NgaySinh, HinhAnh, QuyenTruyCap });
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(0, 0);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.Size = new Size(725, 567);
            dataGridView.TabIndex = 0;
            dataGridView.CellFormatting += dataGridView_CellFormatting;
            dataGridView.DataError += dataGridView_DataError;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.FillWeight = 50F;
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // TenDangNhap
            // 
            TenDangNhap.DataPropertyName = "TenDangNhap";
            TenDangNhap.FillWeight = 89.54315F;
            TenDangNhap.HeaderText = "Tên đăng nhập";
            TenDangNhap.Name = "TenDangNhap";
            TenDangNhap.ReadOnly = true;
            // 
            // TenDayDu
            // 
            TenDayDu.DataPropertyName = "TenDayDu";
            TenDayDu.FillWeight = 89.54315F;
            TenDayDu.HeaderText = "Tên đầy đủ";
            TenDayDu.Name = "TenDayDu";
            TenDayDu.ReadOnly = true;
            // 
            // NgaySinh
            // 
            NgaySinh.DataPropertyName = "NgaySinh";
            NgaySinh.FillWeight = 89.54315F;
            NgaySinh.HeaderText = "Ngày sinh";
            NgaySinh.Name = "NgaySinh";
            NgaySinh.ReadOnly = true;
            // 
            // HinhAnh
            // 
            HinhAnh.DataPropertyName = "HinhAnh";
            HinhAnh.FillWeight = 89.54315F;
            HinhAnh.HeaderText = "Hình ảnh";
            HinhAnh.Name = "HinhAnh";
            HinhAnh.ReadOnly = true;
            HinhAnh.Resizable = DataGridViewTriState.True;
            HinhAnh.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // QuyenTruyCap
            // 
            QuyenTruyCap.DataPropertyName = "QuyenTruyCap";
            QuyenTruyCap.FillWeight = 89.54315F;
            QuyenTruyCap.HeaderText = "Quyền truy cập";
            QuyenTruyCap.Name = "QuyenTruyCap";
            QuyenTruyCap.ReadOnly = true;
            // 
            // frmTaiKhoan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1062, 567);
            Controls.Add(dataGridView);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmTaiKhoan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý tài khoản";
            Load += frmTaiKhoan_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picHinhAnh).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label lblTenDayDu;
        private Label lblID;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label lblTenDangNhap;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn TenDangNhap;
        private DataGridViewTextBoxColumn TenDayDu;
        private DataGridViewTextBoxColumn NgaySinh;
        private DataGridViewImageColumn HinhAnh;
        private DataGridViewTextBoxColumn QuyenTruyCap;
        private ToolStrip toolStrip1;
        private ToolStripTextBox txtTuKhoa;
        private ToolStripButton btnTimKiem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnNhap;
        private ToolStripButton btnXuat;
        private GroupBox groupBox1;
        private PictureBox picHinhAnh;
        private DateTimePicker dtpNgaySinh;
        private TextBox txtID;
        private TextBox txtTenDayDu;
        private TextBox txtTenDangNhap;
        private ComboBox cboQuyenTruyCap;
        private Button btnThoat;
        private Button btnHuyBo;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private HelpProvider helpProvider1;
        private Button btnKhoiPhucMatKhau;
    }
}