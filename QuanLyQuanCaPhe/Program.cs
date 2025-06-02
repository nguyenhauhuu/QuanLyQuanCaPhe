using Microsoft.EntityFrameworkCore;
using QuanLyQuanCaPhe.Data;
using QuanLyQuanCaPhe.Forms;
using QuanLyQuanCaPhe.Reports;
using BC = BCrypt.Net.BCrypt;

namespace QuanLyQuanCaPhe
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            //Tạo DbContext
            using (var context = new QLQCPContext())
            {
                context.Database.Migrate();
                // Seed dữ liệu mặc định (tài khoản admin)
                SeedInitialData(context);
            }


            ApplicationConfiguration.Initialize();
            Application.Run(new frmMain());
        }
        private static void SeedInitialData(QLQCPContext context)
        {
            if (!context.TaiKhoan.Any())
            {
                context.TaiKhoan.Add(new TaiKhoan
                {
                    TenDangNhap = "admin",
                    MatKhau = BC.HashPassword("123"),
                    TenDayDu = "Administrator",
                    QuyenTruyCap = "admin",
                    NgaySinh = new DateTime(1990, 1, 1),
                    HinhAnh = null
                });
                context.SaveChanges();
            }
        }
    }
}