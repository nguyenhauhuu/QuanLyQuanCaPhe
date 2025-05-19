using QuanLyQuanCaPhe.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCaPhe.Forms
{
    public partial class frmChucNang : Form
    {
        QLQCPContext context = new QLQCPContext(); // Khởi tạo biến ngữ cảnh CSDL 

        public frmChucNang()
        {
            InitializeComponent();
        }

        private void LoadDanhSachBan()
        {
            flpDanhSachBan.Controls.Clear();

            var danhSachBan = context.Ban.ToList();

            foreach (var ban in danhSachBan)
            {
                var btn = new Button();
                btn.Width = 100;
                btn.Height = 120;

                btn.Text = $"{ban.TenBan}\n{ban.TrangThai}";
                btn.TextAlign = ContentAlignment.BottomLeft;
                btn.Font = new Font("Segoe UI", 10);

                

                Image rawImg = ban.TrangThai == "Trống" ? Properties.Resources.ban_trong : Properties.Resources.ban_dang_phuc_vu;
                btn.Image = new Bitmap(rawImg, new Size(70, 70)); // resize ảnh
                btn.ImageAlign = ContentAlignment.TopCenter;
                


                
                btn.Tag = ban.TenBan;

                btn.Click += BtnBan_Click;

                flpDanhSachBan.Controls.Add(btn);
            }

        }
        private void BtnBan_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            groupBox.Text = (string)btn!.Tag!;
            // Hiển thị chi tiết bàn, gọi hóa đơn, v.v.
            MessageBox.Show($"Click bàn ");
        }

        private void frmChucNang_Load(object sender, EventArgs e)
        {
            LoadDanhSachBan();
        }
    }
}
