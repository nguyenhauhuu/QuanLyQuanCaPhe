using QuanLyQuanCaPhe.Data;

public class Ban
{
    public int ID { get; set; }
    public string TenBan { get; set; } = null!;
    public string TrangThai { get; set; } = "Trống"; // Trống, Đang phục vụ
    public virtual HoaDon HoaDon { get; set; } = null!;

}
