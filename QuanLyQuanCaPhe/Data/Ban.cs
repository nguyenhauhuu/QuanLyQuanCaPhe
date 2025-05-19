using QuanLyQuanCaPhe.Data;
namespace QuanLyQuanCaPhe.Data
{
    public class Ban
    {
        public int ID { get; set; }
        public string TenBan { get; set; } = null!;
        public string TrangThai { get; set; } = "Trống"; // Trống, Đang phục vụ
        public int IDHoaDon { get; set; } = -1;

    }
}