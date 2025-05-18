namespace QuanLyQuanCaPhe
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            mnuQuanLy = new ToolStripMenuItem();
            mnuDoanhThu = new ToolStripMenuItem();
            mnuChiTieu = new ToolStripMenuItem();
            mnuThongKe = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            mnuBan = new ToolStripMenuItem();
            mnuDanhMuc = new ToolStripMenuItem();
            mnuThucUong = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            mnuNguyenLieu = new ToolStripMenuItem();
            mnuKho = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            mnuTaiKhoan = new ToolStripMenuItem();
            mnuChucNang = new ToolStripMenuItem();
            mnuThongTinTaiKhoan = new ToolStripMenuItem();
            mnuDangNhap = new ToolStripMenuItem();
            mnuDangXuat = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            lblTrangThai = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            lblLienKet = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuQuanLy, mnuChucNang, mnuThongTinTaiKhoan, mnuDangNhap, mnuDangXuat });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnuQuanLy
            // 
            mnuQuanLy.DropDownItems.AddRange(new ToolStripItem[] { mnuDoanhThu, mnuChiTieu, mnuThongKe, toolStripSeparator1, mnuBan, mnuDanhMuc, mnuThucUong, toolStripSeparator2, mnuNguyenLieu, mnuKho, toolStripSeparator3, mnuTaiKhoan });
            mnuQuanLy.Name = "mnuQuanLy";
            mnuQuanLy.Size = new Size(60, 20);
            mnuQuanLy.Text = "Quản lý";
            // 
            // mnuDoanhThu
            // 
            mnuDoanhThu.Name = "mnuDoanhThu";
            mnuDoanhThu.Size = new Size(138, 22);
            mnuDoanhThu.Text = "Doanh Thu";
            // 
            // mnuChiTieu
            // 
            mnuChiTieu.Name = "mnuChiTieu";
            mnuChiTieu.Size = new Size(138, 22);
            mnuChiTieu.Text = "Chi tiêu";
            // 
            // mnuThongKe
            // 
            mnuThongKe.Name = "mnuThongKe";
            mnuThongKe.Size = new Size(138, 22);
            mnuThongKe.Text = "Thống kê";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(135, 6);
            // 
            // mnuBan
            // 
            mnuBan.Name = "mnuBan";
            mnuBan.Size = new Size(138, 22);
            mnuBan.Text = "Bàn";
            // 
            // mnuDanhMuc
            // 
            mnuDanhMuc.Name = "mnuDanhMuc";
            mnuDanhMuc.Size = new Size(138, 22);
            mnuDanhMuc.Text = "Danh mục";
            // 
            // mnuThucUong
            // 
            mnuThucUong.Name = "mnuThucUong";
            mnuThucUong.Size = new Size(138, 22);
            mnuThucUong.Text = "Thức uống";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(135, 6);
            // 
            // mnuNguyenLieu
            // 
            mnuNguyenLieu.Name = "mnuNguyenLieu";
            mnuNguyenLieu.Size = new Size(138, 22);
            mnuNguyenLieu.Text = "Nguyên liệu";
            // 
            // mnuKho
            // 
            mnuKho.Name = "mnuKho";
            mnuKho.Size = new Size(138, 22);
            mnuKho.Text = "Kho";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(135, 6);
            // 
            // mnuTaiKhoan
            // 
            mnuTaiKhoan.Name = "mnuTaiKhoan";
            mnuTaiKhoan.Size = new Size(138, 22);
            mnuTaiKhoan.Text = "Tài khoản";
            // 
            // mnuChucNang
            // 
            mnuChucNang.Name = "mnuChucNang";
            mnuChucNang.Size = new Size(77, 20);
            mnuChucNang.Text = "Chức năng";
            // 
            // mnuThongTinTaiKhoan
            // 
            mnuThongTinTaiKhoan.Name = "mnuThongTinTaiKhoan";
            mnuThongTinTaiKhoan.Size = new Size(122, 20);
            mnuThongTinTaiKhoan.Text = "Thông tin tài khoản";
            // 
            // mnuDangNhap
            // 
            mnuDangNhap.Name = "mnuDangNhap";
            mnuDangNhap.Size = new Size(77, 20);
            mnuDangNhap.Text = "Đăng nhập";
            mnuDangNhap.Click += mnuDangNhap_Click;
            // 
            // mnuDangXuat
            // 
            mnuDangXuat.Name = "mnuDangXuat";
            mnuDangXuat.Size = new Size(73, 20);
            mnuDangXuat.Text = "Đăng xuất";
            mnuDangXuat.Click += mnuDangXuat_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblTrangThai, toolStripStatusLabel2, lblLienKet });
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblTrangThai
            // 
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(95, 17);
            lblTrangThai.Text = "Chưa đăng nhập";
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(618, 17);
            toolStripStatusLabel2.Spring = true;
            // 
            // lblLienKet
            // 
            lblLienKet.IsLink = true;
            lblLienKet.Name = "lblLienKet";
            lblLienKet.Size = new Size(72, 17);
            lblLienKet.Text = "©Hữu Đang";
            lblLienKet.Click += lblLienKet_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmMain";
            Text = "Form1";
            Load += frmMain_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuQuanLy;
        private ToolStripMenuItem mnuChucNang;
        private ToolStripMenuItem mnuThongTinTaiKhoan;
        private ToolStripMenuItem mnuDangXuat;
        private ToolStripMenuItem mnuDoanhThu;
        private ToolStripMenuItem mnuChiTieu;
        private ToolStripMenuItem mnuThongKe;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem mnuBan;
        private ToolStripMenuItem mnuDanhMuc;
        private ToolStripMenuItem mnuThucUong;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem mnuNguyenLieu;
        private ToolStripMenuItem mnuKho;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem mnuTaiKhoan;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblTrangThai;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripStatusLabel lblLienKet;
        private ToolStripMenuItem mnuDangNhap;
    }
}
