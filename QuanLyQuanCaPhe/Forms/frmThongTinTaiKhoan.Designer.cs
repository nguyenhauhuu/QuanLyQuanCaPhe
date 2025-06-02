namespace QuanLyQuanCaPhe.Forms
{
    partial class frmThongTinTaiKhoan
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
            grpDoiMatKhau = new GroupBox();
            btnCapNhatMatKhau = new Button();
            txtXacNhanMatKhau = new TextBox();
            label5 = new Label();
            txtMatKhauMoi = new TextBox();
            label4 = new Label();
            txtMatKhauHienTai = new TextBox();
            label3 = new Label();
            btnLuu = new Button();
            btnSua = new Button();
            dtpNgaySinh = new DateTimePicker();
            label2 = new Label();
            txtTenDayDu = new TextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            picHinhAnh = new PictureBox();
            helpProvider1 = new HelpProvider();
            grpDoiMatKhau.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picHinhAnh).BeginInit();
            SuspendLayout();
            // 
            // grpDoiMatKhau
            // 
            grpDoiMatKhau.Controls.Add(btnCapNhatMatKhau);
            grpDoiMatKhau.Controls.Add(txtXacNhanMatKhau);
            grpDoiMatKhau.Controls.Add(label5);
            grpDoiMatKhau.Controls.Add(txtMatKhauMoi);
            grpDoiMatKhau.Controls.Add(label4);
            grpDoiMatKhau.Controls.Add(txtMatKhauHienTai);
            grpDoiMatKhau.Controls.Add(label3);
            grpDoiMatKhau.Location = new Point(93, 314);
            grpDoiMatKhau.Name = "grpDoiMatKhau";
            grpDoiMatKhau.Size = new Size(562, 177);
            grpDoiMatKhau.TabIndex = 7;
            grpDoiMatKhau.TabStop = false;
            grpDoiMatKhau.Text = "Đổi mật khẩu";
            // 
            // btnCapNhatMatKhau
            // 
            btnCapNhatMatKhau.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCapNhatMatKhau.Location = new Point(419, 22);
            btnCapNhatMatKhau.Name = "btnCapNhatMatKhau";
            btnCapNhatMatKhau.Size = new Size(137, 129);
            btnCapNhatMatKhau.TabIndex = 6;
            btnCapNhatMatKhau.Text = "Cập nhật mật khẩu";
            btnCapNhatMatKhau.UseVisualStyleBackColor = true;
            btnCapNhatMatKhau.Click += btnCapNhatMatKhau_Click;
            // 
            // txtXacNhanMatKhau
            // 
            txtXacNhanMatKhau.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtXacNhanMatKhau.Location = new Point(185, 118);
            txtXacNhanMatKhau.Name = "txtXacNhanMatKhau";
            txtXacNhanMatKhau.PasswordChar = '⚫';
            txtXacNhanMatKhau.Size = new Size(228, 33);
            txtXacNhanMatKhau.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(4, 122);
            label5.Name = "label5";
            label5.Size = new Size(177, 25);
            label5.TabIndex = 4;
            label5.Text = "Xác nhận mật khẩu:";
            // 
            // txtMatKhauMoi
            // 
            txtMatKhauMoi.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMatKhauMoi.Location = new Point(185, 70);
            txtMatKhauMoi.Name = "txtMatKhauMoi";
            txtMatKhauMoi.PasswordChar = '⚫';
            txtMatKhauMoi.Size = new Size(228, 33);
            txtMatKhauMoi.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(4, 74);
            label4.Name = "label4";
            label4.Size = new Size(132, 25);
            label4.TabIndex = 2;
            label4.Text = "Mật khẩu mới:";
            // 
            // txtMatKhauHienTai
            // 
            txtMatKhauHienTai.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMatKhauHienTai.Location = new Point(185, 22);
            txtMatKhauHienTai.Name = "txtMatKhauHienTai";
            txtMatKhauHienTai.PasswordChar = '⚫';
            txtMatKhauHienTai.Size = new Size(228, 33);
            txtMatKhauHienTai.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(4, 26);
            label3.Name = "label3";
            label3.Size = new Size(163, 25);
            label3.TabIndex = 0;
            label3.Text = "Mật khẩu hiện tại:";
            // 
            // btnLuu
            // 
            btnLuu.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLuu.Location = new Point(492, 221);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(163, 70);
            btnLuu.TabIndex = 6;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnSua
            // 
            btnSua.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSua.Location = new Point(314, 221);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(153, 70);
            btnSua.TabIndex = 5;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            dtpNgaySinh.Font = new Font("Segoe UI", 14F);
            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpNgaySinh.Location = new Point(427, 159);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(228, 32);
            dtpNgaySinh.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(314, 163);
            label2.Name = "label2";
            label2.Size = new Size(100, 25);
            label2.TabIndex = 3;
            label2.Text = "Ngày sinh:";
            // 
            // txtTenDayDu
            // 
            txtTenDayDu.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTenDayDu.Location = new Point(427, 94);
            txtTenDayDu.Name = "txtTenDayDu";
            txtTenDayDu.Size = new Size(228, 33);
            txtTenDayDu.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(314, 98);
            label1.Name = "label1";
            label1.Size = new Size(107, 25);
            label1.TabIndex = 1;
            label1.Text = "Tên đầy đủ:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(picHinhAnh);
            groupBox1.Location = new Point(90, 52);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 242);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Hình ảnh";
            // 
            // picHinhAnh
            // 
            picHinhAnh.Dock = DockStyle.Fill;
            picHinhAnh.Location = new Point(3, 19);
            picHinhAnh.Name = "picHinhAnh";
            picHinhAnh.Size = new Size(194, 220);
            picHinhAnh.SizeMode = PictureBoxSizeMode.StretchImage;
            picHinhAnh.TabIndex = 0;
            picHinhAnh.TabStop = false;
            // 
            // frmThongTinTaiKhoan
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(755, 539);
            Controls.Add(grpDoiMatKhau);
            Controls.Add(btnLuu);
            Controls.Add(btnSua);
            Controls.Add(dtpNgaySinh);
            Controls.Add(label2);
            Controls.Add(txtTenDayDu);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmThongTinTaiKhoan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "x";
            Load += frmThongTinTaiKhoan_Load;
            grpDoiMatKhau.ResumeLayout(false);
            grpDoiMatKhau.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picHinhAnh).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpDoiMatKhau;
        private Button btnCapNhatMatKhau;
        private TextBox txtXacNhanMatKhau;
        private Label label5;
        private TextBox txtMatKhauMoi;
        private Label label4;
        private TextBox txtMatKhauHienTai;
        private Label label3;
        private Button btnLuu;
        private Button btnSua;
        private DateTimePicker dtpNgaySinh;
        private Label label2;
        private TextBox txtTenDayDu;
        private Label label1;
        private GroupBox groupBox1;
        private PictureBox picHinhAnh;
        private HelpProvider helpProvider1;
    }
}