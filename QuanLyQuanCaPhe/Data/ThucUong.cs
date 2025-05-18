namespace QuanLyQuanCaPhe.Data
{
    public class ThucUong
    {
        public int ID { get; set; }
        public int DanhMucID { get; set; }
        public string TenThucUong { get; set; } = null!;
        public int DonGia { get; set; }

        public virtual DanhMuc DanhMuc { get; set; } = null!;
        public virtual ICollection<HoaDonChiTiet> HoaDonChiTiet { get; } = new List<HoaDonChiTiet>();
    }
}
