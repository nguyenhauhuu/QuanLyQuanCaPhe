namespace QuanLyQuanCaPhe.Forms
{
    partial class frmThucUong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThucUong));
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            btnThoat = new ReaLTaiizor.Controls.Button();
            btnHuyBo = new ReaLTaiizor.Controls.Button();
            btnLuu = new ReaLTaiizor.Controls.Button();
            btnXoa = new ReaLTaiizor.Controls.Button();
            btnSua = new ReaLTaiizor.Controls.Button();
            btnThem = new ReaLTaiizor.Controls.Button();
            txtTenThucUong = new ReaLTaiizor.Controls.AloneTextBox();
            lblTenDanhMuc = new Label();
            txtID = new ReaLTaiizor.Controls.AloneTextBox();
            lblID = new Label();
            panel1 = new Panel();
            toolStrip1 = new ToolStrip();
            txtTuKhoa = new ToolStripTextBox();
            btnTimKiem = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnNhap = new ToolStripButton();
            btnXuat = new ToolStripButton();
            numGia = new NumericUpDown();
            label2 = new Label();
            cboDanhMuc = new ReaLTaiizor.Controls.AloneComboBox();
            label1 = new Label();
            dataGridView = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            TenDanhMuc = new DataGridViewTextBoxColumn();
            TenThucUong = new DataGridViewTextBoxColumn();
            DonGia = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numGia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.Transparent;
            btnThoat.BorderColor = Color.FromArgb(32, 34, 37);
            btnThoat.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            btnThoat.EnteredColor = Color.Black;
            btnThoat.Font = new Font("Microsoft Sans Serif", 12F);
            btnThoat.Image = null;
            btnThoat.ImageAlign = ContentAlignment.MiddleLeft;
            btnThoat.InactiveColor = Color.Gray;
            btnThoat.Location = new Point(184, 388);
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
            btnHuyBo.EnteredColor = Color.Black;
            btnHuyBo.Font = new Font("Microsoft Sans Serif", 12F);
            btnHuyBo.Image = null;
            btnHuyBo.ImageAlign = ContentAlignment.MiddleLeft;
            btnHuyBo.InactiveColor = Color.Gray;
            btnHuyBo.Location = new Point(28, 388);
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
            btnLuu.EnteredColor = Color.Black;
            btnLuu.Font = new Font("Microsoft Sans Serif", 12F);
            btnLuu.Image = null;
            btnLuu.ImageAlign = ContentAlignment.MiddleLeft;
            btnLuu.InactiveColor = Color.Gray;
            btnLuu.Location = new Point(184, 330);
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
            btnXoa.EnteredColor = Color.Black;
            btnXoa.Font = new Font("Microsoft Sans Serif", 12F);
            btnXoa.Image = null;
            btnXoa.ImageAlign = ContentAlignment.MiddleLeft;
            btnXoa.InactiveColor = Color.Gray;
            btnXoa.Location = new Point(28, 330);
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
            btnSua.EnteredColor = Color.Black;
            btnSua.Font = new Font("Microsoft Sans Serif", 12F);
            btnSua.Image = null;
            btnSua.ImageAlign = ContentAlignment.MiddleLeft;
            btnSua.InactiveColor = Color.Gray;
            btnSua.Location = new Point(184, 272);
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
            btnThem.EnteredColor = Color.Black;
            btnThem.Font = new Font("Microsoft Sans Serif", 12F);
            btnThem.Image = null;
            btnThem.ImageAlign = ContentAlignment.MiddleLeft;
            btnThem.InactiveColor = Color.Gray;
            btnThem.Location = new Point(28, 272);
            btnThem.Name = "btnThem";
            btnThem.PressedBorderColor = Color.FromArgb(165, 37, 37);
            btnThem.PressedColor = Color.FromArgb(165, 37, 37);
            btnThem.Size = new Size(120, 40);
            btnThem.TabIndex = 3;
            btnThem.Text = "Thêm";
            btnThem.TextAlignment = StringAlignment.Center;
            btnThem.Click += btnThem_Click;
            // 
            // txtTenThucUong
            // 
            txtTenThucUong.BackColor = Color.Transparent;
            txtTenThucUong.EnabledCalc = true;
            txtTenThucUong.Font = new Font("Segoe UI", 12F);
            txtTenThucUong.ForeColor = Color.FromArgb(124, 133, 142);
            txtTenThucUong.Location = new Point(28, 182);
            txtTenThucUong.MaxLength = 32767;
            txtTenThucUong.MultiLine = false;
            txtTenThucUong.Name = "txtTenThucUong";
            txtTenThucUong.ReadOnly = false;
            txtTenThucUong.Size = new Size(286, 30);
            txtTenThucUong.TabIndex = 2;
            txtTenThucUong.TextAlign = HorizontalAlignment.Left;
            txtTenThucUong.UseSystemPasswordChar = false;
            // 
            // lblTenDanhMuc
            // 
            lblTenDanhMuc.AutoSize = true;
            lblTenDanhMuc.Font = new Font("Segoe UI", 12F);
            lblTenDanhMuc.Location = new Point(28, 158);
            lblTenDanhMuc.Name = "lblTenDanhMuc";
            lblTenDanhMuc.Size = new Size(110, 21);
            lblTenDanhMuc.TabIndex = 1;
            lblTenDanhMuc.Text = "Tên thức uống:";
            // 
            // txtID
            // 
            txtID.BackColor = Color.Transparent;
            txtID.Enabled = false;
            txtID.EnabledCalc = false;
            txtID.Font = new Font("Segoe UI", 12F);
            txtID.ForeColor = Color.FromArgb(124, 133, 142);
            txtID.Location = new Point(28, 60);
            txtID.MaxLength = 32767;
            txtID.MultiLine = false;
            txtID.Name = "txtID";
            txtID.ReadOnly = false;
            txtID.Size = new Size(286, 30);
            txtID.TabIndex = 2;
            txtID.TextAlign = HorizontalAlignment.Left;
            txtID.UseSystemPasswordChar = false;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Segoe UI", 12F);
            lblID.Location = new Point(28, 36);
            lblID.Name = "lblID";
            lblID.Size = new Size(28, 21);
            lblID.TabIndex = 1;
            lblID.Text = "ID:";
            // 
            // panel1
            // 
            panel1.Controls.Add(toolStrip1);
            panel1.Controls.Add(numGia);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(cboDanhMuc);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnThoat);
            panel1.Controls.Add(btnHuyBo);
            panel1.Controls.Add(btnLuu);
            panel1.Controls.Add(btnXoa);
            panel1.Controls.Add(btnSua);
            panel1.Controls.Add(btnThem);
            panel1.Controls.Add(txtTenThucUong);
            panel1.Controls.Add(lblTenDanhMuc);
            panel1.Controls.Add(txtID);
            panel1.Controls.Add(lblID);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(557, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(357, 450);
            panel1.TabIndex = 4;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { txtTuKhoa, btnTimKiem, toolStripSeparator1, btnNhap, btnXuat });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(357, 25);
            toolStrip1.TabIndex = 8;
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
            btnTimKiem.Size = new Size(48, 22);
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
            // numGia
            // 
            numGia.Increment = new decimal(new int[] { 1000, 0, 0, 0 });
            numGia.Location = new Point(28, 239);
            numGia.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numGia.Minimum = new decimal(new int[] { 1000, 0, 0, 0 });
            numGia.Name = "numGia";
            numGia.Size = new Size(286, 23);
            numGia.TabIndex = 7;
            numGia.Tag = "";
            numGia.ThousandsSeparator = true;
            numGia.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(27, 215);
            label2.Name = "label2";
            label2.Size = new Size(36, 21);
            label2.TabIndex = 6;
            label2.Text = "Giá:";
            // 
            // cboDanhMuc
            // 
            cboDanhMuc.DrawMode = DrawMode.OwnerDrawFixed;
            cboDanhMuc.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDanhMuc.EnabledCalc = true;
            cboDanhMuc.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboDanhMuc.FormattingEnabled = true;
            cboDanhMuc.ItemHeight = 20;
            cboDanhMuc.Location = new Point(28, 129);
            cboDanhMuc.Name = "cboDanhMuc";
            cboDanhMuc.Size = new Size(286, 26);
            cboDanhMuc.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(28, 108);
            label1.Name = "label1";
            label1.Size = new Size(109, 21);
            label1.TabIndex = 4;
            label1.Text = "Tên danh mục:";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { ID, TenDanhMuc, TenThucUong, DonGia });
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(0, 0);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.Size = new Size(557, 450);
            dataGridView.TabIndex = 5;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // TenDanhMuc
            // 
            TenDanhMuc.DataPropertyName = "TenDanhMuc";
            TenDanhMuc.HeaderText = "Tên danh mục";
            TenDanhMuc.Name = "TenDanhMuc";
            TenDanhMuc.ReadOnly = true;
            // 
            // TenThucUong
            // 
            TenThucUong.DataPropertyName = "TenThucUong";
            TenThucUong.HeaderText = "Tên thức uống";
            TenThucUong.Name = "TenThucUong";
            TenThucUong.ReadOnly = true;
            // 
            // DonGia
            // 
            DonGia.DataPropertyName = "DonGia";
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            DonGia.DefaultCellStyle = dataGridViewCellStyle2;
            DonGia.HeaderText = "Đơn giá";
            DonGia.Name = "DonGia";
            DonGia.ReadOnly = true;
            // 
            // frmThucUong
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 450);
            Controls.Add(dataGridView);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmThucUong";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmThucUong";
            Load += frmThucUong_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numGia).EndInit();
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
        private ReaLTaiizor.Controls.AloneTextBox txtTenThucUong;
        private Label lblTenDanhMuc;
        private ReaLTaiizor.Controls.AloneTextBox txtID;
        private Label lblID;
        private Panel panel1;
        private ReaLTaiizor.Controls.AloneComboBox cboDanhMuc;
        private Label label1;
        private NumericUpDown numGia;
        private Label label2;
        private ToolStrip toolStrip1;
        private ToolStripTextBox txtTuKhoa;
        private ToolStripButton btnTimKiem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnNhap;
        private ToolStripButton btnXuat;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn TenDanhMuc;
        private DataGridViewTextBoxColumn TenThucUong;
        private DataGridViewTextBoxColumn DonGia;
    }
}