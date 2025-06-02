namespace QuanLyQuanCaPhe.Reports
{
    partial class frmThongKeDoanhThu
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
            btnHienTatCa = new Button();
            btnLocKetQua = new Button();
            dtpDenNgay = new DateTimePicker();
            label2 = new Label();
            dtpTuNgay = new DateTimePicker();
            label1 = new Label();
            reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            helpProvider1 = new HelpProvider();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnHienTatCa);
            panel1.Controls.Add(btnLocKetQua);
            panel1.Controls.Add(dtpDenNgay);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(dtpTuNgay);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 57);
            panel1.TabIndex = 1;
            // 
            // btnHienTatCa
            // 
            btnHienTatCa.BackColor = Color.White;
            btnHienTatCa.ForeColor = Color.Black;
            btnHienTatCa.Location = new Point(642, 15);
            btnHienTatCa.Margin = new Padding(0);
            btnHienTatCa.Name = "btnHienTatCa";
            btnHienTatCa.Size = new Size(89, 23);
            btnHienTatCa.TabIndex = 2;
            btnHienTatCa.Text = "Hiện tất cả";
            btnHienTatCa.UseVisualStyleBackColor = false;
            btnHienTatCa.Click += btnHienTatCa_Click;
            // 
            // btnLocKetQua
            // 
            btnLocKetQua.BackColor = Color.White;
            btnLocKetQua.ForeColor = Color.Black;
            btnLocKetQua.Location = new Point(539, 15);
            btnLocKetQua.Margin = new Padding(0);
            btnLocKetQua.Name = "btnLocKetQua";
            btnLocKetQua.Size = new Size(89, 23);
            btnLocKetQua.TabIndex = 2;
            btnLocKetQua.Text = "Lọc kết quả";
            btnLocKetQua.UseVisualStyleBackColor = false;
            btnLocKetQua.Click += btnLocKetQua_Click;
            // 
            // dtpDenNgay
            // 
            dtpDenNgay.CustomFormat = "dd/MM/yyyy";
            dtpDenNgay.Format = DateTimePickerFormat.Custom;
            dtpDenNgay.Location = new Point(402, 15);
            dtpDenNgay.Name = "dtpDenNgay";
            dtpDenNgay.Size = new Size(116, 23);
            dtpDenNgay.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(336, 18);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 0;
            label2.Text = "Đến ngày:";
            // 
            // dtpTuNgay
            // 
            dtpTuNgay.CustomFormat = "dd/MM/yyyy";
            dtpTuNgay.Format = DateTimePickerFormat.Custom;
            dtpTuNgay.Location = new Point(186, 15);
            dtpTuNgay.Name = "dtpTuNgay";
            dtpTuNgay.Size = new Size(116, 23);
            dtpTuNgay.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(128, 18);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 0;
            label1.Text = "Từ ngày:";
            // 
            // reportViewer
            // 
            reportViewer.Dock = DockStyle.Fill;
            reportViewer.Location = new Point(0, 57);
            reportViewer.Name = "ReportViewer";
            reportViewer.ServerReport.BearerToken = null;
            reportViewer.Size = new Size(800, 393);
            reportViewer.TabIndex = 0;
            // 
            // frmThongKeDoanhThu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(reportViewer);
            Controls.Add(panel1);
            Name = "frmThongKeDoanhThu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thống kê doanh thu";
            WindowState = FormWindowState.Maximized;
            Load += frmThongKeDoanhThu_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        private Panel panel1;
        private DateTimePicker dtpTuNgay;
        private Label label1;
        private Button btnHienTatCa;
        private Button btnLocKetQua;
        private DateTimePicker dtpDenNgay;
        private Label label2;
        private HelpProvider helpProvider1;
    }
}