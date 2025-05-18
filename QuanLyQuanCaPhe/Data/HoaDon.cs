namespace QuanLyQuanCaPhe.Data
{
    public class HoaDon
    {
        public int ID { get; set; }
        public int TaiKhoanID { get; set; }
        public int? KhachHangID { get; set; }
        public int BanID { get; set; }
        public DateTime NgayLap { get; set; }
        public decimal GiamGia { get; set; } = 0;
        public decimal TongCong { get; set; }

        public virtual TaiKhoan TaiKhoan { get; set; } = null!;
        public virtual Ban Ban { get; set; } = null!;
        public virtual ICollection<HoaDonChiTiet> HoaDonChiTiet { get; } = new List<HoaDonChiTiet>();
    }
}
