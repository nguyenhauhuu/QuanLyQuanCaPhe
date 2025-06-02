namespace QuanLyQuanCaPhe.Reports
{
    partial class frmThongKeThucUong
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
            btnThongKe = new ReaLTaiizor.Controls.AloneButton();
            cboTieuChi = new ReaLTaiizor.Controls.AloneComboBox();
            dtpTuNgay = new DateTimePicker();
            label1 = new Label();
            dtpDenNgay = new DateTimePicker();
            label2 = new Label();
            reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            helpProvider1 = new HelpProvider();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnThongKe);
            panel1.Controls.Add(cboTieuChi);
            panel1.Controls.Add(dtpTuNgay);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dtpDenNgay);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 53);
            panel1.TabIndex = 0;
            // 
            // btnThongKe
            // 
            btnThongKe.BackColor = Color.Transparent;
            btnThongKe.EnabledCalc = true;
            btnThongKe.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnThongKe.ForeColor = Color.Black;
            btnThongKe.Location = new Point(608, 12);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Size = new Size(113, 24);
            btnThongKe.TabIndex = 9;
            btnThongKe.Text = "Thống kê";
            btnThongKe.Click += btnThongKe_Click;
            // 
            // cboTieuChi
            // 
            cboTieuChi.DrawMode = DrawMode.OwnerDrawFixed;
            cboTieuChi.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTieuChi.EnabledCalc = true;
            cboTieuChi.FormattingEnabled = true;
            cboTieuChi.ItemHeight = 20;
            cboTieuChi.Items.AddRange(new object[] { "Hiện tất cả", "Top 5", "Bottom 5" });
            cboTieuChi.Location = new Point(489, 11);
            cboTieuChi.Name = "cboTieuChi";
            cboTieuChi.Size = new Size(103, 26);
            cboTieuChi.TabIndex = 8;
            // 
            // dtpTuNgay
            // 
            dtpTuNgay.CustomFormat = "dd/MM/yyyy";
            dtpTuNgay.Format = DateTimePickerFormat.Custom;
            dtpTuNgay.Location = new Point(149, 12);
            dtpTuNgay.Name = "dtpTuNgay";
            dtpTuNgay.Size = new Size(116, 23);
            dtpTuNgay.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(91, 16);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 4;
            label1.Text = "Từ ngày:";
            // 
            // dtpDenNgay
            // 
            dtpDenNgay.CustomFormat = "dd/MM/yyyy";
            dtpDenNgay.Format = DateTimePickerFormat.Custom;
            dtpDenNgay.Location = new Point(352, 13);
            dtpDenNgay.Name = "dtpDenNgay";
            dtpDenNgay.Size = new Size(116, 23);
            dtpDenNgay.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(286, 16);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 3;
            label2.Text = "Đến ngày:";
            // 
            // reportViewer
            // 
            reportViewer.Dock = DockStyle.Fill;
            reportViewer.Location = new Point(0, 53);
            reportViewer.Name = "ReportViewer";
            reportViewer.ServerReport.BearerToken = null;
            reportViewer.Size = new Size(800, 397);
            reportViewer.TabIndex = 0;
            // 
            // frmThongKeThucUong
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(reportViewer);
            Controls.Add(panel1);
            Name = "frmThongKeThucUong";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thống kê thức uống";
            WindowState = FormWindowState.Maximized;
            Load += frmThongKeThucUong_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        private Panel panel1;
        private DateTimePicker dtpTuNgay;
        private Label label1;
        private DateTimePicker dtpDenNgay;
        private Label label2;
        private ReaLTaiizor.Controls.AloneComboBox cboTieuChi;
        private ReaLTaiizor.Controls.AloneButton btnThongKe;
        private HelpProvider helpProvider1;
    }
}