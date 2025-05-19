using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace QuanLyQuanCaPhe.Data
{
    public class QLQCPContext : DbContext
    {
        public DbSet<Ban> Ban { get; set; }
        public DbSet<NguyenLieu> NguyenLieu { get; set; }
        public DbSet<DanhMuc> DanhMuc { get; set; }         
        public DbSet<ThucUong> ThucUong { get; set; }
        public DbSet<Kho> Kho { get; set; }               
        public DbSet<TaiKhoan> TaiKhoan { get; set; }
        public DbSet<HoaDon> HoaDon { get; set; }
        public DbSet<HoaDonChiTiet> HoaDonChiTiet { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["QLQCPConnection"].ConnectionString);
        }
    }
}