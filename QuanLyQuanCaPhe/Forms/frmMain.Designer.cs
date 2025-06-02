namespace QuanLyQuanCaPhe.Forms
{
    partial class frmMain
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            statusStrip1 = new StatusStrip();
            lblTrangThai = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            lblLienKet = new ToolStripStatusLabel();
            sidebarTimer = new System.Windows.Forms.Timer(components);
            OrderContainer = new Panel();
            btnOrder = new Button();
            panel4 = new Panel();
            label1 = new Label();
            menuButton = new PictureBox();
            sidebar = new FlowLayoutPanel();
            ThongKeBaoCaoContainer = new Panel();
            panel8 = new Panel();
            btnThongKeThucUong = new Button();
            panel7 = new Panel();
            btnThongKeDoanhThu = new Button();
            panel1 = new Panel();
            btnBaoCaoThongKe = new Button();
            QuanLyContainer = new Panel();
            panel13 = new Panel();
            btnTaiKhoan = new Button();
            panel12 = new Panel();
            btnKho = new Button();
            panel11 = new Panel();
            btnNguyenLieu = new Button();
            panel10 = new Panel();
            btnThucUong = new Button();
            panel3 = new Panel();
            btnDanhMuc = new Button();
            panel6 = new Panel();
            btnBan = new Button();
            panel9 = new Panel();
            btnQuanLy = new Button();
            HeThongContainer = new Panel();
            panel16 = new Panel();
            btnThoat = new Button();
            panel20 = new Panel();
            btnHeThong = new Button();
            panel18 = new Panel();
            btnDangXuat = new Button();
            panel17 = new Panel();
            btnThongTinTaiKhoan = new Button();
            DangNhapContainer = new Panel();
            btnDangNhap = new Button();
            TroGiupContainer = new Panel();
            panel22 = new Panel();
            btnHuongDanSuDung = new Button();
            panel23 = new Panel();
            btnThongTinPhanMem = new Button();
            panel24 = new Panel();
            btnTroGiup = new Button();
            ThongKeBaoCaoTimer = new System.Windows.Forms.Timer(components);
            QuanLyTimer = new System.Windows.Forms.Timer(components);
            HeThongTimer = new System.Windows.Forms.Timer(components);
            TroGiupTimer = new System.Windows.Forms.Timer(components);
            panel2 = new Panel();
            lblTieuDe = new Label();
            pnlFormLoader = new Panel();
            panel5 = new Panel();
            btnHoaDon = new Button();
            statusStrip1.SuspendLayout();
            OrderContainer.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)menuButton).BeginInit();
            sidebar.SuspendLayout();
            ThongKeBaoCaoContainer.SuspendLayout();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
            panel1.SuspendLayout();
            QuanLyContainer.SuspendLayout();
            panel13.SuspendLayout();
            panel12.SuspendLayout();
            panel11.SuspendLayout();
            panel10.SuspendLayout();
            panel3.SuspendLayout();
            panel6.SuspendLayout();
            panel9.SuspendLayout();
            HeThongContainer.SuspendLayout();
            panel16.SuspendLayout();
            panel20.SuspendLayout();
            panel18.SuspendLayout();
            panel17.SuspendLayout();
            DangNhapContainer.SuspendLayout();
            TroGiupContainer.SuspendLayout();
            panel22.SuspendLayout();
            panel23.SuspendLayout();
            panel24.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblTrangThai, toolStripStatusLabel2, lblLienKet });
            statusStrip1.Location = new Point(0, 701);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1090, 22);
            statusStrip1.TabIndex = 4;
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
            toolStripStatusLabel2.Size = new Size(908, 17);
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
            // sidebarTimer
            // 
            sidebarTimer.Interval = 10;
            sidebarTimer.Tick += sidebarTimer_Tick;
            // 
            // OrderContainer
            // 
            OrderContainer.Controls.Add(btnOrder);
            OrderContainer.Location = new Point(3, 109);
            OrderContainer.Name = "OrderContainer";
            OrderContainer.Size = new Size(235, 49);
            OrderContainer.TabIndex = 7;
            // 
            // btnOrder
            // 
            btnOrder.FlatStyle = FlatStyle.Flat;
            btnOrder.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOrder.ForeColor = Color.White;
            btnOrder.Image = (Image)resources.GetObject("btnOrder.Image");
            btnOrder.ImageAlign = ContentAlignment.MiddleLeft;
            btnOrder.Location = new Point(-11, -8);
            btnOrder.Name = "btnOrder";
            btnOrder.Padding = new Padding(20, 5, 5, 5);
            btnOrder.Size = new Size(253, 67);
            btnOrder.TabIndex = 0;
            btnOrder.Text = "    Order...";
            btnOrder.TextAlign = ContentAlignment.MiddleLeft;
            btnOrder.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnOrder.UseVisualStyleBackColor = true;
            btnOrder.Click += btnOrder_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(label1);
            panel4.Controls.Add(menuButton);
            panel4.Location = new Point(3, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(235, 100);
            panel4.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(67, 37);
            label1.Name = "label1";
            label1.Size = new Size(50, 21);
            label1.TabIndex = 1;
            label1.Text = "Menu";
            // 
            // menuButton
            // 
            menuButton.Cursor = Cursors.Hand;
            menuButton.Image = (Image)resources.GetObject("menuButton.Image");
            menuButton.Location = new Point(17, 37);
            menuButton.Name = "menuButton";
            menuButton.Size = new Size(35, 21);
            menuButton.SizeMode = PictureBoxSizeMode.StretchImage;
            menuButton.TabIndex = 0;
            menuButton.TabStop = false;
            menuButton.Click += menuButton_Click;
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.FromArgb(35, 40, 45);
            sidebar.Controls.Add(panel4);
            sidebar.Controls.Add(OrderContainer);
            sidebar.Controls.Add(ThongKeBaoCaoContainer);
            sidebar.Controls.Add(QuanLyContainer);
            sidebar.Controls.Add(HeThongContainer);
            sidebar.Controls.Add(DangNhapContainer);
            sidebar.Controls.Add(TroGiupContainer);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 0);
            sidebar.MaximumSize = new Size(238, 0);
            sidebar.MinimumSize = new Size(68, 0);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(238, 701);
            sidebar.TabIndex = 5;
            // 
            // ThongKeBaoCaoContainer
            // 
            ThongKeBaoCaoContainer.BackColor = Color.FromArgb(50, 55, 60);
            ThongKeBaoCaoContainer.Controls.Add(panel8);
            ThongKeBaoCaoContainer.Controls.Add(panel7);
            ThongKeBaoCaoContainer.Controls.Add(panel1);
            ThongKeBaoCaoContainer.Location = new Point(3, 164);
            ThongKeBaoCaoContainer.MaximumSize = new Size(235, 139);
            ThongKeBaoCaoContainer.MinimumSize = new Size(0, 48);
            ThongKeBaoCaoContainer.Name = "ThongKeBaoCaoContainer";
            ThongKeBaoCaoContainer.Size = new Size(235, 48);
            ThongKeBaoCaoContainer.TabIndex = 9;
            // 
            // panel8
            // 
            panel8.Controls.Add(btnThongKeThucUong);
            panel8.Location = new Point(0, 92);
            panel8.Name = "panel8";
            panel8.Size = new Size(235, 47);
            panel8.TabIndex = 10;
            // 
            // btnThongKeThucUong
            // 
            btnThongKeThucUong.FlatStyle = FlatStyle.Flat;
            btnThongKeThucUong.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThongKeThucUong.ForeColor = Color.White;
            btnThongKeThucUong.Image = (Image)resources.GetObject("btnThongKeThucUong.Image");
            btnThongKeThucUong.ImageAlign = ContentAlignment.MiddleLeft;
            btnThongKeThucUong.Location = new Point(-11, -6);
            btnThongKeThucUong.Name = "btnThongKeThucUong";
            btnThongKeThucUong.Padding = new Padding(20, 5, 5, 5);
            btnThongKeThucUong.Size = new Size(249, 55);
            btnThongKeThucUong.TabIndex = 0;
            btnThongKeThucUong.Text = "    Thống kê thức uống...";
            btnThongKeThucUong.TextAlign = ContentAlignment.MiddleLeft;
            btnThongKeThucUong.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnThongKeThucUong.UseVisualStyleBackColor = true;
            btnThongKeThucUong.Click += btnThongKeThucUong_Click;
            // 
            // panel7
            // 
            panel7.Controls.Add(btnThongKeDoanhThu);
            panel7.Location = new Point(0, 48);
            panel7.Name = "panel7";
            panel7.Size = new Size(235, 46);
            panel7.TabIndex = 9;
            // 
            // btnThongKeDoanhThu
            // 
            btnThongKeDoanhThu.FlatStyle = FlatStyle.Flat;
            btnThongKeDoanhThu.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThongKeDoanhThu.ForeColor = Color.White;
            btnThongKeDoanhThu.Image = (Image)resources.GetObject("btnThongKeDoanhThu.Image");
            btnThongKeDoanhThu.ImageAlign = ContentAlignment.MiddleLeft;
            btnThongKeDoanhThu.Location = new Point(-11, -5);
            btnThongKeDoanhThu.Name = "btnThongKeDoanhThu";
            btnThongKeDoanhThu.Padding = new Padding(20, 5, 5, 5);
            btnThongKeDoanhThu.Size = new Size(253, 55);
            btnThongKeDoanhThu.TabIndex = 0;
            btnThongKeDoanhThu.Text = "    Thống kê doanh thu...";
            btnThongKeDoanhThu.TextAlign = ContentAlignment.MiddleLeft;
            btnThongKeDoanhThu.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnThongKeDoanhThu.UseVisualStyleBackColor = true;
            btnThongKeDoanhThu.Click += btnThongKeDoanhThu_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnBaoCaoThongKe);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(235, 49);
            panel1.TabIndex = 8;
            // 
            // btnBaoCaoThongKe
            // 
            btnBaoCaoThongKe.BackColor = Color.FromArgb(35, 40, 45);
            btnBaoCaoThongKe.FlatStyle = FlatStyle.Flat;
            btnBaoCaoThongKe.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBaoCaoThongKe.ForeColor = Color.White;
            btnBaoCaoThongKe.Image = (Image)resources.GetObject("btnBaoCaoThongKe.Image");
            btnBaoCaoThongKe.ImageAlign = ContentAlignment.MiddleLeft;
            btnBaoCaoThongKe.Location = new Point(-11, -8);
            btnBaoCaoThongKe.Name = "btnBaoCaoThongKe";
            btnBaoCaoThongKe.Padding = new Padding(20, 5, 5, 5);
            btnBaoCaoThongKe.Size = new Size(253, 65);
            btnBaoCaoThongKe.TabIndex = 0;
            btnBaoCaoThongKe.Text = "    Thống kê - Báo cáo";
            btnBaoCaoThongKe.TextAlign = ContentAlignment.MiddleLeft;
            btnBaoCaoThongKe.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBaoCaoThongKe.UseVisualStyleBackColor = false;
            btnBaoCaoThongKe.Click += btnBaoCaoThongKe_Click;
            // 
            // QuanLyContainer
            // 
            QuanLyContainer.BackColor = Color.FromArgb(50, 55, 60);
            QuanLyContainer.Controls.Add(panel5);
            QuanLyContainer.Controls.Add(panel13);
            QuanLyContainer.Controls.Add(panel12);
            QuanLyContainer.Controls.Add(panel11);
            QuanLyContainer.Controls.Add(panel10);
            QuanLyContainer.Controls.Add(panel3);
            QuanLyContainer.Controls.Add(panel6);
            QuanLyContainer.Controls.Add(panel9);
            QuanLyContainer.Location = new Point(3, 218);
            QuanLyContainer.MaximumSize = new Size(235, 370);
            QuanLyContainer.MinimumSize = new Size(0, 48);
            QuanLyContainer.Name = "QuanLyContainer";
            QuanLyContainer.Size = new Size(235, 48);
            QuanLyContainer.TabIndex = 10;
            // 
            // panel13
            // 
            panel13.Controls.Add(btnTaiKhoan);
            panel13.Location = new Point(0, 264);
            panel13.Name = "panel13";
            panel13.Size = new Size(235, 47);
            panel13.TabIndex = 14;
            // 
            // btnTaiKhoan
            // 
            btnTaiKhoan.FlatStyle = FlatStyle.Flat;
            btnTaiKhoan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTaiKhoan.ForeColor = Color.White;
            btnTaiKhoan.Image = (Image)resources.GetObject("btnTaiKhoan.Image");
            btnTaiKhoan.ImageAlign = ContentAlignment.MiddleLeft;
            btnTaiKhoan.Location = new Point(-11, 0);
            btnTaiKhoan.Name = "btnTaiKhoan";
            btnTaiKhoan.Padding = new Padding(20, 5, 5, 5);
            btnTaiKhoan.Size = new Size(249, 49);
            btnTaiKhoan.TabIndex = 0;
            btnTaiKhoan.Text = "    Tài khoản...";
            btnTaiKhoan.TextAlign = ContentAlignment.MiddleLeft;
            btnTaiKhoan.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTaiKhoan.UseVisualStyleBackColor = true;
            btnTaiKhoan.Click += btnTaiKhoan_Click;
            // 
            // panel12
            // 
            panel12.Controls.Add(btnKho);
            panel12.Location = new Point(0, 224);
            panel12.Name = "panel12";
            panel12.Size = new Size(235, 47);
            panel12.TabIndex = 13;
            // 
            // btnKho
            // 
            btnKho.FlatStyle = FlatStyle.Flat;
            btnKho.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnKho.ForeColor = Color.White;
            btnKho.Image = (Image)resources.GetObject("btnKho.Image");
            btnKho.ImageAlign = ContentAlignment.MiddleLeft;
            btnKho.Location = new Point(-11, -6);
            btnKho.Name = "btnKho";
            btnKho.Padding = new Padding(20, 5, 5, 5);
            btnKho.Size = new Size(249, 55);
            btnKho.TabIndex = 0;
            btnKho.Text = "    Kho...";
            btnKho.TextAlign = ContentAlignment.MiddleLeft;
            btnKho.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnKho.UseVisualStyleBackColor = true;
            btnKho.Click += btnKho_Click;
            // 
            // panel11
            // 
            panel11.Controls.Add(btnNguyenLieu);
            panel11.Location = new Point(1, 178);
            panel11.Name = "panel11";
            panel11.Size = new Size(235, 47);
            panel11.TabIndex = 12;
            // 
            // btnNguyenLieu
            // 
            btnNguyenLieu.FlatStyle = FlatStyle.Flat;
            btnNguyenLieu.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNguyenLieu.ForeColor = Color.White;
            btnNguyenLieu.Image = (Image)resources.GetObject("btnNguyenLieu.Image");
            btnNguyenLieu.ImageAlign = ContentAlignment.MiddleLeft;
            btnNguyenLieu.Location = new Point(-11, 0);
            btnNguyenLieu.Name = "btnNguyenLieu";
            btnNguyenLieu.Padding = new Padding(20, 5, 5, 5);
            btnNguyenLieu.Size = new Size(249, 49);
            btnNguyenLieu.TabIndex = 0;
            btnNguyenLieu.Text = "    Nguyên liệu...";
            btnNguyenLieu.TextAlign = ContentAlignment.MiddleLeft;
            btnNguyenLieu.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNguyenLieu.UseVisualStyleBackColor = true;
            btnNguyenLieu.Click += btnNguyenLieu_Click;
            // 
            // panel10
            // 
            panel10.Controls.Add(btnThucUong);
            panel10.Location = new Point(0, 135);
            panel10.Name = "panel10";
            panel10.Size = new Size(235, 47);
            panel10.TabIndex = 11;
            // 
            // btnThucUong
            // 
            btnThucUong.FlatStyle = FlatStyle.Flat;
            btnThucUong.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThucUong.ForeColor = Color.White;
            btnThucUong.Image = (Image)resources.GetObject("btnThucUong.Image");
            btnThucUong.ImageAlign = ContentAlignment.MiddleLeft;
            btnThucUong.Location = new Point(-11, -6);
            btnThucUong.Name = "btnThucUong";
            btnThucUong.Padding = new Padding(20, 5, 5, 5);
            btnThucUong.Size = new Size(249, 55);
            btnThucUong.TabIndex = 0;
            btnThucUong.Text = "    Thức uống...";
            btnThucUong.TextAlign = ContentAlignment.MiddleLeft;
            btnThucUong.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnThucUong.UseVisualStyleBackColor = true;
            btnThucUong.Click += btnThucUong_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnDanhMuc);
            panel3.Location = new Point(0, 92);
            panel3.Name = "panel3";
            panel3.Size = new Size(235, 47);
            panel3.TabIndex = 10;
            // 
            // btnDanhMuc
            // 
            btnDanhMuc.FlatStyle = FlatStyle.Flat;
            btnDanhMuc.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDanhMuc.ForeColor = Color.White;
            btnDanhMuc.Image = (Image)resources.GetObject("btnDanhMuc.Image");
            btnDanhMuc.ImageAlign = ContentAlignment.MiddleLeft;
            btnDanhMuc.Location = new Point(-11, -6);
            btnDanhMuc.Name = "btnDanhMuc";
            btnDanhMuc.Padding = new Padding(20, 5, 5, 5);
            btnDanhMuc.Size = new Size(249, 55);
            btnDanhMuc.TabIndex = 0;
            btnDanhMuc.Text = "    Danh mục...";
            btnDanhMuc.TextAlign = ContentAlignment.MiddleLeft;
            btnDanhMuc.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDanhMuc.UseVisualStyleBackColor = true;
            btnDanhMuc.Click += btnDanhMuc_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(btnBan);
            panel6.Location = new Point(0, 48);
            panel6.Name = "panel6";
            panel6.Size = new Size(235, 46);
            panel6.TabIndex = 9;
            // 
            // btnBan
            // 
            btnBan.FlatStyle = FlatStyle.Flat;
            btnBan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBan.ForeColor = Color.White;
            btnBan.Image = (Image)resources.GetObject("btnBan.Image");
            btnBan.ImageAlign = ContentAlignment.MiddleLeft;
            btnBan.Location = new Point(-11, -5);
            btnBan.Name = "btnBan";
            btnBan.Padding = new Padding(20, 5, 5, 5);
            btnBan.Size = new Size(253, 55);
            btnBan.TabIndex = 0;
            btnBan.Text = "    Bàn...";
            btnBan.TextAlign = ContentAlignment.MiddleLeft;
            btnBan.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBan.UseVisualStyleBackColor = true;
            btnBan.Click += btnBan_Click;
            // 
            // panel9
            // 
            panel9.Controls.Add(btnQuanLy);
            panel9.Location = new Point(0, 0);
            panel9.Name = "panel9";
            panel9.Size = new Size(235, 49);
            panel9.TabIndex = 8;
            // 
            // btnQuanLy
            // 
            btnQuanLy.BackColor = Color.FromArgb(35, 40, 45);
            btnQuanLy.FlatStyle = FlatStyle.Flat;
            btnQuanLy.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnQuanLy.ForeColor = Color.White;
            btnQuanLy.Image = (Image)resources.GetObject("btnQuanLy.Image");
            btnQuanLy.ImageAlign = ContentAlignment.MiddleLeft;
            btnQuanLy.Location = new Point(-11, -8);
            btnQuanLy.Name = "btnQuanLy";
            btnQuanLy.Padding = new Padding(20, 5, 5, 5);
            btnQuanLy.Size = new Size(253, 65);
            btnQuanLy.TabIndex = 0;
            btnQuanLy.Text = "    Quản lý";
            btnQuanLy.TextAlign = ContentAlignment.MiddleLeft;
            btnQuanLy.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnQuanLy.UseVisualStyleBackColor = false;
            btnQuanLy.Click += btnQuanLy_Click;
            // 
            // HeThongContainer
            // 
            HeThongContainer.BackColor = Color.FromArgb(50, 55, 60);
            HeThongContainer.Controls.Add(panel16);
            HeThongContainer.Controls.Add(panel20);
            HeThongContainer.Controls.Add(panel18);
            HeThongContainer.Controls.Add(panel17);
            HeThongContainer.Location = new Point(3, 272);
            HeThongContainer.MaximumSize = new Size(235, 188);
            HeThongContainer.MinimumSize = new Size(0, 48);
            HeThongContainer.Name = "HeThongContainer";
            HeThongContainer.Size = new Size(235, 48);
            HeThongContainer.TabIndex = 11;
            // 
            // panel16
            // 
            panel16.Controls.Add(btnThoat);
            panel16.Location = new Point(2, 138);
            panel16.Name = "panel16";
            panel16.Size = new Size(235, 47);
            panel16.TabIndex = 12;
            // 
            // btnThoat
            // 
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThoat.ForeColor = Color.White;
            btnThoat.Image = (Image)resources.GetObject("btnThoat.Image");
            btnThoat.ImageAlign = ContentAlignment.MiddleLeft;
            btnThoat.Location = new Point(-11, 0);
            btnThoat.Name = "btnThoat";
            btnThoat.Padding = new Padding(20, 5, 5, 5);
            btnThoat.Size = new Size(249, 49);
            btnThoat.TabIndex = 0;
            btnThoat.Text = "    Thoát             ALT + F4";
            btnThoat.TextAlign = ContentAlignment.MiddleLeft;
            btnThoat.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // panel20
            // 
            panel20.Controls.Add(btnHeThong);
            panel20.Location = new Point(0, 0);
            panel20.Name = "panel20";
            panel20.Size = new Size(235, 49);
            panel20.TabIndex = 8;
            // 
            // btnHeThong
            // 
            btnHeThong.BackColor = Color.FromArgb(35, 40, 45);
            btnHeThong.FlatStyle = FlatStyle.Flat;
            btnHeThong.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHeThong.ForeColor = Color.White;
            btnHeThong.Image = (Image)resources.GetObject("btnHeThong.Image");
            btnHeThong.ImageAlign = ContentAlignment.MiddleLeft;
            btnHeThong.Location = new Point(-11, -8);
            btnHeThong.Name = "btnHeThong";
            btnHeThong.Padding = new Padding(20, 5, 5, 5);
            btnHeThong.Size = new Size(253, 65);
            btnHeThong.TabIndex = 0;
            btnHeThong.Text = "    Hệ thống";
            btnHeThong.TextAlign = ContentAlignment.MiddleLeft;
            btnHeThong.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHeThong.UseVisualStyleBackColor = false;
            btnHeThong.Click += btnHeThong_Click;
            // 
            // panel18
            // 
            panel18.Controls.Add(btnDangXuat);
            panel18.Location = new Point(1, 52);
            panel18.Name = "panel18";
            panel18.Size = new Size(235, 47);
            panel18.TabIndex = 10;
            // 
            // btnDangXuat
            // 
            btnDangXuat.FlatStyle = FlatStyle.Flat;
            btnDangXuat.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDangXuat.ForeColor = Color.White;
            btnDangXuat.Image = (Image)resources.GetObject("btnDangXuat.Image");
            btnDangXuat.ImageAlign = ContentAlignment.MiddleLeft;
            btnDangXuat.Location = new Point(-11, -6);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Padding = new Padding(20, 5, 5, 5);
            btnDangXuat.Size = new Size(249, 55);
            btnDangXuat.TabIndex = 0;
            btnDangXuat.Text = "    Đăng xuất...";
            btnDangXuat.TextAlign = ContentAlignment.MiddleLeft;
            btnDangXuat.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDangXuat.UseVisualStyleBackColor = true;
            btnDangXuat.Click += btnDangXuat_Click;
            // 
            // panel17
            // 
            panel17.Controls.Add(btnThongTinTaiKhoan);
            panel17.Location = new Point(1, 95);
            panel17.Name = "panel17";
            panel17.Size = new Size(235, 47);
            panel17.TabIndex = 11;
            // 
            // btnThongTinTaiKhoan
            // 
            btnThongTinTaiKhoan.FlatStyle = FlatStyle.Flat;
            btnThongTinTaiKhoan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThongTinTaiKhoan.ForeColor = Color.White;
            btnThongTinTaiKhoan.Image = (Image)resources.GetObject("btnThongTinTaiKhoan.Image");
            btnThongTinTaiKhoan.ImageAlign = ContentAlignment.MiddleLeft;
            btnThongTinTaiKhoan.Location = new Point(-11, -6);
            btnThongTinTaiKhoan.Name = "btnThongTinTaiKhoan";
            btnThongTinTaiKhoan.Padding = new Padding(20, 5, 5, 5);
            btnThongTinTaiKhoan.Size = new Size(249, 55);
            btnThongTinTaiKhoan.TabIndex = 0;
            btnThongTinTaiKhoan.Text = "    Thông tin tài khoản...";
            btnThongTinTaiKhoan.TextAlign = ContentAlignment.MiddleLeft;
            btnThongTinTaiKhoan.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnThongTinTaiKhoan.UseVisualStyleBackColor = true;
            btnThongTinTaiKhoan.Click += btnThongTinTaiKhoan_Click;
            // 
            // DangNhapContainer
            // 
            DangNhapContainer.Controls.Add(btnDangNhap);
            DangNhapContainer.Location = new Point(3, 326);
            DangNhapContainer.Name = "DangNhapContainer";
            DangNhapContainer.Size = new Size(235, 49);
            DangNhapContainer.TabIndex = 8;
            // 
            // btnDangNhap
            // 
            btnDangNhap.FlatStyle = FlatStyle.Flat;
            btnDangNhap.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDangNhap.ForeColor = Color.White;
            btnDangNhap.Image = (Image)resources.GetObject("btnDangNhap.Image");
            btnDangNhap.ImageAlign = ContentAlignment.MiddleLeft;
            btnDangNhap.Location = new Point(-11, -8);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Padding = new Padding(20, 5, 5, 5);
            btnDangNhap.Size = new Size(253, 67);
            btnDangNhap.TabIndex = 0;
            btnDangNhap.Text = "    Đăng nhập...";
            btnDangNhap.TextAlign = ContentAlignment.MiddleLeft;
            btnDangNhap.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDangNhap.UseVisualStyleBackColor = true;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // TroGiupContainer
            // 
            TroGiupContainer.BackColor = Color.FromArgb(50, 55, 60);
            TroGiupContainer.Controls.Add(panel22);
            TroGiupContainer.Controls.Add(panel23);
            TroGiupContainer.Controls.Add(panel24);
            TroGiupContainer.Location = new Point(3, 381);
            TroGiupContainer.MaximumSize = new Size(235, 137);
            TroGiupContainer.MinimumSize = new Size(0, 48);
            TroGiupContainer.Name = "TroGiupContainer";
            TroGiupContainer.Size = new Size(235, 48);
            TroGiupContainer.TabIndex = 12;
            // 
            // panel22
            // 
            panel22.Controls.Add(btnHuongDanSuDung);
            panel22.Location = new Point(0, 92);
            panel22.Name = "panel22";
            panel22.Size = new Size(235, 47);
            panel22.TabIndex = 10;
            // 
            // btnHuongDanSuDung
            // 
            btnHuongDanSuDung.FlatStyle = FlatStyle.Flat;
            btnHuongDanSuDung.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHuongDanSuDung.ForeColor = Color.White;
            btnHuongDanSuDung.Image = (Image)resources.GetObject("btnHuongDanSuDung.Image");
            btnHuongDanSuDung.ImageAlign = ContentAlignment.MiddleLeft;
            btnHuongDanSuDung.Location = new Point(-11, -6);
            btnHuongDanSuDung.Name = "btnHuongDanSuDung";
            btnHuongDanSuDung.Padding = new Padding(20, 5, 5, 5);
            btnHuongDanSuDung.Size = new Size(249, 55);
            btnHuongDanSuDung.TabIndex = 0;
            btnHuongDanSuDung.Text = "    Hướng dẫn sử dụng...";
            btnHuongDanSuDung.TextAlign = ContentAlignment.MiddleLeft;
            btnHuongDanSuDung.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHuongDanSuDung.UseVisualStyleBackColor = true;
            btnHuongDanSuDung.Click += btnHuongDanSuDung_Click;
            // 
            // panel23
            // 
            panel23.Controls.Add(btnThongTinPhanMem);
            panel23.Location = new Point(0, 48);
            panel23.Name = "panel23";
            panel23.Size = new Size(235, 46);
            panel23.TabIndex = 9;
            // 
            // btnThongTinPhanMem
            // 
            btnThongTinPhanMem.FlatStyle = FlatStyle.Flat;
            btnThongTinPhanMem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThongTinPhanMem.ForeColor = Color.White;
            btnThongTinPhanMem.Image = (Image)resources.GetObject("btnThongTinPhanMem.Image");
            btnThongTinPhanMem.ImageAlign = ContentAlignment.MiddleLeft;
            btnThongTinPhanMem.Location = new Point(-11, -5);
            btnThongTinPhanMem.Name = "btnThongTinPhanMem";
            btnThongTinPhanMem.Padding = new Padding(20, 5, 5, 5);
            btnThongTinPhanMem.Size = new Size(253, 55);
            btnThongTinPhanMem.TabIndex = 0;
            btnThongTinPhanMem.Text = "    Thông tin phần mềm...";
            btnThongTinPhanMem.TextAlign = ContentAlignment.MiddleLeft;
            btnThongTinPhanMem.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnThongTinPhanMem.UseVisualStyleBackColor = true;
            // 
            // panel24
            // 
            panel24.Controls.Add(btnTroGiup);
            panel24.Location = new Point(0, 0);
            panel24.Name = "panel24";
            panel24.Size = new Size(235, 49);
            panel24.TabIndex = 8;
            // 
            // btnTroGiup
            // 
            btnTroGiup.BackColor = Color.FromArgb(35, 40, 45);
            btnTroGiup.FlatStyle = FlatStyle.Flat;
            btnTroGiup.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTroGiup.ForeColor = Color.White;
            btnTroGiup.Image = (Image)resources.GetObject("btnTroGiup.Image");
            btnTroGiup.ImageAlign = ContentAlignment.MiddleLeft;
            btnTroGiup.Location = new Point(-11, -8);
            btnTroGiup.Name = "btnTroGiup";
            btnTroGiup.Padding = new Padding(20, 5, 5, 5);
            btnTroGiup.Size = new Size(253, 65);
            btnTroGiup.TabIndex = 0;
            btnTroGiup.Text = "    Trợ giúp";
            btnTroGiup.TextAlign = ContentAlignment.MiddleLeft;
            btnTroGiup.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTroGiup.UseVisualStyleBackColor = false;
            btnTroGiup.Click += btnTroGiup_Click;
            // 
            // ThongKeBaoCaoTimer
            // 
            ThongKeBaoCaoTimer.Interval = 10;
            ThongKeBaoCaoTimer.Tick += ThongKeBaoCaoTimer_Tick;
            // 
            // QuanLyTimer
            // 
            QuanLyTimer.Interval = 10;
            QuanLyTimer.Tick += QuanLyTimer_Tick;
            // 
            // HeThongTimer
            // 
            HeThongTimer.Interval = 10;
            HeThongTimer.Tick += HeThongTimer_Tick;
            // 
            // TroGiupTimer
            // 
            TroGiupTimer.Interval = 10;
            TroGiupTimer.Tick += TroGiupTimer_Tick;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblTieuDe);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(238, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(852, 54);
            panel2.TabIndex = 6;
            // 
            // lblTieuDe
            // 
            lblTieuDe.AutoSize = true;
            lblTieuDe.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTieuDe.Location = new Point(34, 9);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(111, 37);
            lblTieuDe.TabIndex = 0;
            lblTieuDe.Text = "Tiêu đề";
            // 
            // pnlFormLoader
            // 
            pnlFormLoader.Dock = DockStyle.Fill;
            pnlFormLoader.Location = new Point(238, 54);
            pnlFormLoader.Name = "pnlFormLoader";
            pnlFormLoader.Size = new Size(852, 647);
            pnlFormLoader.TabIndex = 7;
            // 
            // panel5
            // 
            panel5.Controls.Add(btnHoaDon);
            panel5.Location = new Point(1, 319);
            panel5.Name = "panel5";
            panel5.Size = new Size(235, 47);
            panel5.TabIndex = 15;
            // 
            // btnHoaDon
            // 
            btnHoaDon.FlatStyle = FlatStyle.Flat;
            btnHoaDon.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHoaDon.ForeColor = Color.White;
            btnHoaDon.Image = (Image)resources.GetObject("btnHoaDon.Image");
            btnHoaDon.ImageAlign = ContentAlignment.MiddleLeft;
            btnHoaDon.Location = new Point(-11, 0);
            btnHoaDon.Name = "btnHoaDon";
            btnHoaDon.Padding = new Padding(20, 5, 5, 5);
            btnHoaDon.Size = new Size(249, 49);
            btnHoaDon.TabIndex = 0;
            btnHoaDon.Text = "    Hoá đơn...";
            btnHoaDon.TextAlign = ContentAlignment.MiddleLeft;
            btnHoaDon.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHoaDon.UseVisualStyleBackColor = true;
            btnHoaDon.Click += btnHoaDon_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1090, 723);
            Controls.Add(pnlFormLoader);
            Controls.Add(panel2);
            Controls.Add(sidebar);
            Controls.Add(statusStrip1);
            Name = "frmMain";
            Text = "Phần mềm quản lý quán cà phê";
            Load += frmMain_Load;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            OrderContainer.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)menuButton).EndInit();
            sidebar.ResumeLayout(false);
            ThongKeBaoCaoContainer.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel1.ResumeLayout(false);
            QuanLyContainer.ResumeLayout(false);
            panel13.ResumeLayout(false);
            panel12.ResumeLayout(false);
            panel11.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel9.ResumeLayout(false);
            HeThongContainer.ResumeLayout(false);
            panel16.ResumeLayout(false);
            panel20.ResumeLayout(false);
            panel18.ResumeLayout(false);
            panel17.ResumeLayout(false);
            DangNhapContainer.ResumeLayout(false);
            TroGiupContainer.ResumeLayout(false);
            panel22.ResumeLayout(false);
            panel23.ResumeLayout(false);
            panel24.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel5.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblTrangThai;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripStatusLabel lblLienKet;
        private System.Windows.Forms.Timer sidebarTimer;
        private Panel OrderContainer;
        private Button btnOrder;
        private Panel panel4;
        private Label label1;
        private PictureBox menuButton;
        private FlowLayoutPanel sidebar;
        private Panel panel1;
        private Button btnBaoCaoThongKe;
        private Panel ThongKeBaoCaoContainer;
        private Panel panel7;
        private Button btnThongKeDoanhThu;
        private Panel panel8;
        private Button btnThongKeThucUong;
        private System.Windows.Forms.Timer ThongKeBaoCaoTimer;
        private Panel QuanLyContainer;
        private Panel panel3;
        private Button btnDanhMuc;
        private Panel panel6;
        private Button btnBan;
        private Panel panel9;
        private Button btnQuanLy;
        private Panel panel11;
        private Button btnNguyenLieu;
        private Panel panel10;
        private Button btnThucUong;
        private Panel panel12;
        private Button btnKho;
        private Panel panel13;
        private Button btnTaiKhoan;
        private System.Windows.Forms.Timer QuanLyTimer;
        private Panel HeThongContainer;
        private Panel panel16;
        private Button btnThoat;
        private Panel panel17;
        private Button btnThongTinTaiKhoan;
        private Panel panel19;
        private Panel panel20;
        private Button btnHeThong;
        private System.Windows.Forms.Timer HeThongTimer;
        private System.Windows.Forms.Timer TroGiupTimer;
        private Panel panel2;
        private Label lblTieuDe;
        private Panel pnlFormLoader;
        private Panel panel18;
        private Button btnDangXuat;
        private Panel TroGiupContainer;
        private Panel panel22;
        private Button btnHuongDanSuDung;
        private Panel panel23;
        private Button btnThongTinPhanMem;
        private Panel panel24;
        private Button btnTroGiup;
        private Panel DangNhapContainer;
        private Button btnDangNhap;
        private Panel panel5;
        private Button btnHoaDon;
    }
}