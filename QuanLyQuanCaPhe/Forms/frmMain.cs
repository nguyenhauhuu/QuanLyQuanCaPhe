using QuanLyBanHang.Data;
using QuanLyQuanCaPhe.Forms;

namespace QuanLyQuanCaPhe
{
    public partial class frmMain : Form
    {

        QLQCPConnection context = new QLQCPConnection();
        frmDangNhap? dangNhap = null;
        string hoVaTenNhanVien = ""; 

        public frmMain()
        {
            InitializeComponent();
        }

        

    }
}
