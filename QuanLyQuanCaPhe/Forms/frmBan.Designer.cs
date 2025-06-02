namespace QuanLyQuanCaPhe.Forms
{
    partial class frmBan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBan));
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            btnThoat = new Button();
            btnHuyBo = new Button();
            btnLuu = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            txtTenBan = new TextBox();
            txtID = new TextBox();
            lblTenBan = new Label();
            lblID = new Label();
            toolStrip1 = new ToolStrip();
            txtTuKhoa = new ToolStripTextBox();
            btnTimKiem = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnNhap = new ToolStripButton();
            btnXuat = new ToolStripButton();
            helpProvider1 = new HelpProvider();
            dataGridView = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            TenBan = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnThoat);
            panel1.Controls.Add(btnHuyBo);
            panel1.Controls.Add(btnLuu);
            panel1.Controls.Add(btnXoa);
            panel1.Controls.Add(btnSua);
            panel1.Controls.Add(btnThem);
            panel1.Controls.Add(txtTenBan);
            panel1.Controls.Add(txtID);
            panel1.Controls.Add(lblTenBan);
            panel1.Controls.Add(lblID);
            panel1.Controls.Add(toolStrip1);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(463, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(337, 450);
            panel1.TabIndex = 0;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.FromArgb(255, 200, 155);
            btnThoat.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThoat.Location = new Point(166, 363);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(138, 67);
            btnThoat.TabIndex = 10;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.BackColor = Color.LightGray;
            btnHuyBo.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHuyBo.Location = new Point(16, 363);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(138, 67);
            btnHuyBo.TabIndex = 9;
            btnHuyBo.Text = "Hủy";
            btnHuyBo.UseVisualStyleBackColor = false;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.FromArgb(147, 197, 253);
            btnLuu.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLuu.Location = new Point(166, 275);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(138, 67);
            btnLuu.TabIndex = 8;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.LightPink;
            btnXoa.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoa.Location = new Point(16, 275);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(138, 67);
            btnXoa.TabIndex = 7;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.ClientSizeChanged += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.LightBlue;
            btnSua.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSua.Location = new Point(166, 187);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(138, 67);
            btnSua.TabIndex = 6;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.LightGreen;
            btnThem.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThem.Location = new Point(16, 187);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(138, 67);
            btnThem.TabIndex = 5;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // txtTenBan
            // 
            txtTenBan.Font = new Font("Segoe UI", 15.75F);
            txtTenBan.Location = new Point(97, 124);
            txtTenBan.Name = "txtTenBan";
            txtTenBan.Size = new Size(207, 35);
            txtTenBan.TabIndex = 4;
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Font = new Font("Segoe UI", 15.75F);
            txtID.Location = new Point(97, 71);
            txtID.Name = "txtID";
            txtID.Size = new Size(207, 35);
            txtID.TabIndex = 2;
            // 
            // lblTenBan
            // 
            lblTenBan.AutoSize = true;
            lblTenBan.Font = new Font("Segoe UI", 12F);
            lblTenBan.Location = new Point(16, 131);
            lblTenBan.Name = "lblTenBan";
            lblTenBan.Size = new Size(66, 21);
            lblTenBan.TabIndex = 3;
            lblTenBan.Text = "Tên bàn:";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Segoe UI", 12F);
            lblID.Location = new Point(16, 78);
            lblID.Name = "lblID";
            lblID.Size = new Size(28, 21);
            lblID.TabIndex = 1;
            lblID.Text = "ID:";
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
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { ID, TenBan });
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(0, 0);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.Size = new Size(463, 450);
            dataGridView.TabIndex = 1;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            ID.DefaultCellStyle = dataGridViewCellStyle2;
            ID.FillWeight = 20F;
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // TenBan
            // 
            TenBan.DataPropertyName = "TenBan";
            TenBan.HeaderText = "Tên bàn";
            TenBan.Name = "TenBan";
            TenBan.ReadOnly = true;
            // 
            // frmBan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmBan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý bàn";
            WindowState = FormWindowState.Maximized;
            Load += frmBan_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ToolStrip toolStrip1;
        private ToolStripTextBox txtTuKhoa;
        private ToolStripButton btnTimKiem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnNhap;
        private ToolStripButton btnXuat;
        private Label lblTenBan;
        private Label lblID;
        private TextBox txtTenBan;
        private TextBox txtID;
        private Button btnThoat;
        private Button btnHuyBo;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private HelpProvider helpProvider1;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn TenBan;
    }
}