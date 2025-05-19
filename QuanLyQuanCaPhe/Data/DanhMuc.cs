using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCaPhe.Data
{
    public class DanhMuc
    {
        public int ID { get; set; }
        public string TenDanhMuc { get; set; } = null!;

        public virtual ICollection<ThucUong> ThucUong { get; } = new List<ThucUong>();
    }
}
