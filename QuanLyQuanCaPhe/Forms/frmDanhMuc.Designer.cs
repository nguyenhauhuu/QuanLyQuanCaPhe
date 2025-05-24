namespace QuanLyQuanCaPhe.Forms
{
    partial class frmDanhMuc
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDanhMuc));
            dataGridView = new ReaLTaiizor.Controls.PoisonDataGridView();
            ID = new DataGridViewTextBoxColumn();
            TenDanhMuc = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            btnThoat = new ReaLTaiizor.Controls.Button();
            btnHuyBo = new ReaLTaiizor.Controls.Button();
            btnLuu = new ReaLTaiizor.Controls.Button();
            btnXoa = new ReaLTaiizor.Controls.Button();
            btnSua = new ReaLTaiizor.Controls.Button();
            btnThem = new ReaLTaiizor.Controls.Button();
            txtTenDanhMuc = new ReaLTaiizor.Controls.AloneTextBox();
            lblTenDanhMuc = new Label();
            txtID = new ReaLTaiizor.Controls.AloneTextBox();
            lblID = new Label();
            toolStrip1 = new ToolStrip();
            txtTuKhoa = new ToolStripTextBox();
            btnTimKiem = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnNhap = new ToolStripButton();
            btnXuat = new ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            panel1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
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
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { ID, TenDanhMuc });
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
            dataGridView.GridColor = Color.White;
            dataGridView.Location = new Point(0, 0);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(443, 450);
            dataGridView.TabIndex = 3;
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
            // panel1
            // 
            panel1.Controls.Add(toolStrip1);
            panel1.Controls.Add(btnThoat);
            panel1.Controls.Add(btnHuyBo);
            panel1.Controls.Add(btnLuu);
            panel1.Controls.Add(btnXoa);
            panel1.Controls.Add(btnSua);
            panel1.Controls.Add(btnThem);
            panel1.Controls.Add(txtTenDanhMuc);
            panel1.Controls.Add(lblTenDanhMuc);
            panel1.Controls.Add(txtID);
            panel1.Controls.Add(lblID);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(443, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(357, 450);
            panel1.TabIndex = 2;
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
            btnThoat.Location = new Point(184, 337);
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
            btnHuyBo.Location = new Point(28, 337);
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
            btnLuu.Location = new Point(184, 268);
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
            btnXoa.Location = new Point(28, 268);
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
            btnSua.Location = new Point(184, 201);
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
            btnThem.Location = new Point(28, 201);
            btnThem.Name = "btnThem";
            btnThem.PressedBorderColor = Color.FromArgb(165, 37, 37);
            btnThem.PressedColor = Color.FromArgb(165, 37, 37);
            btnThem.Size = new Size(120, 40);
            btnThem.TabIndex = 3;
            btnThem.Text = "Thêm";
            btnThem.TextAlignment = StringAlignment.Center;
            btnThem.Click += btnThem_Click;
            // 
            // txtTenDanhMuc
            // 
            txtTenDanhMuc.BackColor = Color.Transparent;
            txtTenDanhMuc.EnabledCalc = true;
            txtTenDanhMuc.Font = new Font("Segoe UI", 12F);
            txtTenDanhMuc.ForeColor = Color.FromArgb(124, 133, 142);
            txtTenDanhMuc.Location = new Point(28, 140);
            txtTenDanhMuc.MaxLength = 32767;
            txtTenDanhMuc.MultiLine = false;
            txtTenDanhMuc.Name = "txtTenDanhMuc";
            txtTenDanhMuc.ReadOnly = false;
            txtTenDanhMuc.Size = new Size(286, 42);
            txtTenDanhMuc.TabIndex = 2;
            txtTenDanhMuc.TextAlign = HorizontalAlignment.Left;
            txtTenDanhMuc.UseSystemPasswordChar = false;
            // 
            // lblTenDanhMuc
            // 
            lblTenDanhMuc.AutoSize = true;
            lblTenDanhMuc.Font = new Font("Segoe UI", 12F);
            lblTenDanhMuc.Location = new Point(28, 116);
            lblTenDanhMuc.Name = "lblTenDanhMuc";
            lblTenDanhMuc.Size = new Size(109, 21);
            lblTenDanhMuc.TabIndex = 1;
            lblTenDanhMuc.Text = "Tên danh mục:";
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
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { txtTuKhoa, btnTimKiem, toolStripSeparator1, btnNhap, btnXuat });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(357, 25);
            toolStrip1.TabIndex = 4;
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
            // frmDanhMuc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmDanhMuc";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmDanhMuc";
            Load += frmDanhMuc_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ReaLTaiizor.Controls.PoisonDataGridView dataGridView;
        private Panel panel1;
        private ReaLTaiizor.Controls.Button btnThoat;
        private ReaLTaiizor.Controls.Button btnHuyBo;
        private ReaLTaiizor.Controls.Button btnLuu;
        private ReaLTaiizor.Controls.Button btnXoa;
        private ReaLTaiizor.Controls.Button btnSua;
        private ReaLTaiizor.Controls.Button btnThem;
        private ReaLTaiizor.Controls.AloneTextBox txtTenDanhMuc;
        private Label lblTenDanhMuc;
        private ReaLTaiizor.Controls.AloneTextBox txtID;
        private Label lblID;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn TenDanhMuc;
        private ToolStrip toolStrip1;
        private ToolStripTextBox txtTuKhoa;
        private ToolStripButton btnTimKiem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnNhap;
        private ToolStripButton btnXuat;
    }
}