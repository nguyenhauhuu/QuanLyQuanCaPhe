namespace QuanLyQuanCaPhe.Forms
{
    partial class frmXacNhanThanhToan
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
            label4 = new Label();
            label5 = new Label();
            btnXacNhan = new ReaLTaiizor.Controls.MaterialButton();
            txtID = new TextBox();
            txtThanhTien = new TextBox();
            txtTienKhachDua = new TextBox();
            txtTienThua = new TextBox();
            cboHinhThucThanhToan = new ComboBox();
            helpProvider1 = new HelpProvider();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(30, 44);
            label1.Name = "label1";
            label1.Size = new Size(86, 19);
            label1.TabIndex = 0;
            label1.Text = "Mã hóa đơn:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(30, 101);
            label2.Name = "label2";
            label2.Size = new Size(74, 19);
            label2.TabIndex = 2;
            label2.Text = "Thành tiền:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(30, 158);
            label3.Name = "label3";
            label3.Size = new Size(144, 19);
            label3.TabIndex = 4;
            label3.Text = "Hình thức thanh thoán:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(30, 215);
            label4.Name = "label4";
            label4.Size = new Size(102, 19);
            label4.TabIndex = 6;
            label4.Text = "Tiền khách đưa";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(30, 272);
            label5.Name = "label5";
            label5.Size = new Size(68, 19);
            label5.TabIndex = 8;
            label5.Text = "Tiền thừa:";
            // 
            // btnXacNhan
            // 
            btnXacNhan.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnXacNhan.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnXacNhan.Depth = 0;
            btnXacNhan.HighEmphasis = true;
            btnXacNhan.Icon = null;
            btnXacNhan.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnXacNhan.Location = new Point(266, 323);
            btnXacNhan.Margin = new Padding(4, 6, 4, 6);
            btnXacNhan.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnXacNhan.Name = "btnXacNhan";
            btnXacNhan.NoAccentTextColor = Color.Empty;
            btnXacNhan.Size = new Size(95, 36);
            btnXacNhan.TabIndex = 10;
            btnXacNhan.Text = "Xác nhận";
            btnXacNhan.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnXacNhan.UseAccentColor = false;
            btnXacNhan.UseVisualStyleBackColor = true;
            btnXacNhan.Click += btnXacNhan_Click;
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Location = new Point(185, 40);
            txtID.Name = "txtID";
            txtID.Size = new Size(176, 23);
            txtID.TabIndex = 1;
            // 
            // txtThanhTien
            // 
            txtThanhTien.Enabled = false;
            txtThanhTien.Location = new Point(185, 98);
            txtThanhTien.Name = "txtThanhTien";
            txtThanhTien.Size = new Size(176, 23);
            txtThanhTien.TabIndex = 3;
            // 
            // txtTienKhachDua
            // 
            txtTienKhachDua.Enabled = false;
            txtTienKhachDua.Location = new Point(185, 215);
            txtTienKhachDua.Name = "txtTienKhachDua";
            txtTienKhachDua.Size = new Size(176, 23);
            txtTienKhachDua.TabIndex = 7;
            txtTienKhachDua.TextChanged += txtTienKhachDua_TextChanged;
            txtTienKhachDua.KeyDown += txtTienKhachDua_KeyDown;
            // 
            // txtTienThua
            // 
            txtTienThua.Enabled = false;
            txtTienThua.Location = new Point(185, 268);
            txtTienThua.Name = "txtTienThua";
            txtTienThua.Size = new Size(176, 23);
            txtTienThua.TabIndex = 9;
            // 
            // cboHinhThucThanhToan
            // 
            cboHinhThucThanhToan.FormattingEnabled = true;
            cboHinhThucThanhToan.Items.AddRange(new object[] { "Tiền mặt", "Chuyển khoản" });
            cboHinhThucThanhToan.Location = new Point(185, 160);
            cboHinhThucThanhToan.Name = "cboHinhThucThanhToan";
            cboHinhThucThanhToan.Size = new Size(176, 23);
            cboHinhThucThanhToan.TabIndex = 5;
            cboHinhThucThanhToan.SelectedIndexChanged += cboHinhThucThanhToan_SelectedIndexChanged;
            // 
            // frmXacNhanThanhToan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 390);
            Controls.Add(cboHinhThucThanhToan);
            Controls.Add(txtTienThua);
            Controls.Add(txtTienKhachDua);
            Controls.Add(txtThanhTien);
            Controls.Add(txtID);
            Controls.Add(btnXacNhan);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmXacNhanThanhToan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Xác nhận thanh toán";
            Load += frmXacNhanThanhToan_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ReaLTaiizor.Controls.MaterialButton btnXacNhan;
        private TextBox txtID;
        private TextBox txtThanhTien;
        private TextBox txtTienKhachDua;
        private TextBox txtTienThua;
        private ComboBox cboHinhThucThanhToan;
        private HelpProvider helpProvider1;
    }
}