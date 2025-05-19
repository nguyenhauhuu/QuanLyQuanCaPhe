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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            btnThoat = new ReaLTaiizor.Controls.Button();
            btnHuyBo = new ReaLTaiizor.Controls.Button();
            btnLuu = new ReaLTaiizor.Controls.Button();
            btnXoa = new ReaLTaiizor.Controls.Button();
            btnSua = new ReaLTaiizor.Controls.Button();
            btnThem = new ReaLTaiizor.Controls.Button();
            txtTenDayDu = new ReaLTaiizor.Controls.AloneTextBox();
            lblTenDayDu = new Label();
            txtID = new ReaLTaiizor.Controls.AloneTextBox();
            btnXuat = new ToolStripButton();
            btnNhap = new ToolStripButton();
            lblID = new Label();
            btnTimKiem = new ToolStripButton();
            txtTimKiem = new ToolStripTextBox();
            toolStrip1 = new ToolStrip();
            toolStripSeparator1 = new ToolStripSeparator();
            panel1 = new Panel();
            cboQuyenTruyCap = new ReaLTaiizor.Controls.AloneComboBox();
            dtpNgaySinh = new ReaLTaiizor.Controls.PoisonDateTime();
            btnKhoiPhucMatKhau = new ReaLTaiizor.Controls.Button();
            txtTenDangNhap = new ReaLTaiizor.Controls.AloneTextBox();
            label2 = new Label();
            lblTenDangNhap = new Label();
            label1 = new Label();
            dataGridView = new ReaLTaiizor.Controls.PoisonDataGridView();
            ID = new DataGridViewTextBoxColumn();
            TenDangNhap = new DataGridViewTextBoxColumn();
            TenDayDu = new DataGridViewTextBoxColumn();
            NgaySinh = new DataGridViewTextBoxColumn();
            QuyenTruyCap = new DataGridViewTextBoxColumn();
            toolStrip1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.Transparent;
            btnThoat.BorderColor = Color.FromArgb(32, 34, 37);
            btnThoat.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            btnThoat.EnteredColor = Color.FromArgb(32, 34, 37);
            btnThoat.Font = new Font("Microsoft Sans Serif", 12F);
            btnThoat.Image = null;
            btnThoat.ImageAlign = ContentAlignment.MiddleLeft;
            btnThoat.InactiveColor = Color.FromArgb(32, 34, 37);
            btnThoat.Location = new Point(184, 336);
            btnThoat.Name = "btnThoat";
            btnThoat.PressedBorderColor = Color.FromArgb(165, 37, 37);
            btnThoat.PressedColor = Color.FromArgb(165, 37, 37);
            btnThoat.Size = new Size(120, 40);
            btnThoat.TabIndex = 3;
            btnThoat.Text = "Thoát";
            btnThoat.TextAlignment = StringAlignment.Center;
            // 
            // btnHuyBo
            // 
            btnHuyBo.BackColor = Color.Transparent;
            btnHuyBo.BorderColor = Color.FromArgb(32, 34, 37);
            btnHuyBo.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            btnHuyBo.EnteredColor = Color.FromArgb(32, 34, 37);
            btnHuyBo.Font = new Font("Microsoft Sans Serif", 12F);
            btnHuyBo.Image = null;
            btnHuyBo.ImageAlign = ContentAlignment.MiddleLeft;
            btnHuyBo.InactiveColor = Color.FromArgb(32, 34, 37);
            btnHuyBo.Location = new Point(28, 336);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.PressedBorderColor = Color.FromArgb(165, 37, 37);
            btnHuyBo.PressedColor = Color.FromArgb(165, 37, 37);
            btnHuyBo.Size = new Size(120, 40);
            btnHuyBo.TabIndex = 3;
            btnHuyBo.Text = "Hủy";
            btnHuyBo.TextAlignment = StringAlignment.Center;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.Transparent;
            btnLuu.BorderColor = Color.FromArgb(32, 34, 37);
            btnLuu.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            btnLuu.EnteredColor = Color.FromArgb(32, 34, 37);
            btnLuu.Font = new Font("Microsoft Sans Serif", 12F);
            btnLuu.Image = null;
            btnLuu.ImageAlign = ContentAlignment.MiddleLeft;
            btnLuu.InactiveColor = Color.FromArgb(32, 34, 37);
            btnLuu.Location = new Point(184, 285);
            btnLuu.Name = "btnLuu";
            btnLuu.PressedBorderColor = Color.FromArgb(165, 37, 37);
            btnLuu.PressedColor = Color.FromArgb(165, 37, 37);
            btnLuu.Size = new Size(120, 40);
            btnLuu.TabIndex = 3;
            btnLuu.Text = "Lưu";
            btnLuu.TextAlignment = StringAlignment.Center;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.Transparent;
            btnXoa.BorderColor = Color.FromArgb(32, 34, 37);
            btnXoa.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            btnXoa.EnteredColor = Color.FromArgb(32, 34, 37);
            btnXoa.Font = new Font("Microsoft Sans Serif", 12F);
            btnXoa.Image = null;
            btnXoa.ImageAlign = ContentAlignment.MiddleLeft;
            btnXoa.InactiveColor = Color.FromArgb(32, 34, 37);
            btnXoa.Location = new Point(28, 285);
            btnXoa.Name = "btnXoa";
            btnXoa.PressedBorderColor = Color.FromArgb(165, 37, 37);
            btnXoa.PressedColor = Color.FromArgb(165, 37, 37);
            btnXoa.Size = new Size(120, 40);
            btnXoa.TabIndex = 3;
            btnXoa.Text = "Xóa";
            btnXoa.TextAlignment = StringAlignment.Center;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.Transparent;
            btnSua.BorderColor = Color.FromArgb(32, 34, 37);
            btnSua.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            btnSua.EnteredColor = Color.FromArgb(32, 34, 37);
            btnSua.Font = new Font("Microsoft Sans Serif", 12F);
            btnSua.Image = null;
            btnSua.ImageAlign = ContentAlignment.MiddleLeft;
            btnSua.InactiveColor = Color.FromArgb(32, 34, 37);
            btnSua.Location = new Point(184, 234);
            btnSua.Name = "btnSua";
            btnSua.PressedBorderColor = Color.FromArgb(165, 37, 37);
            btnSua.PressedColor = Color.FromArgb(165, 37, 37);
            btnSua.Size = new Size(120, 40);
            btnSua.TabIndex = 3;
            btnSua.Text = "Sửa";
            btnSua.TextAlignment = StringAlignment.Center;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.Transparent;
            btnThem.BorderColor = Color.FromArgb(32, 34, 37);
            btnThem.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            btnThem.EnteredColor = Color.FromArgb(32, 34, 37);
            btnThem.Font = new Font("Microsoft Sans Serif", 12F);
            btnThem.Image = null;
            btnThem.ImageAlign = ContentAlignment.MiddleLeft;
            btnThem.InactiveColor = Color.FromArgb(32, 34, 37);
            btnThem.Location = new Point(28, 234);
            btnThem.Name = "btnThem";
            btnThem.PressedBorderColor = Color.FromArgb(165, 37, 37);
            btnThem.PressedColor = Color.FromArgb(165, 37, 37);
            btnThem.Size = new Size(120, 40);
            btnThem.TabIndex = 3;
            btnThem.Text = "Thêm";
            btnThem.TextAlignment = StringAlignment.Center;
            btnThem.Click += btnThem_Click;
            // 
            // txtTenDayDu
            // 
            txtTenDayDu.BackColor = Color.Transparent;
            txtTenDayDu.EnabledCalc = true;
            txtTenDayDu.Font = new Font("Segoe UI", 9.75F);
            txtTenDayDu.ForeColor = Color.FromArgb(124, 133, 142);
            txtTenDayDu.Location = new Point(124, 116);
            txtTenDayDu.MaxLength = 32767;
            txtTenDayDu.MultiLine = false;
            txtTenDayDu.Name = "txtTenDayDu";
            txtTenDayDu.ReadOnly = false;
            txtTenDayDu.Size = new Size(191, 29);
            txtTenDayDu.TabIndex = 2;
            txtTenDayDu.TextAlign = HorizontalAlignment.Left;
            txtTenDayDu.UseSystemPasswordChar = false;
            // 
            // lblTenDayDu
            // 
            lblTenDayDu.AutoSize = true;
            lblTenDayDu.Font = new Font("Segoe UI", 9.75F);
            lblTenDayDu.Location = new Point(19, 123);
            lblTenDayDu.Name = "lblTenDayDu";
            lblTenDayDu.Size = new Size(75, 17);
            lblTenDayDu.TabIndex = 1;
            lblTenDayDu.Text = "Tên đầy đủ:";
            // 
            // txtID
            // 
            txtID.BackColor = Color.Transparent;
            txtID.Enabled = false;
            txtID.EnabledCalc = false;
            txtID.Font = new Font("Segoe UI", 9.75F);
            txtID.ForeColor = Color.FromArgb(124, 133, 142);
            txtID.Location = new Point(124, 45);
            txtID.MaxLength = 32767;
            txtID.MultiLine = false;
            txtID.Name = "txtID";
            txtID.ReadOnly = false;
            txtID.Size = new Size(191, 29);
            txtID.TabIndex = 2;
            txtID.TextAlign = HorizontalAlignment.Left;
            txtID.UseSystemPasswordChar = false;
            // 
            // btnXuat
            // 
            btnXuat.Image = (Image)resources.GetObject("btnXuat.Image");
            btnXuat.ImageTransparentColor = Color.Magenta;
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(60, 22);
            btnXuat.Text = "Xuất...";
            // 
            // btnNhap
            // 
            btnNhap.Image = (Image)resources.GetObject("btnNhap.Image");
            btnNhap.ImageTransparentColor = Color.Magenta;
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(65, 22);
            btnNhap.Text = "Nhập...";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Segoe UI", 9.75F);
            lblID.Location = new Point(19, 51);
            lblID.Name = "lblID";
            lblID.Size = new Size(23, 17);
            lblID.TabIndex = 1;
            lblID.Text = "ID:";
            // 
            // btnTimKiem
            // 
            btnTimKiem.Image = (Image)resources.GetObject("btnTimKiem.Image");
            btnTimKiem.ImageTransparentColor = Color.Magenta;
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(47, 22);
            btnTimKiem.Text = "Tìm";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(100, 25);
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { txtTimKiem, btnTimKiem, toolStripSeparator1, btnNhap, btnXuat });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(337, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // panel1
            // 
            panel1.Controls.Add(cboQuyenTruyCap);
            panel1.Controls.Add(dtpNgaySinh);
            panel1.Controls.Add(btnKhoiPhucMatKhau);
            panel1.Controls.Add(btnThoat);
            panel1.Controls.Add(btnHuyBo);
            panel1.Controls.Add(btnLuu);
            panel1.Controls.Add(btnXoa);
            panel1.Controls.Add(btnSua);
            panel1.Controls.Add(btnThem);
            panel1.Controls.Add(txtTenDangNhap);
            panel1.Controls.Add(txtTenDayDu);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lblTenDangNhap);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblTenDayDu);
            panel1.Controls.Add(txtID);
            panel1.Controls.Add(lblID);
            panel1.Controls.Add(toolStrip1);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(586, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(337, 450);
            panel1.TabIndex = 2;
            // 
            // cboQuyenTruyCap
            // 
            cboQuyenTruyCap.DrawMode = DrawMode.OwnerDrawFixed;
            cboQuyenTruyCap.DropDownStyle = ComboBoxStyle.DropDownList;
            cboQuyenTruyCap.EnabledCalc = true;
            cboQuyenTruyCap.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboQuyenTruyCap.FormattingEnabled = true;
            cboQuyenTruyCap.ItemHeight = 20;
            cboQuyenTruyCap.Items.AddRange(new object[] { "user", "admin" });
            cboQuyenTruyCap.Location = new Point(124, 190);
            cboQuyenTruyCap.Name = "cboQuyenTruyCap";
            cboQuyenTruyCap.Size = new Size(191, 26);
            cboQuyenTruyCap.TabIndex = 8;
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            dtpNgaySinh.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            dtpNgaySinh.FontSize = ReaLTaiizor.Extension.Poison.PoisonDateTimeSize.Medium;
            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpNgaySinh.Location = new Point(124, 151);
            dtpNgaySinh.MinimumSize = new Size(0, 29);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(191, 29);
            dtpNgaySinh.TabIndex = 7;
            // 
            // btnKhoiPhucMatKhau
            // 
            btnKhoiPhucMatKhau.BackColor = Color.Transparent;
            btnKhoiPhucMatKhau.BorderColor = Color.FromArgb(32, 34, 37);
            btnKhoiPhucMatKhau.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            btnKhoiPhucMatKhau.EnteredColor = Color.FromArgb(32, 34, 37);
            btnKhoiPhucMatKhau.Font = new Font("Microsoft Sans Serif", 12F);
            btnKhoiPhucMatKhau.Image = null;
            btnKhoiPhucMatKhau.ImageAlign = ContentAlignment.MiddleLeft;
            btnKhoiPhucMatKhau.InactiveColor = Color.FromArgb(32, 34, 37);
            btnKhoiPhucMatKhau.Location = new Point(28, 398);
            btnKhoiPhucMatKhau.Name = "btnKhoiPhucMatKhau";
            btnKhoiPhucMatKhau.PressedBorderColor = Color.FromArgb(165, 37, 37);
            btnKhoiPhucMatKhau.PressedColor = Color.FromArgb(165, 37, 37);
            btnKhoiPhucMatKhau.Size = new Size(276, 40);
            btnKhoiPhucMatKhau.TabIndex = 4;
            btnKhoiPhucMatKhau.Text = "Khôi phục mật khẩu";
            btnKhoiPhucMatKhau.TextAlignment = StringAlignment.Center;
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.BackColor = Color.Transparent;
            txtTenDangNhap.EnabledCalc = true;
            txtTenDangNhap.Font = new Font("Segoe UI", 9.75F);
            txtTenDangNhap.ForeColor = Color.FromArgb(124, 133, 142);
            txtTenDangNhap.Location = new Point(124, 80);
            txtTenDangNhap.MaxLength = 32767;
            txtTenDangNhap.MultiLine = false;
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.ReadOnly = false;
            txtTenDangNhap.Size = new Size(191, 29);
            txtTenDangNhap.TabIndex = 2;
            txtTenDangNhap.TextAlign = HorizontalAlignment.Left;
            txtTenDangNhap.UseSystemPasswordChar = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F);
            label2.Location = new Point(19, 195);
            label2.Name = "label2";
            label2.Size = new Size(99, 17);
            label2.TabIndex = 1;
            label2.Text = "Quyền truy cập:";
            // 
            // lblTenDangNhap
            // 
            lblTenDangNhap.AutoSize = true;
            lblTenDangNhap.Font = new Font("Segoe UI", 9.75F);
            lblTenDangNhap.Location = new Point(19, 87);
            lblTenDangNhap.Name = "lblTenDangNhap";
            lblTenDangNhap.Size = new Size(98, 17);
            lblTenDangNhap.TabIndex = 1;
            lblTenDangNhap.Text = "Tên đăng nhập:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F);
            label1.Location = new Point(19, 159);
            label1.Name = "label1";
            label1.Size = new Size(69, 17);
            label1.TabIndex = 1;
            label1.Text = "Ngày sinh:";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AllowUserToResizeRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.BackgroundColor = Color.FromArgb(255, 255, 255);
            dataGridView.BorderStyle = BorderStyle.None;
            dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { ID, TenDangNhap, TenDayDu, NgaySinh, QuyenTruyCap });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridView.GridColor = Color.FromArgb(255, 255, 255);
            dataGridView.Location = new Point(0, 0);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(586, 450);
            dataGridView.TabIndex = 3;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // TenDangNhap
            // 
            TenDangNhap.DataPropertyName = "TenDangNhap";
            TenDangNhap.HeaderText = "Tên đăng nhập";
            TenDangNhap.Name = "TenDangNhap";
            TenDangNhap.ReadOnly = true;
            // 
            // TenDayDu
            // 
            TenDayDu.DataPropertyName = "TenDayDu";
            TenDayDu.HeaderText = "Tên đầy đủ";
            TenDayDu.Name = "TenDayDu";
            TenDayDu.ReadOnly = true;
            // 
            // NgaySinh
            // 
            NgaySinh.DataPropertyName = "NgaySinh";
            NgaySinh.HeaderText = "Ngày Sinh";
            NgaySinh.Name = "NgaySinh";
            NgaySinh.ReadOnly = true;
            // 
            // QuyenTruyCap
            // 
            QuyenTruyCap.DataPropertyName = "QuyenTruyCap";
            QuyenTruyCap.HeaderText = "Quyền truy cập";
            QuyenTruyCap.Name = "QuyenTruyCap";
            QuyenTruyCap.ReadOnly = true;
            // 
            // frmTaiKhoan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(923, 450);
            Controls.Add(dataGridView);
            Controls.Add(panel1);
            Name = "frmTaiKhoan";
            Text = "frmTaiKhoan";
            Load += frmTaiKhoan_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ReaLTaiizor.Controls.Button btnThoat;
        private ReaLTaiizor.Controls.Button btnHuyBo;
        private ReaLTaiizor.Controls.Button btnLuu;
        private ReaLTaiizor.Controls.Button btnXoa;
        private ReaLTaiizor.Controls.Button btnSua;
        private ReaLTaiizor.Controls.Button btnThem;
        private ReaLTaiizor.Controls.AloneTextBox txtTenDayDu;
        private Label lblTenDayDu;
        private ReaLTaiizor.Controls.AloneTextBox txtID;
        private ToolStripButton btnXuat;
        private ToolStripButton btnNhap;
        private Label lblID;
        private ToolStripButton btnTimKiem;
        private ToolStripTextBox txtTimKiem;
        private ToolStrip toolStrip1;
        private ToolStripSeparator toolStripSeparator1;
        private Panel panel1;
        private ReaLTaiizor.Controls.Button btnKhoiPhucMatKhau;
        private ReaLTaiizor.Controls.PoisonDateTime dtpNgaySinh;
        private Label label1;
        private ReaLTaiizor.Controls.AloneComboBox cboQuyenTruyCap;
        private Label label2;
        private ReaLTaiizor.Controls.AloneTextBox txtTenDangNhap;
        private Label lblTenDangNhap;
        private ReaLTaiizor.Controls.PoisonDataGridView dataGridView;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn TenDangNhap;
        private DataGridViewTextBoxColumn TenDayDu;
        private DataGridViewTextBoxColumn NgaySinh;
        private DataGridViewTextBoxColumn QuyenTruyCap;
    }
}