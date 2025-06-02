namespace QuanLyQuanCaPhe.Forms
{
    partial class frmDangNhap
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
            chkHienMatKhau = new CheckBox();
            txtMatKhau = new TextBox();
            txtTenDangNhap = new TextBox();
            btnHuyBo = new ReaLTaiizor.Controls.Button();
            btnDangNhap = new ReaLTaiizor.Controls.Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            helpProvider1 = new HelpProvider();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(chkHienMatKhau);
            panel1.Controls.Add(txtMatKhau);
            panel1.Controls.Add(txtTenDangNhap);
            panel1.Controls.Add(btnHuyBo);
            panel1.Controls.Add(btnDangNhap);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(684, 386);
            panel1.TabIndex = 0;
            // 
            // chkHienMatKhau
            // 
            chkHienMatKhau.AutoSize = true;
            chkHienMatKhau.Location = new Point(341, 209);
            chkHienMatKhau.Name = "chkHienMatKhau";
            chkHienMatKhau.Size = new Size(104, 19);
            chkHienMatKhau.TabIndex = 5;
            chkHienMatKhau.Text = "Hiện mật khẩu";
            chkHienMatKhau.UseVisualStyleBackColor = true;
            chkHienMatKhau.CheckedChanged += chkHienMatKhau_CheckedChanged;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(214, 180);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '⚫';
            txtMatKhau.Size = new Size(230, 23);
            txtMatKhau.TabIndex = 4;
            txtMatKhau.KeyDown += txtMatKhau_KeyDown;
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Location = new Point(214, 124);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(230, 23);
            txtTenDangNhap.TabIndex = 2;
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
            btnHuyBo.Location = new Point(341, 238);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.PressedBorderColor = Color.FromArgb(165, 37, 37);
            btnHuyBo.PressedColor = Color.FromArgb(165, 37, 37);
            btnHuyBo.Size = new Size(103, 40);
            btnHuyBo.TabIndex = 7;
            btnHuyBo.Text = "Hủy bỏ";
            btnHuyBo.TextAlignment = StringAlignment.Center;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnDangNhap
            // 
            btnDangNhap.BackColor = Color.Transparent;
            btnDangNhap.BorderColor = Color.FromArgb(32, 34, 37);
            btnDangNhap.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            btnDangNhap.EnteredColor = Color.Black;
            btnDangNhap.Font = new Font("Microsoft Sans Serif", 12F);
            btnDangNhap.Image = null;
            btnDangNhap.ImageAlign = ContentAlignment.MiddleLeft;
            btnDangNhap.InactiveColor = Color.Black;
            btnDangNhap.Location = new Point(214, 238);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.PressedBorderColor = Color.FromArgb(165, 37, 37);
            btnDangNhap.PressedColor = Color.FromArgb(165, 37, 37);
            btnDangNhap.Size = new Size(103, 40);
            btnDangNhap.TabIndex = 6;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.TextAlignment = StringAlignment.Center;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(214, 162);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 3;
            label3.Text = "Mật khẩu:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(214, 106);
            label2.Name = "label2";
            label2.Size = new Size(88, 15);
            label2.TabIndex = 1;
            label2.Text = "Tên đăng nhập:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.System;
            label1.Font = new Font("Arial Narrow", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(232, 28);
            label1.Name = "label1";
            label1.Size = new Size(198, 42);
            label1.TabIndex = 0;
            label1.Text = "ĐĂNG NHẬP";
            // 
            // frmDangNhap
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 386);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmDangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private Label label2;
        private Label label1;
        public TextBox txtMatKhau;
        public TextBox txtTenDangNhap;
        private ReaLTaiizor.Controls.Button btnHuyBo;
        private ReaLTaiizor.Controls.Button btnDangNhap;
        private HelpProvider helpProvider1;
        private CheckBox chkHienMatKhau;
    }
}