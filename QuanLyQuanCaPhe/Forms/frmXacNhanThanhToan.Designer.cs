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
            txtID = new ReaLTaiizor.Controls.FoxTextBox();
            label2 = new Label();
            txtThanhTien = new ReaLTaiizor.Controls.FoxTextBox();
            label3 = new Label();
            label4 = new Label();
            txtTienKhachDua = new ReaLTaiizor.Controls.FoxTextBox();
            label5 = new Label();
            txtTienThua = new ReaLTaiizor.Controls.FoxTextBox();
            btnXacNhan = new ReaLTaiizor.Controls.MaterialButton();
            cboHinhThucThanhToan = new ReaLTaiizor.Controls.HopeComboBox();
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
            // txtID
            // 
            txtID.BackColor = Color.Transparent;
            txtID.EnabledCalc = false;
            txtID.Font = new Font("Segoe UI", 12F);
            txtID.ForeColor = Color.FromArgb(66, 78, 90);
            txtID.Location = new Point(181, 39);
            txtID.MaxLength = 32767;
            txtID.MultiLine = false;
            txtID.Name = "txtID";
            txtID.ReadOnly = false;
            txtID.Size = new Size(180, 29);
            txtID.TabIndex = 1;
            txtID.TextAlign = HorizontalAlignment.Left;
            txtID.UseSystemPasswordChar = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(30, 101);
            label2.Name = "label2";
            label2.Size = new Size(74, 19);
            label2.TabIndex = 0;
            label2.Text = "Thành tiền:";
            // 
            // txtThanhTien
            // 
            txtThanhTien.BackColor = Color.Transparent;
            txtThanhTien.EnabledCalc = false;
            txtThanhTien.Font = new Font("Segoe UI", 12F);
            txtThanhTien.ForeColor = Color.FromArgb(66, 78, 90);
            txtThanhTien.Location = new Point(181, 96);
            txtThanhTien.MaxLength = 32767;
            txtThanhTien.MultiLine = false;
            txtThanhTien.Name = "txtThanhTien";
            txtThanhTien.ReadOnly = false;
            txtThanhTien.Size = new Size(180, 29);
            txtThanhTien.TabIndex = 1;
            txtThanhTien.TextAlign = HorizontalAlignment.Left;
            txtThanhTien.UseSystemPasswordChar = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(30, 158);
            label3.Name = "label3";
            label3.Size = new Size(144, 19);
            label3.TabIndex = 0;
            label3.Text = "Hình thức thanh thoán:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(30, 215);
            label4.Name = "label4";
            label4.Size = new Size(102, 19);
            label4.TabIndex = 0;
            label4.Text = "Tiền khách đưa";
            // 
            // txtTienKhachDua
            // 
            txtTienKhachDua.BackColor = Color.Transparent;
            txtTienKhachDua.EnabledCalc = true;
            txtTienKhachDua.Font = new Font("Segoe UI", 12F);
            txtTienKhachDua.ForeColor = Color.FromArgb(66, 78, 90);
            txtTienKhachDua.Location = new Point(181, 211);
            txtTienKhachDua.MaxLength = 32767;
            txtTienKhachDua.MultiLine = false;
            txtTienKhachDua.Name = "txtTienKhachDua";
            txtTienKhachDua.ReadOnly = false;
            txtTienKhachDua.Size = new Size(180, 29);
            txtTienKhachDua.TabIndex = 1;
            txtTienKhachDua.TextAlign = HorizontalAlignment.Left;
            txtTienKhachDua.UseSystemPasswordChar = false;
            txtTienKhachDua.TextChanged += txtTienKhachDua_TextChanged;
            txtTienKhachDua.KeyPress += txtTienKhachDua_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(30, 272);
            label5.Name = "label5";
            label5.Size = new Size(68, 19);
            label5.TabIndex = 0;
            label5.Text = "Tiền thừa:";
            // 
            // txtTienThua
            // 
            txtTienThua.BackColor = Color.Transparent;
            txtTienThua.Enabled = false;
            txtTienThua.EnabledCalc = false;
            txtTienThua.Font = new Font("Segoe UI", 12F);
            txtTienThua.ForeColor = Color.FromArgb(66, 78, 90);
            txtTienThua.Location = new Point(181, 269);
            txtTienThua.MaxLength = 32767;
            txtTienThua.MultiLine = false;
            txtTienThua.Name = "txtTienThua";
            txtTienThua.ReadOnly = false;
            txtTienThua.Size = new Size(180, 29);
            txtTienThua.TabIndex = 1;
            txtTienThua.TextAlign = HorizontalAlignment.Left;
            txtTienThua.UseSystemPasswordChar = false;
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
            btnXacNhan.TabIndex = 2;
            btnXacNhan.Text = "Xác nhận";
            btnXacNhan.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnXacNhan.UseAccentColor = false;
            btnXacNhan.UseVisualStyleBackColor = true;
            btnXacNhan.Click += btnXacNhan_Click;
            // 
            // cboHinhThucThanhToan
            // 
            cboHinhThucThanhToan.DrawMode = DrawMode.OwnerDrawFixed;
            cboHinhThucThanhToan.FlatStyle = FlatStyle.Flat;
            cboHinhThucThanhToan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboHinhThucThanhToan.FormattingEnabled = true;
            cboHinhThucThanhToan.ItemHeight = 30;
            cboHinhThucThanhToan.Items.AddRange(new object[] { "Tiền mặt", "Chuyển khoản" });
            cboHinhThucThanhToan.Location = new Point(181, 149);
            cboHinhThucThanhToan.Name = "cboHinhThucThanhToan";
            cboHinhThucThanhToan.Size = new Size(180, 36);
            cboHinhThucThanhToan.TabIndex = 4;
            cboHinhThucThanhToan.SelectedIndexChanged += cboHinhThucThanhToan_SelectedIndexChanged;
            // 
            // frmXacNhanThanhToan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 390);
            Controls.Add(cboHinhThucThanhToan);
            Controls.Add(btnXacNhan);
            Controls.Add(txtTienThua);
            Controls.Add(label5);
            Controls.Add(txtTienKhachDua);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtThanhTien);
            Controls.Add(label2);
            Controls.Add(txtID);
            Controls.Add(label1);
            Name = "frmXacNhanThanhToan";
            Text = "frmXacNhanThanhToan";
            Load += frmXacNhanThanhToan_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ReaLTaiizor.Controls.FoxTextBox txtID;
        private Label label2;
        private ReaLTaiizor.Controls.FoxTextBox txtThanhTien;
        private Label label3;
        private Label label4;
        private ReaLTaiizor.Controls.FoxTextBox txtTienKhachDua;
        private Label label5;
        private ReaLTaiizor.Controls.FoxTextBox txtTienThua;
        private ReaLTaiizor.Controls.MaterialButton btnXacNhan;
        private ReaLTaiizor.Controls.HopeComboBox cboHinhThucThanhToan;
    }
}