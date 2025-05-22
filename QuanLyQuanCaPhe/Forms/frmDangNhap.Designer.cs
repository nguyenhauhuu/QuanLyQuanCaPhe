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
            btnHuyBo = new ReaLTaiizor.Controls.Button();
            btnDangNhap = new ReaLTaiizor.Controls.Button();
            txtMatKhau = new ReaLTaiizor.Controls.AloneTextBox();
            txtTenDangNhap = new ReaLTaiizor.Controls.AloneTextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnHuyBo);
            panel1.Controls.Add(btnDangNhap);
            panel1.Controls.Add(txtMatKhau);
            panel1.Controls.Add(txtTenDangNhap);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(684, 386);
            panel1.TabIndex = 9;
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
            btnHuyBo.Location = new Point(350, 238);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.PressedBorderColor = Color.FromArgb(165, 37, 37);
            btnHuyBo.PressedColor = Color.FromArgb(165, 37, 37);
            btnHuyBo.Size = new Size(120, 40);
            btnHuyBo.TabIndex = 14;
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
            btnDangNhap.InactiveColor = Color.Gray;
            btnDangNhap.Location = new Point(214, 238);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.PressedBorderColor = Color.FromArgb(165, 37, 37);
            btnDangNhap.PressedColor = Color.FromArgb(165, 37, 37);
            btnDangNhap.Size = new Size(120, 40);
            btnDangNhap.TabIndex = 15;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.TextAlignment = StringAlignment.Center;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // txtMatKhau
            // 
            txtMatKhau.BackColor = Color.Transparent;
            txtMatKhau.EnabledCalc = true;
            txtMatKhau.Font = new Font("Segoe UI", 9F);
            txtMatKhau.ForeColor = Color.FromArgb(124, 133, 142);
            txtMatKhau.Location = new Point(221, 180);
            txtMatKhau.MaxLength = 32767;
            txtMatKhau.MultiLine = false;
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.ReadOnly = false;
            txtMatKhau.Size = new Size(249, 29);
            txtMatKhau.TabIndex = 13;
            txtMatKhau.TextAlign = HorizontalAlignment.Left;
            txtMatKhau.UseSystemPasswordChar = false;
            txtMatKhau.KeyDown += txtMatKhau_KeyDown;
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.BackColor = Color.Transparent;
            txtTenDangNhap.EnabledCalc = true;
            txtTenDangNhap.Font = new Font("Segoe UI", 9F);
            txtTenDangNhap.ForeColor = Color.FromArgb(124, 133, 142);
            txtTenDangNhap.Location = new Point(221, 124);
            txtTenDangNhap.MaxLength = 32767;
            txtTenDangNhap.MultiLine = false;
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.ReadOnly = false;
            txtTenDangNhap.Size = new Size(249, 29);
            txtTenDangNhap.TabIndex = 12;
            txtTenDangNhap.TextAlign = HorizontalAlignment.Left;
            txtTenDangNhap.UseSystemPasswordChar = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(214, 162);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 10;
            label3.Text = "Mật khẩu:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(214, 106);
            label2.Name = "label2";
            label2.Size = new Size(88, 15);
            label2.TabIndex = 11;
            label2.Text = "Tên đăng nhập:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.System;
            label1.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(288, 65);
            label1.Name = "label1";
            label1.Size = new Size(116, 25);
            label1.TabIndex = 9;
            label1.Text = "ĐĂNG NHẬP";
            // 
            // frmDangNhap
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 386);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmDangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmDangNhap";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ReaLTaiizor.Controls.Button btnHuyBo;
        private ReaLTaiizor.Controls.Button btnDangNhap;
        public ReaLTaiizor.Controls.AloneTextBox txtMatKhau;
        public ReaLTaiizor.Controls.AloneTextBox txtTenDangNhap;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}