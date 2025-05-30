namespace QuanLyQuanCaPhe.Forms
{
    partial class frmNguyenLieu
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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNguyenLieu));
            panel = new Panel();
            txtTenNguyenLieu = new ReaLTaiizor.Controls.AloneTextBox();
            lblTenNguyenLieu = new Label();
            txtID = new ReaLTaiizor.Controls.AloneTextBox();
            lblID = new Label();
            dataGridView = new ReaLTaiizor.Controls.PoisonDataGridView();
            ID = new DataGridViewTextBoxColumn();
            TenNguyenLieu = new DataGridViewTextBoxColumn();
            btnThoat = new Button();
            btnHuyBo = new Button();
            btnLuu = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            toolStrip1 = new ToolStrip();
            txtTuKhoa = new ToolStripTextBox();
            btnTimKiem = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnNhap = new ToolStripButton();
            btnXuat = new ToolStripButton();
            panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel
            // 
            panel.Controls.Add(toolStrip1);
            panel.Controls.Add(btnThoat);
            panel.Controls.Add(txtTenNguyenLieu);
            panel.Controls.Add(btnHuyBo);
            panel.Controls.Add(lblTenNguyenLieu);
            panel.Controls.Add(btnLuu);
            panel.Controls.Add(txtID);
            panel.Controls.Add(btnXoa);
            panel.Controls.Add(lblID);
            panel.Controls.Add(btnSua);
            panel.Controls.Add(btnThem);
            panel.Dock = DockStyle.Right;
            panel.Location = new Point(451, 0);
            panel.Name = "panel";
            panel.Size = new Size(349, 450);
            panel.TabIndex = 4;
            // 
            // txtTenNguyenLieu
            // 
            txtTenNguyenLieu.BackColor = Color.Transparent;
            txtTenNguyenLieu.EnabledCalc = true;
            txtTenNguyenLieu.Font = new Font("Segoe UI", 12F);
            txtTenNguyenLieu.ForeColor = Color.FromArgb(124, 133, 142);
            txtTenNguyenLieu.Location = new Point(28, 140);
            txtTenNguyenLieu.MaxLength = 32767;
            txtTenNguyenLieu.MultiLine = false;
            txtTenNguyenLieu.Name = "txtTenNguyenLieu";
            txtTenNguyenLieu.ReadOnly = false;
            txtTenNguyenLieu.Size = new Size(286, 42);
            txtTenNguyenLieu.TabIndex = 2;
            txtTenNguyenLieu.TextAlign = HorizontalAlignment.Left;
            txtTenNguyenLieu.UseSystemPasswordChar = false;
            // 
            // lblTenNguyenLieu
            // 
            lblTenNguyenLieu.AutoSize = true;
            lblTenNguyenLieu.Font = new Font("Segoe UI", 12F);
            lblTenNguyenLieu.Location = new Point(28, 116);
            lblTenNguyenLieu.Name = "lblTenNguyenLieu";
            lblTenNguyenLieu.Size = new Size(121, 21);
            lblTenNguyenLieu.TabIndex = 1;
            lblTenNguyenLieu.Text = "Tên nguyên liệu:";
            // 
            // txtID
            // 
            txtID.BackColor = Color.Transparent;
            txtID.Enabled = false;
            txtID.EnabledCalc = false;
            txtID.Font = new Font("Segoe UI", 12F);
            txtID.ForeColor = Color.FromArgb(124, 133, 142);
            txtID.Location = new Point(28, 69);
            txtID.MaxLength = 32767;
            txtID.MultiLine = false;
            txtID.Name = "txtID";
            txtID.ReadOnly = false;
            txtID.Size = new Size(286, 42);
            txtID.TabIndex = 2;
            txtID.TextAlign = HorizontalAlignment.Left;
            txtID.UseSystemPasswordChar = false;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Segoe UI", 12F);
            lblID.Location = new Point(28, 45);
            lblID.Name = "lblID";
            lblID.Size = new Size(28, 21);
            lblID.TabIndex = 1;
            lblID.Text = "ID:";
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
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle7.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { ID, TenNguyenLieu });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle8.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dataGridView.DefaultCellStyle = dataGridViewCellStyle8;
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridView.GridColor = Color.FromArgb(255, 255, 255);
            dataGridView.Location = new Point(0, 0);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle9.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(451, 450);
            dataGridView.TabIndex = 6;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // TenNguyenLieu
            // 
            TenNguyenLieu.DataPropertyName = "TenNguyenLieu";
            TenNguyenLieu.HeaderText = "Tên nguyên liệu";
            TenNguyenLieu.Name = "TenNguyenLieu";
            TenNguyenLieu.ReadOnly = true;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.FromArgb(255, 200, 155);
            btnThoat.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThoat.Location = new Point(178, 364);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(138, 67);
            btnThoat.TabIndex = 13;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            // 
            // btnHuyBo
            // 
            btnHuyBo.BackColor = Color.LightGray;
            btnHuyBo.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHuyBo.Location = new Point(28, 364);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(138, 67);
            btnHuyBo.TabIndex = 14;
            btnHuyBo.Text = "Hủy";
            btnHuyBo.UseVisualStyleBackColor = false;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.FromArgb(147, 197, 253);
            btnLuu.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLuu.Location = new Point(178, 276);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(138, 67);
            btnLuu.TabIndex = 15;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.LightPink;
            btnXoa.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoa.Location = new Point(28, 276);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(138, 67);
            btnXoa.TabIndex = 16;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.LightBlue;
            btnSua.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSua.Location = new Point(178, 188);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(138, 67);
            btnSua.TabIndex = 17;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.LightGreen;
            btnThem.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThem.Location = new Point(28, 188);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(138, 67);
            btnThem.TabIndex = 18;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { txtTuKhoa, btnTimKiem, toolStripSeparator1, btnNhap, btnXuat });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(349, 25);
            toolStrip1.TabIndex = 19;
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
            // frmNguyenLieu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView);
            Controls.Add(panel);
            Name = "frmNguyenLieu";
            Text = "frmNguyenLieu";
            Load += frmNguyenLieu_Load;
            panel.ResumeLayout(false);
            panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel;
        private ReaLTaiizor.Controls.AloneTextBox txtTenNguyenLieu;
        private Label lblTenNguyenLieu;
        private ReaLTaiizor.Controls.AloneTextBox txtID;
        private Label lblID;
        private ReaLTaiizor.Controls.PoisonDataGridView dataGridView;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn TenNguyenLieu;
        private Button btnThoat;
        private Button btnHuyBo;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private ToolStrip toolStrip1;
        private ToolStripTextBox txtTuKhoa;
        private ToolStripButton btnTimKiem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnNhap;
        private ToolStripButton btnXuat;
    }
}