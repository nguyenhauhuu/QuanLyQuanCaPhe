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
            reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            dtpDenNgay = new DateTimePicker();
            label2 = new Label();
            dtpTuNgay = new DateTimePicker();
            label1 = new Label();
            cboLoc = new ReaLTaiizor.Controls.AloneComboBox();
            btnThongKe = new ReaLTaiizor.Controls.AloneButton();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnThongKe);
            panel1.Controls.Add(cboLoc);
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
            // reportViewer
            // 
            reportViewer.Dock = DockStyle.Fill;
            reportViewer.Location = new Point(0, 53);
            reportViewer.Name = "ReportViewer";
            reportViewer.ServerReport.BearerToken = null;
            reportViewer.Size = new Size(800, 397);
            reportViewer.TabIndex = 0;
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
            // cboLoc
            // 
            cboLoc.DrawMode = DrawMode.OwnerDrawFixed;
            cboLoc.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLoc.EnabledCalc = true;
            cboLoc.FormattingEnabled = true;
            cboLoc.ItemHeight = 20;
            cboLoc.Location = new Point(489, 11);
            cboLoc.Name = "cboLoc";
            cboLoc.Size = new Size(103, 26);
            cboLoc.TabIndex = 8;
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
            // frmThongKeThucUong
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(reportViewer);
            Controls.Add(panel1);
            Name = "frmThongKeThucUong";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmThongKeThucUong";
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
        private ReaLTaiizor.Controls.AloneComboBox cboLoc;
        private ReaLTaiizor.Controls.AloneButton btnThongKe;
    }
}