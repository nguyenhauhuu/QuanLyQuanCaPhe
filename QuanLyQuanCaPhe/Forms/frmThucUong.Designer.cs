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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            lblTenDanhMuc = new Label();
            lblID = new Label();
            panel1 = new Panel();
            btnThoat = new Button();
            btnHuyBo = new Button();
            btnLuu = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            txtTenThucUong = new TextBox();
            txtID = new TextBox();
            cboDanhMuc = new ComboBox();
            toolStrip1 = new ToolStrip();
            txtTuKhoa = new ToolStripTextBox();
            btnTimKiem = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnNhap = new ToolStripButton();
            btnXuat = new ToolStripButton();
            numGia = new NumericUpDown();
            label2 = new Label();
            label1 = new Label();
            helpProvider1 = new HelpProvider();
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
            // lblTenDanhMuc
            // 
            lblTenDanhMuc.AutoSize = true;
            lblTenDanhMuc.Font = new Font("Segoe UI", 12F);
            lblTenDanhMuc.Location = new Point(28, 158);
            lblTenDanhMuc.Name = "lblTenDanhMuc";
            lblTenDanhMuc.Size = new Size(110, 21);
            lblTenDanhMuc.TabIndex = 5;
            lblTenDanhMuc.Text = "Tên thức uống:";
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
            panel1.Controls.Add(btnThoat);
            panel1.Controls.Add(btnHuyBo);
            panel1.Controls.Add(btnLuu);
            panel1.Controls.Add(btnXoa);
            panel1.Controls.Add(btnSua);
            panel1.Controls.Add(btnThem);
            panel1.Controls.Add(txtTenThucUong);
            panel1.Controls.Add(txtID);
            panel1.Controls.Add(cboDanhMuc);
            panel1.Controls.Add(toolStrip1);
            panel1.Controls.Add(numGia);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblTenDanhMuc);
            panel1.Controls.Add(lblID);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(581, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(333, 450);
            panel1.TabIndex = 4;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.FromArgb(255, 200, 155);
            btnThoat.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThoat.Location = new Point(186, 396);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(129, 46);
            btnThoat.TabIndex = 14;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.BackColor = Color.LightGray;
            btnHuyBo.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHuyBo.Location = new Point(27, 396);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(129, 46);
            btnHuyBo.TabIndex = 13;
            btnHuyBo.Text = "Hủy";
            btnHuyBo.UseVisualStyleBackColor = false;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.FromArgb(147, 197, 253);
            btnLuu.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLuu.Location = new Point(186, 332);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(129, 46);
            btnLuu.TabIndex = 12;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.LightPink;
            btnXoa.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoa.Location = new Point(27, 332);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(129, 46);
            btnXoa.TabIndex = 11;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.LightBlue;
            btnSua.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSua.Location = new Point(186, 268);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(129, 46);
            btnSua.TabIndex = 10;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.LightGreen;
            btnThem.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThem.Location = new Point(27, 268);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(129, 46);
            btnThem.TabIndex = 9;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // txtTenThucUong
            // 
            txtTenThucUong.Location = new Point(27, 182);
            txtTenThucUong.Name = "txtTenThucUong";
            txtTenThucUong.Size = new Size(276, 23);
            txtTenThucUong.TabIndex = 6;
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Location = new Point(62, 35);
            txtID.Name = "txtID";
            txtID.Size = new Size(242, 23);
            txtID.TabIndex = 2;
            // 
            // cboDanhMuc
            // 
            cboDanhMuc.FormattingEnabled = true;
            cboDanhMuc.Location = new Point(27, 113);
            cboDanhMuc.Name = "cboDanhMuc";
            cboDanhMuc.Size = new Size(276, 23);
            cboDanhMuc.TabIndex = 4;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { txtTuKhoa, btnTimKiem, toolStripSeparator1, btnNhap, btnXuat });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(333, 25);
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
            // numGia
            // 
            numGia.Increment = new decimal(new int[] { 1000, 0, 0, 0 });
            numGia.Location = new Point(28, 239);
            numGia.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numGia.Minimum = new decimal(new int[] { 1000, 0, 0, 0 });
            numGia.Name = "numGia";
            numGia.Size = new Size(276, 23);
            numGia.TabIndex = 8;
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
            label2.TabIndex = 7;
            label2.Text = "Giá:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(27, 90);
            label1.Name = "label1";
            label1.Size = new Size(109, 21);
            label1.TabIndex = 3;
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
            dataGridView.Size = new Size(581, 450);
            dataGridView.TabIndex = 5;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            ID.DefaultCellStyle = dataGridViewCellStyle3;
            ID.FillWeight = 20F;
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
            TenThucUong.DataPropertyName = "TenDanhMuc";
            TenThucUong.HeaderText = "Tên thức uống";
            TenThucUong.Name = "TenThucUong";
            TenThucUong.ReadOnly = true;
            // 
            // DonGia
            // 
            DonGia.DataPropertyName = "DonGia";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N0";
            dataGridViewCellStyle4.NullValue = null;
            DonGia.DefaultCellStyle = dataGridViewCellStyle4;
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
            Text = "Quản lý thức uống";
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
        private Label lblTenDanhMuc;
        private Label lblID;
        private Panel panel1;
        private Label label1;
        private NumericUpDown numGia;
        private Label label2;
        private ToolStrip toolStrip1;
        private ToolStripTextBox txtTuKhoa;
        private ToolStripButton btnTimKiem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnNhap;
        private ToolStripButton btnXuat;
        private TextBox txtTenThucUong;
        private TextBox txtID;
        private ComboBox cboDanhMuc;
        private Button btnThoat;
        private Button btnHuyBo;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private HelpProvider helpProvider1;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn TenDanhMuc;
        private DataGridViewTextBoxColumn TenThucUong;
        private DataGridViewTextBoxColumn DonGia;
    }
}