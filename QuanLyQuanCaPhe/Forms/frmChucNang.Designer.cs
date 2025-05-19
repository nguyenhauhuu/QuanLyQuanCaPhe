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
            groupBox = new GroupBox();
            btnTinhTien = new ReaLTaiizor.Controls.Button();
            txtTongTien = new ReaLTaiizor.Controls.AloneTextBox();
            label6 = new Label();
            label5 = new Label();
            numGiamGia = new NumericUpDown();
            btnGopBan = new ReaLTaiizor.Controls.Button();
            btnChuyenBan = new ReaLTaiizor.Controls.Button();
            aloneComboBox4 = new ReaLTaiizor.Controls.AloneComboBox();
            aloneComboBox3 = new ReaLTaiizor.Controls.AloneComboBox();
            dataGridView1 = new DataGridView();
            numSoLuong = new NumericUpDown();
            label4 = new Label();
            button2 = new ReaLTaiizor.Controls.Button();
            button1 = new ReaLTaiizor.Controls.Button();
            label3 = new Label();
            label2 = new Label();
            aloneComboBox2 = new ReaLTaiizor.Controls.AloneComboBox();
            aloneComboBox1 = new ReaLTaiizor.Controls.AloneComboBox();
            label1 = new Label();
            flpDanhSachBan = new FlowLayoutPanel();
            groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numGiamGia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).BeginInit();
            SuspendLayout();
            // 
            // groupBox
            // 
            groupBox.Controls.Add(btnTinhTien);
            groupBox.Controls.Add(txtTongTien);
            groupBox.Controls.Add(label6);
            groupBox.Controls.Add(label5);
            groupBox.Controls.Add(numGiamGia);
            groupBox.Controls.Add(btnGopBan);
            groupBox.Controls.Add(btnChuyenBan);
            groupBox.Controls.Add(aloneComboBox4);
            groupBox.Controls.Add(aloneComboBox3);
            groupBox.Controls.Add(dataGridView1);
            groupBox.Controls.Add(numSoLuong);
            groupBox.Controls.Add(label4);
            groupBox.Controls.Add(button2);
            groupBox.Controls.Add(button1);
            groupBox.Controls.Add(label3);
            groupBox.Controls.Add(label2);
            groupBox.Controls.Add(aloneComboBox2);
            groupBox.Controls.Add(aloneComboBox1);
            groupBox.Controls.Add(label1);
            groupBox.Dock = DockStyle.Right;
            groupBox.Location = new Point(330, 0);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(470, 450);
            groupBox.TabIndex = 2;
            groupBox.TabStop = false;
            groupBox.Text = "Bàn";
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
            // 
            // aloneComboBox4
            // 
            aloneComboBox4.DrawMode = DrawMode.OwnerDrawFixed;
            aloneComboBox4.DropDownStyle = ComboBoxStyle.DropDownList;
            aloneComboBox4.EnabledCalc = true;
            aloneComboBox4.FormattingEnabled = true;
            aloneComboBox4.ItemHeight = 20;
            aloneComboBox4.Location = new Point(90, 385);
            aloneComboBox4.Name = "aloneComboBox4";
            aloneComboBox4.Size = new Size(71, 26);
            aloneComboBox4.TabIndex = 7;
            // 
            // aloneComboBox3
            // 
            aloneComboBox3.DrawMode = DrawMode.OwnerDrawFixed;
            aloneComboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            aloneComboBox3.EnabledCalc = true;
            aloneComboBox3.FormattingEnabled = true;
            aloneComboBox3.ItemHeight = 20;
            aloneComboBox3.Location = new Point(13, 385);
            aloneComboBox3.Name = "aloneComboBox3";
            aloneComboBox3.Size = new Size(71, 26);
            aloneComboBox3.TabIndex = 7;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(14, 124);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(444, 250);
            dataGridView1.TabIndex = 6;
            // 
            // numSoLuong
            // 
            numSoLuong.Location = new Point(358, 80);
            numSoLuong.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numSoLuong.Name = "numSoLuong";
            numSoLuong.Size = new Size(77, 23);
            numSoLuong.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(295, 84);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 4;
            label4.Text = "Số lượng:";
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.BorderColor = Color.FromArgb(32, 34, 37);
            button2.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            button2.EnteredColor = Color.FromArgb(32, 34, 37);
            button2.Font = new Font("Microsoft Sans Serif", 12F);
            button2.Image = null;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.InactiveColor = Color.FromArgb(192, 0, 0);
            button2.Location = new Point(364, 36);
            button2.Name = "button2";
            button2.PressedBorderColor = Color.FromArgb(165, 37, 37);
            button2.PressedColor = Color.FromArgb(165, 37, 37);
            button2.Size = new Size(60, 26);
            button2.TabIndex = 3;
            button2.Text = "Xóa";
            button2.TextAlignment = StringAlignment.Center;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BorderColor = Color.FromArgb(32, 34, 37);
            button1.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            button1.EnteredColor = Color.FromArgb(32, 34, 37);
            button1.Font = new Font("Microsoft Sans Serif", 12F);
            button1.Image = null;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.InactiveColor = Color.FromArgb(0, 192, 0);
            button1.Location = new Point(292, 36);
            button1.Name = "button1";
            button1.PressedBorderColor = Color.FromArgb(165, 37, 37);
            button1.PressedColor = Color.FromArgb(165, 37, 37);
            button1.Size = new Size(60, 26);
            button1.TabIndex = 3;
            button1.Text = "Thêm";
            button1.TextAlignment = StringAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 85);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
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
            // aloneComboBox2
            // 
            aloneComboBox2.DrawMode = DrawMode.OwnerDrawFixed;
            aloneComboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            aloneComboBox2.EnabledCalc = true;
            aloneComboBox2.FormattingEnabled = true;
            aloneComboBox2.ItemHeight = 20;
            aloneComboBox2.Location = new Point(96, 79);
            aloneComboBox2.Name = "aloneComboBox2";
            aloneComboBox2.Size = new Size(176, 26);
            aloneComboBox2.TabIndex = 1;
            // 
            // aloneComboBox1
            // 
            aloneComboBox1.DrawMode = DrawMode.OwnerDrawFixed;
            aloneComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            aloneComboBox1.EnabledCalc = true;
            aloneComboBox1.FormattingEnabled = true;
            aloneComboBox1.ItemHeight = 20;
            aloneComboBox1.Location = new Point(96, 36);
            aloneComboBox1.Name = "aloneComboBox1";
            aloneComboBox1.Size = new Size(176, 26);
            aloneComboBox1.TabIndex = 1;
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
            Name = "frmChucNang";
            Text = "frmChucNang";
            Load += frmChucNang_Load;
            groupBox.ResumeLayout(false);
            groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numGiamGia).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox;
        private FlowLayoutPanel flpDanhSachBan;
        private Label label3;
        private Label label2;
        private ReaLTaiizor.Controls.AloneComboBox aloneComboBox2;
        private ReaLTaiizor.Controls.AloneComboBox aloneComboBox1;
        private Label label1;
        private ReaLTaiizor.Controls.Button button2;
        private ReaLTaiizor.Controls.Button button1;
        private ReaLTaiizor.Controls.Button btnGopBan;
        private ReaLTaiizor.Controls.Button btnChuyenBan;
        private ReaLTaiizor.Controls.AloneComboBox aloneComboBox4;
        private ReaLTaiizor.Controls.AloneComboBox aloneComboBox3;
        private DataGridView dataGridView1;
        private NumericUpDown numSoLuong;
        private Label label4;
        private ReaLTaiizor.Controls.AloneTextBox txtTongTien;
        private Label label6;
        private Label label5;
        private NumericUpDown numGiamGia;
        private ReaLTaiizor.Controls.Button btnTinhTien;
    }
}