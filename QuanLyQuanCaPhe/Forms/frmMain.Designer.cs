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
            statusStrip1 = new StatusStrip();
            lblTrangThai = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            lblLienKet = new ToolStripStatusLabel();
            menuStrip1 = new MenuStrip();
            hệThốngToolStripMenuItem = new ToolStripMenuItem();
            mnuDangNhap = new ToolStripMenuItem();
            mnuDangXuat = new ToolStripMenuItem();
            mnuThongTinTaiKhoan = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            thoátToolStripMenuItem = new ToolStripMenuItem();
            mnuQuanLy = new ToolStripMenuItem();
            mnuBan = new ToolStripMenuItem();
            mnuDanhMuc = new ToolStripMenuItem();
            mnuThucUong = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            mnuNguyenLieu = new ToolStripMenuItem();
            mnuKho = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            mnuTaiKhoan = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            thốngKêBáoCáoToolStripMenuItem = new ToolStripMenuItem();
            thốngKêDoanhThuToolStripMenuItem = new ToolStripMenuItem();
            thốngKêThứcUốngToolStripMenuItem = new ToolStripMenuItem();
            mnuChucNang = new ToolStripMenuItem();
            mnuTroGiup = new ToolStripMenuItem();
            mnuThongTinPhanMem = new ToolStripMenuItem();
            mnuHuongDanSuDung = new ToolStripMenuItem();
            helpProvider = new HelpProvider();
            statusStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblTrangThai, toolStripStatusLabel2, lblLienKet });
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 3;
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
            toolStripStatusLabel2.Size = new Size(587, 17);
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
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { hệThốngToolStripMenuItem, mnuQuanLy, thốngKêBáoCáoToolStripMenuItem, mnuChucNang, mnuTroGiup });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            hệThốngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mnuDangNhap, mnuDangXuat, mnuThongTinTaiKhoan, toolStripSeparator1, thoátToolStripMenuItem });
            hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            hệThốngToolStripMenuItem.Size = new Size(69, 20);
            hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // mnuDangNhap
            // 
            mnuDangNhap.Name = "mnuDangNhap";
            mnuDangNhap.Size = new Size(186, 22);
            mnuDangNhap.Text = "Đăng nhập… ";
            mnuDangNhap.Click += mnuDangNhap_Click;
            // 
            // mnuDangXuat
            // 
            mnuDangXuat.Name = "mnuDangXuat";
            mnuDangXuat.Size = new Size(186, 22);
            mnuDangXuat.Text = "Đăng xuất ";
            mnuDangXuat.Click += mnuDangXuat_Click;
            // 
            // mnuThongTinTaiKhoan
            // 
            mnuThongTinTaiKhoan.Name = "mnuThongTinTaiKhoan";
            mnuThongTinTaiKhoan.Size = new Size(186, 22);
            mnuThongTinTaiKhoan.Text = "Thông tin tài khoản...";
            mnuThongTinTaiKhoan.Click += mnuThongTinTaiKhoan_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(183, 6);
            // 
            // thoátToolStripMenuItem
            // 
            thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            thoátToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.F4;
            thoátToolStripMenuItem.Size = new Size(186, 22);
            thoátToolStripMenuItem.Text = "Thoát";
            // 
            // mnuQuanLy
            // 
            mnuQuanLy.DropDownItems.AddRange(new ToolStripItem[] { mnuBan, mnuDanhMuc, mnuThucUong, toolStripSeparator2, mnuNguyenLieu, mnuKho, toolStripSeparator3, mnuTaiKhoan, toolStripSeparator4 });
            mnuQuanLy.Name = "mnuQuanLy";
            mnuQuanLy.Size = new Size(60, 20);
            mnuQuanLy.Text = "Quản lý";
            // 
            // mnuBan
            // 
            mnuBan.Name = "mnuBan";
            mnuBan.Size = new Size(138, 22);
            mnuBan.Text = "Bàn";
            mnuBan.Click += mnuBan_Click;
            // 
            // mnuDanhMuc
            // 
            mnuDanhMuc.Name = "mnuDanhMuc";
            mnuDanhMuc.Size = new Size(138, 22);
            mnuDanhMuc.Text = "Danh mục";
            mnuDanhMuc.Click += mnuDanhMuc_Click;
            // 
            // mnuThucUong
            // 
            mnuThucUong.Name = "mnuThucUong";
            mnuThucUong.Size = new Size(138, 22);
            mnuThucUong.Text = "Thức uống";
            mnuThucUong.Click += mnuThucUong_Click;
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
            mnuTaiKhoan.Click += mnuTaiKhoan_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(135, 6);
            // 
            // thốngKêBáoCáoToolStripMenuItem
            // 
            thốngKêBáoCáoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { thốngKêDoanhThuToolStripMenuItem, thốngKêThứcUốngToolStripMenuItem });
            thốngKêBáoCáoToolStripMenuItem.Name = "thốngKêBáoCáoToolStripMenuItem";
            thốngKêBáoCáoToolStripMenuItem.Size = new Size(121, 20);
            thốngKêBáoCáoToolStripMenuItem.Text = "Thống kê - Báo cáo";
            // 
            // thốngKêDoanhThuToolStripMenuItem
            // 
            thốngKêDoanhThuToolStripMenuItem.Name = "thốngKêDoanhThuToolStripMenuItem";
            thốngKêDoanhThuToolStripMenuItem.Size = new Size(181, 22);
            thốngKêDoanhThuToolStripMenuItem.Text = "Thống kê doanh thu";
            thốngKêDoanhThuToolStripMenuItem.Click += mnuDoanhThu_Click;
            // 
            // thốngKêThứcUốngToolStripMenuItem
            // 
            thốngKêThứcUốngToolStripMenuItem.Name = "thốngKêThứcUốngToolStripMenuItem";
            thốngKêThứcUốngToolStripMenuItem.Size = new Size(181, 22);
            thốngKêThứcUốngToolStripMenuItem.Text = "Thống kê thức uống";
            thốngKêThứcUốngToolStripMenuItem.Click += mnuThongKeThucUong_Click;
            // 
            // mnuChucNang
            // 
            mnuChucNang.Name = "mnuChucNang";
            mnuChucNang.Size = new Size(77, 20);
            mnuChucNang.Text = "Chức năng";
            mnuChucNang.Click += mnuChucNang_Click;
            // 
            // mnuTroGiup
            // 
            mnuTroGiup.DropDownItems.AddRange(new ToolStripItem[] { mnuThongTinPhanMem, mnuHuongDanSuDung });
            mnuTroGiup.Name = "mnuTroGiup";
            mnuTroGiup.Size = new Size(62, 20);
            mnuTroGiup.Text = "Trợ giúp";
            // 
            // mnuThongTinPhanMem
            // 
            mnuThongTinPhanMem.Name = "mnuThongTinPhanMem";
            mnuThongTinPhanMem.Size = new Size(235, 22);
            mnuThongTinPhanMem.Text = "Thông tin phần mềm... ";
            // 
            // mnuHuongDanSuDung
            // 
            mnuHuongDanSuDung.Name = "mnuHuongDanSuDung";
            mnuHuongDanSuDung.ShortcutKeys = Keys.Control | Keys.F1;
            mnuHuongDanSuDung.Size = new Size(235, 22);
            mnuHuongDanSuDung.Text = "Hướng dẫn sử dụng…";
            mnuHuongDanSuDung.Click += mnuHuongDanSuDung_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            TransparencyKey = Color.White;
            WindowState = FormWindowState.Maximized;
            Load += frmMain_Load;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ReaLTaiizor.Controls.RoyalMenuStrip royalMenuStrip1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblTrangThai;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripStatusLabel lblLienKet;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuQuanLy;
        private ToolStripMenuItem mnuBan;
        private ToolStripMenuItem mnuDanhMuc;
        private ToolStripMenuItem mnuThucUong;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem mnuNguyenLieu;
        private ToolStripMenuItem mnuKho;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem mnuTaiKhoan;
        private ToolStripMenuItem mnuChucNang;
        private ToolStripMenuItem mnuTroGiup;
        private ToolStripMenuItem hệThốngToolStripMenuItem;
        private ToolStripMenuItem mnuDangNhap;
        private ToolStripMenuItem mnuDangXuat;
        private ToolStripMenuItem mnuThongTinTaiKhoan;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem thoátToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem mnuThongTinPhanMem;
        private ToolStripMenuItem mnuHuongDanSuDung;
        private HelpProvider helpProvider;
        private ToolStripMenuItem thốngKêBáoCáoToolStripMenuItem;
        private ToolStripMenuItem thốngKêDoanhThuToolStripMenuItem;
        private ToolStripMenuItem thốngKêThứcUốngToolStripMenuItem;
    }
}
