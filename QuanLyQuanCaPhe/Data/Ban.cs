using QuanLyQuanCaPhe.Data;
namespace QuanLyQuanCaPhe.Data
{
    public class Ban
    {
        public int ID { get; set; }
        public string TenBan { get; set; } = null!;
        public int TrangThai { get; set; } = 0; // Trống=0, Đang phục vụ=1
        public virtual ICollection<HoaDon> HoaDon { get;} = new List<HoaDon>();
    }
}