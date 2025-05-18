namespace QuanLyQuanCaPhe.Data
{
    public class NguyenLieu
    {
        public int ID { get; set; }
        public string TenNguyenLieu { get; set; } = null!;

        public virtual ICollection<Kho> Kho { get; } = new List<Kho>();
    }
}