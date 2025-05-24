namespace QuanLyQuanCaPhe.Data
{
    public class TaiKhoan
    {
        public int ID { get; set; }
        public string TenDangNhap { get; set; } = null!;
        public string MatKhau { get; set; } = null!;
        public string TenDayDu { get; set; } = null!;
        public string QuyenTruyCap { get; set; } = "user"; // admin, user
        public DateTime NgaySinh { get; set; }
        public string? HinhAnh { get; set; }

        public virtual ICollection<HoaDon> HoaDon { get; } = new List<HoaDon>();
    }
}
