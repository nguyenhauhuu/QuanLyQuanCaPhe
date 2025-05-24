using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyQuanCaPhe.Data
{
    public class HoaDonChiTiet
    {
        public int ID { get; set; }
        public int HoaDonID { get; set; }
        public int ThucUongID { get; set; }
        public int SoLuong { get; set; }
        public decimal DonGia { get; set; }
        public string? GhiChu { get; set; }
        public virtual HoaDon HoaDon { get; set; } = null!;
        public virtual ThucUong ThucUong { get; set; } = null!;

        [NotMapped]
        public class DanhSachHoaDonChiTiet
        {
            public int ID { get; set; }
            public int HoaDonID { get; set; }
            public int ThucUongID { get; set; }
            public string TenThucUong { get; set; } = null!; // Bổ sung thêm 
            public int SoLuong { get; set; }
            public decimal DonGia { get; set; }
            public string? GhiChu { get; set; }
            public decimal ThanhTien { get; set; }   // Bổ sung thêm 
        }
    }
}
