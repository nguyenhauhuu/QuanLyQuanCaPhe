namespace QuanLyQuanCaPhe.Forms
{
    partial class Form1
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
            panel1 = new Panel();
            btnDangXuat = new Button();
            btnDangNhap = new Button();
            btnThongKeThucUong = new Button();
            btnThongKeDoanhThu = new Button();
            btnBanNuoc = new Button();
            btnTaiKhoan = new Button();
            btnThucUong = new Button();
            btnDanhMuc = new Button();
            btnBan = new Button();
            panel2 = new Panel();
            lblTenDayDu = new Label();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            lblTitle = new ReaLTaiizor.Controls.SkyLabel();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            lblLienKet = new ToolStripStatusLabel();
            pnlFormLoader = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(btnDangXuat);
            panel1.Controls.Add(btnDangNhap);
            panel1.Controls.Add(btnThongKeThucUong);
            panel1.Controls.Add(btnThongKeDoanhThu);
            panel1.Controls.Add(btnBanNuoc);
            panel1.Controls.Add(btnTaiKhoan);
            panel1.Controls.Add(btnThucUong);
            panel1.Controls.Add(btnDanhMuc);
            panel1.Controls.Add(btnBan);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.ForeColor = SystemColors.ControlText;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(266, 962);
            panel1.TabIndex = 0;
            // 
            // btnDangXuat
            // 
            btnDangXuat.BackColor = SystemColors.Info;
            btnDangXuat.Dock = DockStyle.Bottom;
            btnDangXuat.FlatAppearance.BorderSize = 0;
            btnDangXuat.FlatStyle = FlatStyle.Flat;
            btnDangXuat.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDangXuat.Location = new Point(0, 822);
            btnDangXuat.Margin = new Padding(4, 5, 4, 5);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Size = new Size(266, 70);
            btnDangXuat.TabIndex = 10;
            btnDangXuat.Text = "ĐĂNG XUẤT";
            btnDangXuat.UseVisualStyleBackColor = false;
            btnDangXuat.Click += btnDangXuat_Click;
            // 
            // btnDangNhap
            // 
            btnDangNhap.BackColor = SystemColors.Info;
            btnDangNhap.Dock = DockStyle.Bottom;
            btnDangNhap.FlatAppearance.BorderSize = 0;
            btnDangNhap.FlatStyle = FlatStyle.Flat;
            btnDangNhap.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDangNhap.Location = new Point(0, 892);
            btnDangNhap.Margin = new Padding(4, 5, 4, 5);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(266, 70);
            btnDangNhap.TabIndex = 9;
            btnDangNhap.Text = "ĐĂNG NHẬP";
            btnDangNhap.UseVisualStyleBackColor = false;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // btnThongKeThucUong
            // 
            btnThongKeThucUong.Dock = DockStyle.Top;
            btnThongKeThucUong.FlatAppearance.BorderSize = 0;
            btnThongKeThucUong.FlatStyle = FlatStyle.Flat;
            btnThongKeThucUong.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThongKeThucUong.Location = new Point(0, 660);
            btnThongKeThucUong.Margin = new Padding(4, 5, 4, 5);
            btnThongKeThucUong.Name = "btnThongKeThucUong";
            btnThongKeThucUong.Size = new Size(266, 70);
            btnThongKeThucUong.TabIndex = 8;
            btnThongKeThucUong.Text = "Thống kê thức uống";
            btnThongKeThucUong.UseVisualStyleBackColor = true;
            btnThongKeThucUong.Click += btnThongKeThucUong_Click;
            // 
            // btnThongKeDoanhThu
            // 
            btnThongKeDoanhThu.Dock = DockStyle.Top;
            btnThongKeDoanhThu.FlatAppearance.BorderSize = 0;
            btnThongKeDoanhThu.FlatStyle = FlatStyle.Flat;
            btnThongKeDoanhThu.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThongKeDoanhThu.Location = new Point(0, 590);
            btnThongKeDoanhThu.Margin = new Padding(4, 5, 4, 5);
            btnThongKeDoanhThu.Name = "btnThongKeDoanhThu";
            btnThongKeDoanhThu.Size = new Size(266, 70);
            btnThongKeDoanhThu.TabIndex = 7;
            btnThongKeDoanhThu.Text = "Thống kê doanh thu";
            btnThongKeDoanhThu.UseVisualStyleBackColor = true;
            btnThongKeDoanhThu.Click += btnThongKeDoanhThu_Click;
            // 
            // btnBanNuoc
            // 
            btnBanNuoc.Dock = DockStyle.Top;
            btnBanNuoc.FlatAppearance.BorderSize = 0;
            btnBanNuoc.FlatStyle = FlatStyle.Flat;
            btnBanNuoc.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBanNuoc.Location = new Point(0, 520);
            btnBanNuoc.Margin = new Padding(4, 5, 4, 5);
            btnBanNuoc.Name = "btnBanNuoc";
            btnBanNuoc.Size = new Size(266, 70);
            btnBanNuoc.TabIndex = 6;
            btnBanNuoc.Text = "Bán nước";
            btnBanNuoc.UseVisualStyleBackColor = true;
            btnBanNuoc.Click += btnBanNuoc_Click;
            // 
            // btnTaiKhoan
            // 
            btnTaiKhoan.Dock = DockStyle.Top;
            btnTaiKhoan.FlatAppearance.BorderSize = 0;
            btnTaiKhoan.FlatStyle = FlatStyle.Flat;
            btnTaiKhoan.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTaiKhoan.Location = new Point(0, 450);
            btnTaiKhoan.Margin = new Padding(4, 5, 4, 5);
            btnTaiKhoan.Name = "btnTaiKhoan";
            btnTaiKhoan.Size = new Size(266, 70);
            btnTaiKhoan.TabIndex = 5;
            btnTaiKhoan.Text = "Quản lý tài khoản";
            btnTaiKhoan.UseVisualStyleBackColor = true;
            btnTaiKhoan.Click += btnTaiKhoan_Click;
            // 
            // btnThucUong
            // 
            btnThucUong.Dock = DockStyle.Top;
            btnThucUong.FlatAppearance.BorderSize = 0;
            btnThucUong.FlatStyle = FlatStyle.Flat;
            btnThucUong.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThucUong.Location = new Point(0, 380);
            btnThucUong.Margin = new Padding(4, 5, 4, 5);
            btnThucUong.Name = "btnThucUong";
            btnThucUong.Size = new Size(266, 70);
            btnThucUong.TabIndex = 4;
            btnThucUong.Text = "Quản lý thức uống";
            btnThucUong.UseVisualStyleBackColor = true;
            btnThucUong.Click += btnThucUong_Click;
            // 
            // btnDanhMuc
            // 
            btnDanhMuc.Dock = DockStyle.Top;
            btnDanhMuc.FlatAppearance.BorderSize = 0;
            btnDanhMuc.FlatStyle = FlatStyle.Flat;
            btnDanhMuc.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDanhMuc.Location = new Point(0, 310);
            btnDanhMuc.Margin = new Padding(4, 5, 4, 5);
            btnDanhMuc.Name = "btnDanhMuc";
            btnDanhMuc.Size = new Size(266, 70);
            btnDanhMuc.TabIndex = 3;
            btnDanhMuc.Text = "Quản lý danh mục";
            btnDanhMuc.UseVisualStyleBackColor = true;
            btnDanhMuc.Click += btnDanhMuc_Click;
            // 
            // btnBan
            // 
            btnBan.Dock = DockStyle.Top;
            btnBan.FlatAppearance.BorderSize = 0;
            btnBan.FlatStyle = FlatStyle.Flat;
            btnBan.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBan.Location = new Point(0, 240);
            btnBan.Margin = new Padding(4, 5, 4, 5);
            btnBan.Name = "btnBan";
            btnBan.Size = new Size(266, 70);
            btnBan.TabIndex = 2;
            btnBan.Text = "Quản lý bàn";
            btnBan.UseVisualStyleBackColor = true;
            btnBan.Click += btnBan_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblTenDayDu);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(266, 240);
            panel2.TabIndex = 0;
            // 
            // lblTenDayDu
            // 
            lblTenDayDu.AutoSize = true;
            lblTenDayDu.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTenDayDu.Location = new Point(70, 163);
            lblTenDayDu.Margin = new Padding(4, 0, 4, 0);
            lblTenDayDu.Name = "lblTenDayDu";
            lblTenDayDu.Size = new Size(119, 25);
            lblTenDayDu.TabIndex = 1;
            lblTenDayDu.Text = "User Name";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(86, 37);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(90, 105);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(lblTitle);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(266, 0);
            panel3.Margin = new Padding(4, 5, 4, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(1093, 99);
            panel3.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Verdana", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Black;
            lblTitle.Location = new Point(54, 23);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(190, 49);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Tiêu đề";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(24, 24);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel2, lblLienKet });
            statusStrip1.Location = new Point(266, 930);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 20, 0);
            statusStrip1.Size = new Size(1093, 32);
            statusStrip1.TabIndex = 4;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(962, 25);
            toolStripStatusLabel2.Spring = true;
            // 
            // lblLienKet
            // 
            lblLienKet.IsLink = true;
            lblLienKet.Name = "lblLienKet";
            lblLienKet.Size = new Size(110, 25);
            lblLienKet.Text = "©Hữu Đang";
            // 
            // pnlFormLoader
            // 
            pnlFormLoader.Dock = DockStyle.Fill;
            pnlFormLoader.Location = new Point(266, 99);
            pnlFormLoader.Margin = new Padding(4, 5, 4, 5);
            pnlFormLoader.Name = "pnlFormLoader";
            pnlFormLoader.Size = new Size(1093, 831);
            pnlFormLoader.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1359, 962);
            Controls.Add(pnlFormLoader);
            Controls.Add(statusStrip1);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label lblTenDayDu;
        private Button btnBanNuoc;
        private Button btnTaiKhoan;
        private Button btnThucUong;
        private Button btnDanhMuc;
        private Button btnBan;
        private Panel panel3;
        private ReaLTaiizor.Controls.SkyLabel lblTitle;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripStatusLabel lblLienKet;
        private Panel pnlFormLoader;
        private Button btnThongKeThucUong;
        private Button btnThongKeDoanhThu;
        private Button btnDangNhap;
        private Button btnDangXuat;
    }
}