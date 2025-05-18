namespace QuanLyQuanCaPhe.Data
{
    public class HoaDonChiTiet
    {
        public int ID { get; set; }
        public int HoaDonID { get; set; }
        public int SanPhamID { get; set; }
        public int SoLuong { get; set; }
        public decimal Gia { get; set; }
        public string? GhiChu { get; set; }

        public virtual HoaDon HoaDon { get; set; } = null!;
        public virtual ThucUong ThucUong { get; set; } = null!;
    }
}
