using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCaPhe.Data
{
    public class Kho
    {
        public int ID { get; set; }
        public int NguyenLieuID { get; set; }
        public string MoTa { get; set; } = null!;
        public int SoLuong { get; set; }
        public string DonVi { get; set; } = null!;
        public decimal Gia { get; set; }
        public DateTime NgayHetHan { get; set; }

        public virtual NguyenLieu NguyenLieu { get; set; } = null!;
    }
}
