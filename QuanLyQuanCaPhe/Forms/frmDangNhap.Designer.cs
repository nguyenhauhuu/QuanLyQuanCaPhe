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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtTenDangNhap = new ReaLTaiizor.Controls.AloneTextBox();
            txtMatKhau = new ReaLTaiizor.Controls.AloneTextBox();
            btnDangNhap = new ReaLTaiizor.Controls.Button();
            btnHuyBo = new ReaLTaiizor.Controls.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.System;
            label1.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(306, 44);
            label1.Name = "label1";
            label1.Size = new Size(116, 25);
            label1.TabIndex = 0;
            label1.Text = "ĐĂNG NHẬP";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(232, 85);
            label2.Name = "label2";
            label2.Size = new Size(88, 15);
            label2.TabIndex = 1;
            label2.Text = "Tên đăng nhập:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(232, 141);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 1;
            label3.Text = "Mật khẩu:";
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.BackColor = Color.Transparent;
            txtTenDangNhap.EnabledCalc = true;
            txtTenDangNhap.Font = new Font("Segoe UI", 9F);
            txtTenDangNhap.ForeColor = Color.FromArgb(124, 133, 142);
            txtTenDangNhap.Location = new Point(239, 103);
            txtTenDangNhap.MaxLength = 32767;
            txtTenDangNhap.MultiLine = false;
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.ReadOnly = false;
            txtTenDangNhap.Size = new Size(249, 29);
            txtTenDangNhap.TabIndex = 5;
            txtTenDangNhap.TextAlign = HorizontalAlignment.Left;
            txtTenDangNhap.UseSystemPasswordChar = false;
            // 
            // txtMatKhau
            // 
            txtMatKhau.BackColor = Color.Transparent;
            txtMatKhau.EnabledCalc = true;
            txtMatKhau.Font = new Font("Segoe UI", 9F);
            txtMatKhau.ForeColor = Color.FromArgb(124, 133, 142);
            txtMatKhau.Location = new Point(239, 159);
            txtMatKhau.MaxLength = 32767;
            txtMatKhau.MultiLine = false;
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.ReadOnly = false;
            txtMatKhau.Size = new Size(249, 29);
            txtMatKhau.TabIndex = 6;
            txtMatKhau.TextAlign = HorizontalAlignment.Left;
            txtMatKhau.UseSystemPasswordChar = false;
            txtMatKhau.KeyDown += txtMatKhau_KeyDown;
            // 
            // btnDangNhap
            // 
            btnDangNhap.BackColor = Color.Transparent;
            btnDangNhap.BorderColor = Color.FromArgb(32, 34, 37);
            btnDangNhap.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            btnDangNhap.EnteredColor = Color.FromArgb(32, 34, 37);
            btnDangNhap.Font = new Font("Microsoft Sans Serif", 12F);
            btnDangNhap.Image = null;
            btnDangNhap.ImageAlign = ContentAlignment.MiddleLeft;
            btnDangNhap.InactiveColor = Color.FromArgb(32, 34, 37);
            btnDangNhap.Location = new Point(232, 217);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.PressedBorderColor = Color.FromArgb(165, 37, 37);
            btnDangNhap.PressedColor = Color.FromArgb(165, 37, 37);
            btnDangNhap.Size = new Size(120, 40);
            btnDangNhap.TabIndex = 8;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.TextAlignment = StringAlignment.Center;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.BackColor = Color.Transparent;
            btnHuyBo.BorderColor = Color.FromArgb(32, 34, 37);
            btnHuyBo.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            btnHuyBo.EnteredColor = Color.FromArgb(32, 34, 37);
            btnHuyBo.Font = new Font("Microsoft Sans Serif", 12F);
            btnHuyBo.Image = null;
            btnHuyBo.ImageAlign = ContentAlignment.MiddleLeft;
            btnHuyBo.InactiveColor = Color.FromArgb(32, 34, 37);
            btnHuyBo.Location = new Point(368, 217);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.PressedBorderColor = Color.FromArgb(165, 37, 37);
            btnHuyBo.PressedColor = Color.FromArgb(165, 37, 37);
            btnHuyBo.Size = new Size(120, 40);
            btnHuyBo.TabIndex = 8;
            btnHuyBo.Text = "Hủy bỏ";
            btnHuyBo.TextAlignment = StringAlignment.Center;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // frmDangNhap
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnHuyBo);
            Controls.Add(btnDangNhap);
            Controls.Add(txtMatKhau);
            Controls.Add(txtTenDangNhap);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmDangNhap";
            Text = "frmDangNhap";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        public ReaLTaiizor.Controls.AloneTextBox txtTenDangNhap;
        public ReaLTaiizor.Controls.AloneTextBox txtMatKhau;
        private ReaLTaiizor.Controls.Button btnDangNhap;
        private ReaLTaiizor.Controls.Button btnHuyBo;
    }
}