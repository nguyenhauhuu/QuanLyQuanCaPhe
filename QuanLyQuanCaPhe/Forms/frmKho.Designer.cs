namespace QuanLyQuanCaPhe.Forms
{
    partial class frmKho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKho));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            btnThoat = new Button();
            toolStrip1 = new ToolStrip();
            txtTuKhoa = new ToolStripTextBox();
            btnTimKiem = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnNhap = new ToolStripButton();
            btnXuat = new ToolStripButton();
            btnHuyBo = new Button();
            dtpNgayHetHan = new DateTimePicker();
            btnLuu = new Button();
            cboDonVi = new ComboBox();
            btnXoa = new Button();
            numGia = new NumericUpDown();
            btnSua = new Button();
            numSoLuong = new NumericUpDown();
            btnThem = new Button();
            cboNguyenLieu = new ComboBox();
            txtMoTa = new TextBox();
            txtID = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lblID = new Label();
            dataGridView = new DataGridView();
            helpProvider1 = new HelpProvider();
            NguyenLieu = new DataGridViewTextBoxColumn();
            MoTa = new DataGridViewTextBoxColumn();
            SoLuong = new DataGridViewTextBoxColumn();
            DonVi = new DataGridViewTextBoxColumn();
            Gia = new DataGridViewTextBoxColumn();
            NgayHetHan = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numGia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnThoat);
            panel1.Controls.Add(toolStrip1);
            panel1.Controls.Add(btnHuyBo);
            panel1.Controls.Add(dtpNgayHetHan);
            panel1.Controls.Add(btnLuu);
            panel1.Controls.Add(cboDonVi);
            panel1.Controls.Add(btnXoa);
            panel1.Controls.Add(numGia);
            panel1.Controls.Add(btnSua);
            panel1.Controls.Add(numSoLuong);
            panel1.Controls.Add(btnThem);
            panel1.Controls.Add(cboNguyenLieu);
            panel1.Controls.Add(txtMoTa);
            panel1.Controls.Add(txtID);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblID);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(794, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(337, 450);
            panel1.TabIndex = 4;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.FromArgb(255, 200, 155);
            btnThoat.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThoat.Location = new Point(178, 386);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(129, 46);
            btnThoat.TabIndex = 20;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
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
            // btnHuyBo
            // 
            btnHuyBo.BackColor = Color.LightGray;
            btnHuyBo.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHuyBo.Location = new Point(19, 386);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(129, 46);
            btnHuyBo.TabIndex = 19;
            btnHuyBo.Text = "Hủy";
            btnHuyBo.UseVisualStyleBackColor = false;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // dtpNgayHetHan
            // 
            dtpNgayHetHan.CustomFormat = "dd/MM/yyyy";
            dtpNgayHetHan.Format = DateTimePickerFormat.Custom;
            dtpNgayHetHan.Location = new Point(112, 218);
            dtpNgayHetHan.MinDate = new DateTime(2025, 5, 30, 0, 0, 0, 0);
            dtpNgayHetHan.Name = "dtpNgayHetHan";
            dtpNgayHetHan.Size = new Size(200, 23);
            dtpNgayHetHan.TabIndex = 14;
            dtpNgayHetHan.Value = new DateTime(2025, 5, 30, 20, 59, 28, 0);
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.FromArgb(147, 197, 253);
            btnLuu.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLuu.Location = new Point(178, 322);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(129, 46);
            btnLuu.TabIndex = 18;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // cboDonVi
            // 
            cboDonVi.FormattingEnabled = true;
            cboDonVi.Items.AddRange(new object[] { "g", "kg", "ml", "l", "cái", "thùng" });
            cboDonVi.Location = new Point(231, 151);
            cboDonVi.Name = "cboDonVi";
            cboDonVi.Size = new Size(81, 23);
            cboDonVi.TabIndex = 10;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.LightPink;
            btnXoa.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoa.Location = new Point(19, 322);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(129, 46);
            btnXoa.TabIndex = 17;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // numGia
            // 
            numGia.Location = new Point(87, 185);
            numGia.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numGia.Minimum = new decimal(new int[] { 1000, 0, 0, 0 });
            numGia.Name = "numGia";
            numGia.Size = new Size(225, 23);
            numGia.TabIndex = 12;
            numGia.ThousandsSeparator = true;
            numGia.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.LightBlue;
            btnSua.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSua.Location = new Point(178, 258);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(129, 46);
            btnSua.TabIndex = 16;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // numSoLuong
            // 
            numSoLuong.Location = new Point(87, 151);
            numSoLuong.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numSoLuong.Name = "numSoLuong";
            numSoLuong.Size = new Size(84, 23);
            numSoLuong.TabIndex = 8;
            numSoLuong.ThousandsSeparator = true;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.LightGreen;
            btnThem.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThem.Location = new Point(19, 258);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(129, 46);
            btnThem.TabIndex = 15;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // cboNguyenLieu
            // 
            cboNguyenLieu.FormattingEnabled = true;
            cboNguyenLieu.Location = new Point(103, 77);
            cboNguyenLieu.Name = "cboNguyenLieu";
            cboNguyenLieu.Size = new Size(209, 23);
            cboNguyenLieu.TabIndex = 4;
            // 
            // txtMoTa
            // 
            txtMoTa.Location = new Point(71, 109);
            txtMoTa.Name = "txtMoTa";
            txtMoTa.Size = new Size(241, 23);
            txtMoTa.TabIndex = 6;
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Location = new Point(46, 33);
            txtID.Name = "txtID";
            txtID.Size = new Size(266, 23);
            txtID.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F);
            label6.Location = new Point(17, 222);
            label6.Name = "label6";
            label6.Size = new Size(89, 17);
            label6.TabIndex = 13;
            label6.Text = "Ngày hết hạn:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F);
            label5.Location = new Point(19, 185);
            label5.Name = "label5";
            label5.Size = new Size(30, 17);
            label5.TabIndex = 11;
            label5.Text = "Giá:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F);
            label4.Location = new Point(177, 151);
            label4.Name = "label4";
            label4.Size = new Size(48, 17);
            label4.TabIndex = 9;
            label4.Text = "Đơn vị:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F);
            label3.Location = new Point(17, 151);
            label3.Name = "label3";
            label3.Size = new Size(64, 17);
            label3.TabIndex = 7;
            label3.Text = "Số lượng:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F);
            label2.Location = new Point(19, 115);
            label2.Name = "label2";
            label2.Size = new Size(46, 17);
            label2.TabIndex = 5;
            label2.Text = "Mô tả:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F);
            label1.Location = new Point(17, 80);
            label1.Name = "label1";
            label1.Size = new Size(80, 17);
            label1.TabIndex = 3;
            label1.Text = "Nguyên liệu:";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Segoe UI", 9.75F);
            lblID.Location = new Point(17, 39);
            lblID.Name = "lblID";
            lblID.Size = new Size(23, 17);
            lblID.TabIndex = 1;
            lblID.Text = "ID:";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { NguyenLieu, MoTa, SoLuong, DonVi, Gia, NgayHetHan });
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(0, 0);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.Size = new Size(794, 450);
            dataGridView.TabIndex = 0;
            dataGridView.RowPrePaint += dataGridView_RowPrePaint;
            // 
            // NguyenLieu
            // 
            NguyenLieu.DataPropertyName = "TenNguyenLieu";
            NguyenLieu.HeaderText = "Nguyên liệu";
            NguyenLieu.Name = "NguyenLieu";
            NguyenLieu.ReadOnly = true;
            // 
            // MoTa
            // 
            MoTa.DataPropertyName = "MoTa";
            MoTa.HeaderText = "Mô tả";
            MoTa.Name = "MoTa";
            MoTa.ReadOnly = true;
            // 
            // SoLuong
            // 
            SoLuong.DataPropertyName = "SoLuong";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            SoLuong.DefaultCellStyle = dataGridViewCellStyle1;
            SoLuong.HeaderText = "Số lượng";
            SoLuong.Name = "SoLuong";
            SoLuong.ReadOnly = true;
            // 
            // DonVi
            // 
            DonVi.DataPropertyName = "DonVi";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            DonVi.DefaultCellStyle = dataGridViewCellStyle2;
            DonVi.HeaderText = "Đơn vị";
            DonVi.Name = "DonVi";
            DonVi.ReadOnly = true;
            // 
            // Gia
            // 
            Gia.DataPropertyName = "Gia";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = null;
            Gia.DefaultCellStyle = dataGridViewCellStyle3;
            Gia.HeaderText = "Giá";
            Gia.Name = "Gia";
            Gia.ReadOnly = true;
            // 
            // NgayHetHan
            // 
            NgayHetHan.DataPropertyName = "NgayHetHan";
            NgayHetHan.HeaderText = "Ngày hết hạn";
            NgayHetHan.Name = "NgayHetHan";
            NgayHetHan.ReadOnly = true;
            // 
            // frmKho
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1131, 450);
            Controls.Add(dataGridView);
            Controls.Add(panel1);
            Name = "frmKho";
            Text = "Quản lý kho";
            Load += frmKho_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numGia).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ReaLTaiizor.Controls.Button btnKhoiPhucMatKhau;
        private Panel panel1;
        private ReaLTaiizor.Controls.AloneTextBox txtTenDangNhap;
        private Label lblID;
        private TextBox txtID;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DateTimePicker dtpNgayHetHan;
        private ComboBox cboDonVi;
        private NumericUpDown numGia;
        private NumericUpDown numSoLuong;
        private ComboBox cboNguyenLieu;
        private TextBox txtMoTa;
        private ToolStrip toolStrip1;
        private ToolStripTextBox txtTuKhoa;
        private ToolStripButton btnTimKiem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnNhap;
        private ToolStripButton btnXuat;
        private Button btnThoat;
        private Button btnHuyBo;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private DataGridView dataGridView;
        private HelpProvider helpProvider1;
        private DataGridViewTextBoxColumn NguyenLieu;
        private DataGridViewTextBoxColumn MoTa;
        private DataGridViewTextBoxColumn SoLuong;
        private DataGridViewTextBoxColumn DonVi;
        private DataGridViewTextBoxColumn Gia;
        private DataGridViewTextBoxColumn NgayHetHan;
    }
}