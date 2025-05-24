namespace QuanLyQuanCaPhe.Data
{
    public class HoaDon
    {
        public int ID { get; set; }
        public int TaiKhoanID { get; set; }
        public int BanID { get; set; }
        public DateTime NgayLap { get; set; }
        public decimal GiamGia { get; set; } = 0;
        public int TrangThaiThanhToan { get; set; } = 0; // 0=ChuaThanhToan; 1=ThanhToanBangTienMat; 2=ThanhToanBangChuyenKhoanNganHang
        public virtual Ban Ban { get; set; } = null!;
        public virtual TaiKhoan TaiKhoan { get; set; } = null!;
        public virtual ICollection<HoaDonChiTiet> HoaDonChiTiet { get; } = new List<HoaDonChiTiet>();
    }
}
