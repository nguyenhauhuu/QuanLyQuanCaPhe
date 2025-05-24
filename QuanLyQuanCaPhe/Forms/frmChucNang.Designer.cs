namespace QuanLyQuanCaPhe.Forms
{
    partial class frmChucNang
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
            groupBox = new GroupBox();
            txtMoTa = new ReaLTaiizor.Controls.AloneTextBox();
            numSoLuong = new ReaLTaiizor.Controls.HopeNumeric();
            btnTinhTien = new ReaLTaiizor.Controls.Button();
            txtTongTien = new ReaLTaiizor.Controls.AloneTextBox();
            label6 = new Label();
            label5 = new Label();
            numGiamGia = new NumericUpDown();
            btnGopBan = new ReaLTaiizor.Controls.Button();
            btnChuyenBan = new ReaLTaiizor.Controls.Button();
            cboBanDich = new ReaLTaiizor.Controls.AloneComboBox();
            cboBanDau = new ReaLTaiizor.Controls.AloneComboBox();
            dgvDanhSachThucUong = new DataGridView();
            TenThucUong = new DataGridViewTextBoxColumn();
            SoLuong = new DataGridViewTextBoxColumn();
            ThanhTien = new DataGridViewTextBoxColumn();
            label4 = new Label();
            btnLuu = new ReaLTaiizor.Controls.Button();
            btnXoa = new ReaLTaiizor.Controls.Button();
            btnThem = new ReaLTaiizor.Controls.Button();
            label7 = new Label();
            label3 = new Label();
            label2 = new Label();
            cboThucUong = new ReaLTaiizor.Controls.AloneComboBox();
            cboDanhMuc = new ReaLTaiizor.Controls.AloneComboBox();
            label1 = new Label();
            flpDanhSachBan = new FlowLayoutPanel();
            groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numGiamGia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachThucUong).BeginInit();
            SuspendLayout();
            // 
            // groupBox
            // 
            groupBox.Controls.Add(txtMoTa);
            groupBox.Controls.Add(numSoLuong);
            groupBox.Controls.Add(btnTinhTien);
            groupBox.Controls.Add(txtTongTien);
            groupBox.Controls.Add(label6);
            groupBox.Controls.Add(label5);
            groupBox.Controls.Add(numGiamGia);
            groupBox.Controls.Add(btnGopBan);
            groupBox.Controls.Add(btnChuyenBan);
            groupBox.Controls.Add(cboBanDich);
            groupBox.Controls.Add(cboBanDau);
            groupBox.Controls.Add(dgvDanhSachThucUong);
            groupBox.Controls.Add(label4);
            groupBox.Controls.Add(btnLuu);
            groupBox.Controls.Add(btnXoa);
            groupBox.Controls.Add(btnThem);
            groupBox.Controls.Add(label7);
            groupBox.Controls.Add(label3);
            groupBox.Controls.Add(label2);
            groupBox.Controls.Add(cboThucUong);
            groupBox.Controls.Add(cboDanhMuc);
            groupBox.Controls.Add(label1);
            groupBox.Dock = DockStyle.Right;
            groupBox.Location = new Point(330, 0);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(470, 450);
            groupBox.TabIndex = 2;
            groupBox.TabStop = false;
            groupBox.Text = "Bàn";
            // 
            // txtMoTa
            // 
            txtMoTa.BackColor = Color.Transparent;
            txtMoTa.EnabledCalc = true;
            txtMoTa.Font = new Font("Segoe UI", 9F);
            txtMoTa.ForeColor = Color.FromArgb(124, 133, 142);
            txtMoTa.Location = new Point(96, 118);
            txtMoTa.MaxLength = 32767;
            txtMoTa.MultiLine = false;
            txtMoTa.Name = "txtMoTa";
            txtMoTa.ReadOnly = false;
            txtMoTa.Size = new Size(362, 29);
            txtMoTa.TabIndex = 14;
            txtMoTa.TextAlign = HorizontalAlignment.Left;
            txtMoTa.UseSystemPasswordChar = false;
            // 
            // numSoLuong
            // 
            numSoLuong.BackColor = Color.White;
            numSoLuong.BaseColor = Color.FromArgb(242, 246, 252);
            numSoLuong.BorderColorA = Color.FromArgb(192, 196, 204);
            numSoLuong.BorderColorB = Color.FromArgb(192, 196, 204);
            numSoLuong.BorderHoverColorA = Color.FromArgb(64, 158, 255);
            numSoLuong.ButtonTextColorA = Color.FromArgb(144, 147, 153);
            numSoLuong.ButtonTextColorB = Color.FromArgb(144, 147, 153);
            numSoLuong.EnterKey = true;
            numSoLuong.Font = new Font("Segoe UI", 12F);
            numSoLuong.ForeColor = Color.Black;
            numSoLuong.HoverButtonTextColorA = Color.FromArgb(64, 158, 255);
            numSoLuong.HoverButtonTextColorB = Color.FromArgb(64, 158, 255);
            numSoLuong.Location = new Point(344, 76);
            numSoLuong.MaxNum = 100F;
            numSoLuong.MinNum = 1F;
            numSoLuong.Name = "numSoLuong";
            numSoLuong.Precision = 0;
            numSoLuong.Size = new Size(120, 32);
            numSoLuong.Step = 1F;
            numSoLuong.Style = ReaLTaiizor.Controls.HopeNumeric.NumericStyle.LeftRight;
            numSoLuong.TabIndex = 13;
            numSoLuong.ValueNumber = 1F;
            // 
            // btnTinhTien
            // 
            btnTinhTien.BackColor = Color.Transparent;
            btnTinhTien.BorderColor = Color.FromArgb(32, 34, 37);
            btnTinhTien.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            btnTinhTien.EnteredColor = Color.FromArgb(32, 34, 37);
            btnTinhTien.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTinhTien.Image = null;
            btnTinhTien.ImageAlign = ContentAlignment.MiddleLeft;
            btnTinhTien.InactiveColor = Color.FromArgb(32, 34, 37);
            btnTinhTien.Location = new Point(358, 385);
            btnTinhTien.Name = "btnTinhTien";
            btnTinhTien.PressedBorderColor = Color.FromArgb(165, 37, 37);
            btnTinhTien.PressedColor = Color.FromArgb(165, 37, 37);
            btnTinhTien.Size = new Size(100, 59);
            btnTinhTien.TabIndex = 12;
            btnTinhTien.Text = "TÍNH TIỀN";
            btnTinhTien.TextAlignment = StringAlignment.Center;
            btnTinhTien.Click += btnTinhTien_Click;
            // 
            // txtTongTien
            // 
            txtTongTien.BackColor = Color.Transparent;
            txtTongTien.EnabledCalc = true;
            txtTongTien.Font = new Font("Segoe UI", 9F);
            txtTongTien.ForeColor = Color.FromArgb(124, 133, 142);
            txtTongTien.Location = new Point(232, 417);
            txtTongTien.MaxLength = 32767;
            txtTongTien.MultiLine = false;
            txtTongTien.Name = "txtTongTien";
            txtTongTien.ReadOnly = false;
            txtTongTien.Size = new Size(120, 29);
            txtTongTien.TabIndex = 11;
            txtTongTien.TextAlign = HorizontalAlignment.Left;
            txtTongTien.UseSystemPasswordChar = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(255, 388);
            label6.Name = "label6";
            label6.Size = new Size(75, 21);
            label6.TabIndex = 10;
            label6.Text = "Tổng tiền";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(167, 391);
            label5.Name = "label5";
            label5.Size = new Size(75, 15);
            label5.TabIndex = 10;
            label5.Text = "Giảm giá (%)";
            // 
            // numGiamGia
            // 
            numGiamGia.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numGiamGia.Location = new Point(167, 419);
            numGiamGia.Name = "numGiamGia";
            numGiamGia.Size = new Size(59, 25);
            numGiamGia.TabIndex = 9;
            // 
            // btnGopBan
            // 
            btnGopBan.BackColor = Color.Transparent;
            btnGopBan.BorderColor = Color.FromArgb(32, 34, 37);
            btnGopBan.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            btnGopBan.EnteredColor = Color.FromArgb(32, 34, 37);
            btnGopBan.Font = new Font("Microsoft Sans Serif", 9F);
            btnGopBan.Image = null;
            btnGopBan.ImageAlign = ContentAlignment.MiddleLeft;
            btnGopBan.InactiveColor = Color.FromArgb(32, 34, 37);
            btnGopBan.Location = new Point(90, 417);
            btnGopBan.Name = "btnGopBan";
            btnGopBan.PressedBorderColor = Color.FromArgb(165, 37, 37);
            btnGopBan.PressedColor = Color.FromArgb(165, 37, 37);
            btnGopBan.Size = new Size(71, 27);
            btnGopBan.TabIndex = 8;
            btnGopBan.Text = "Gộp bàn";
            btnGopBan.TextAlignment = StringAlignment.Center;
            btnGopBan.Click += btnGopBan_Click;
            // 
            // btnChuyenBan
            // 
            btnChuyenBan.BackColor = Color.Transparent;
            btnChuyenBan.BorderColor = Color.FromArgb(32, 34, 37);
            btnChuyenBan.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            btnChuyenBan.EnteredColor = Color.FromArgb(32, 34, 37);
            btnChuyenBan.Font = new Font("Microsoft Sans Serif", 9F);
            btnChuyenBan.Image = null;
            btnChuyenBan.ImageAlign = ContentAlignment.MiddleLeft;
            btnChuyenBan.InactiveColor = Color.FromArgb(32, 34, 37);
            btnChuyenBan.Location = new Point(13, 417);
            btnChuyenBan.Name = "btnChuyenBan";
            btnChuyenBan.PressedBorderColor = Color.FromArgb(165, 37, 37);
            btnChuyenBan.PressedColor = Color.FromArgb(165, 37, 37);
            btnChuyenBan.Size = new Size(71, 27);
            btnChuyenBan.TabIndex = 8;
            btnChuyenBan.Text = "Chuyển bàn";
            btnChuyenBan.TextAlignment = StringAlignment.Center;
            btnChuyenBan.Click += btnChuyenBan_Click;
            // 
            // cboBanDich
            // 
            cboBanDich.DrawMode = DrawMode.OwnerDrawFixed;
            cboBanDich.DropDownStyle = ComboBoxStyle.DropDownList;
            cboBanDich.EnabledCalc = true;
            cboBanDich.FormattingEnabled = true;
            cboBanDich.ItemHeight = 20;
            cboBanDich.Location = new Point(90, 385);
            cboBanDich.Name = "cboBanDich";
            cboBanDich.Size = new Size(71, 26);
            cboBanDich.TabIndex = 7;
            // 
            // cboBanDau
            // 
            cboBanDau.DrawMode = DrawMode.OwnerDrawFixed;
            cboBanDau.DropDownStyle = ComboBoxStyle.DropDownList;
            cboBanDau.EnabledCalc = true;
            cboBanDau.FormattingEnabled = true;
            cboBanDau.ItemHeight = 20;
            cboBanDau.Location = new Point(13, 385);
            cboBanDau.Name = "cboBanDau";
            cboBanDau.Size = new Size(71, 26);
            cboBanDau.TabIndex = 7;
            // 
            // dgvDanhSachThucUong
            // 
            dgvDanhSachThucUong.AllowUserToAddRows = false;
            dgvDanhSachThucUong.AllowUserToDeleteRows = false;
            dgvDanhSachThucUong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDanhSachThucUong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhSachThucUong.Columns.AddRange(new DataGridViewColumn[] { TenThucUong, SoLuong, ThanhTien });
            dgvDanhSachThucUong.GridColor = SystemColors.InactiveBorder;
            dgvDanhSachThucUong.Location = new Point(14, 162);
            dgvDanhSachThucUong.MultiSelect = false;
            dgvDanhSachThucUong.Name = "dgvDanhSachThucUong";
            dgvDanhSachThucUong.ReadOnly = true;
            dgvDanhSachThucUong.Size = new Size(444, 212);
            dgvDanhSachThucUong.TabIndex = 6;
            // 
            // TenThucUong
            // 
            TenThucUong.DataPropertyName = "TenThucUong";
            TenThucUong.HeaderText = "Tên thức uống";
            TenThucUong.Name = "TenThucUong";
            TenThucUong.ReadOnly = true;
            // 
            // SoLuong
            // 
            SoLuong.DataPropertyName = "SoLuong";
            SoLuong.HeaderText = "Số lượng";
            SoLuong.Name = "SoLuong";
            SoLuong.ReadOnly = true;
            // 
            // ThanhTien
            // 
            ThanhTien.DataPropertyName = "ThanhTien";
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            ThanhTien.DefaultCellStyle = dataGridViewCellStyle1;
            ThanhTien.HeaderText = "Đơn giá";
            ThanhTien.Name = "ThanhTien";
            ThanhTien.ReadOnly = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(287, 85);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 4;
            label4.Text = "Số lượng:";
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
            btnLuu.InactiveColor = Color.Blue;
            btnLuu.Location = new Point(405, 36);
            btnLuu.Name = "btnLuu";
            btnLuu.PressedBorderColor = Color.FromArgb(165, 37, 37);
            btnLuu.PressedColor = Color.FromArgb(165, 37, 37);
            btnLuu.Size = new Size(52, 26);
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
            btnXoa.InactiveColor = Color.FromArgb(192, 0, 0);
            btnXoa.Location = new Point(346, 36);
            btnXoa.Name = "btnXoa";
            btnXoa.PressedBorderColor = Color.FromArgb(165, 37, 37);
            btnXoa.PressedColor = Color.FromArgb(165, 37, 37);
            btnXoa.Size = new Size(52, 26);
            btnXoa.TabIndex = 3;
            btnXoa.Text = "Xóa";
            btnXoa.TextAlignment = StringAlignment.Center;
            btnXoa.Click += btnXoa_Click;
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
            btnThem.InactiveColor = Color.FromArgb(0, 192, 0);
            btnThem.Location = new Point(287, 36);
            btnThem.Name = "btnThem";
            btnThem.PressedBorderColor = Color.FromArgb(165, 37, 37);
            btnThem.PressedColor = Color.FromArgb(165, 37, 37);
            btnThem.Size = new Size(52, 26);
            btnThem.TabIndex = 3;
            btnThem.Text = "Thêm";
            btnThem.TextAlignment = StringAlignment.Center;
            btnThem.Click += btnThem_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(13, 125);
            label7.Name = "label7";
            label7.Size = new Size(41, 15);
            label7.TabIndex = 2;
            label7.Text = "Mô tả:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 85);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 2;
            label3.Text = "Thức uống:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 42);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 2;
            label2.Text = "Danh mục:";
            // 
            // cboThucUong
            // 
            cboThucUong.DrawMode = DrawMode.OwnerDrawFixed;
            cboThucUong.DropDownStyle = ComboBoxStyle.DropDownList;
            cboThucUong.EnabledCalc = true;
            cboThucUong.FormattingEnabled = true;
            cboThucUong.ItemHeight = 20;
            cboThucUong.Location = new Point(96, 79);
            cboThucUong.Name = "cboThucUong";
            cboThucUong.Size = new Size(176, 26);
            cboThucUong.TabIndex = 1;
            // 
            // cboDanhMuc
            // 
            cboDanhMuc.DrawMode = DrawMode.OwnerDrawFixed;
            cboDanhMuc.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDanhMuc.EnabledCalc = true;
            cboDanhMuc.FormattingEnabled = true;
            cboDanhMuc.ItemHeight = 20;
            cboDanhMuc.Location = new Point(96, 36);
            cboDanhMuc.Name = "cboDanhMuc";
            cboDanhMuc.Size = new Size(176, 26);
            cboDanhMuc.TabIndex = 1;
            cboDanhMuc.SelectedIndexChanged += cboDanhMuc_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(-858, -78);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // flpDanhSachBan
            // 
            flpDanhSachBan.Dock = DockStyle.Fill;
            flpDanhSachBan.Location = new Point(0, 0);
            flpDanhSachBan.Name = "flpDanhSachBan";
            flpDanhSachBan.Size = new Size(330, 450);
            flpDanhSachBan.TabIndex = 3;
            // 
            // frmChucNang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(flpDanhSachBan);
            Controls.Add(groupBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmChucNang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmChucNang";
            WindowState = FormWindowState.Maximized;
            Activated += frmChucNang_Activated;
            Load += frmChucNang_Load;
            groupBox.ResumeLayout(false);
            groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numGiamGia).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachThucUong).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox;
        private FlowLayoutPanel flpDanhSachBan;
        private Label label3;
        private Label label2;
        private ReaLTaiizor.Controls.AloneComboBox cboThucUong;
        private ReaLTaiizor.Controls.AloneComboBox cboDanhMuc;
        private Label label1;
        private ReaLTaiizor.Controls.Button btnXoa;
        private ReaLTaiizor.Controls.Button btnThem;
        private ReaLTaiizor.Controls.Button btnGopBan;
        private ReaLTaiizor.Controls.Button btnChuyenBan;
        private ReaLTaiizor.Controls.AloneComboBox cboBanDich;
        private ReaLTaiizor.Controls.AloneComboBox cboBanDau;
        private DataGridView dgvDanhSachThucUong;
        private Label label4;
        private ReaLTaiizor.Controls.AloneTextBox txtTongTien;
        private Label label6;
        private Label label5;
        private NumericUpDown numGiamGia;
        private ReaLTaiizor.Controls.Button btnTinhTien;
        private ReaLTaiizor.Controls.AloneTextBox txtMoTa;
        private ReaLTaiizor.Controls.HopeNumeric numSoLuong;
        private Label label7;
        private ReaLTaiizor.Controls.Button btnLuu;
        private DataGridViewTextBoxColumn TenThucUong;
        private DataGridViewTextBoxColumn SoLuong;
        private DataGridViewTextBoxColumn ThanhTien;
    }
}