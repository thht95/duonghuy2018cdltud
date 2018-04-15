using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanVeXemPhim
{
    public class Session
    {
        public static string TenNhanvien;
        public static bool? IsAdmin;
        public static int MaNhanvien;
        public static QLBVXPEntities dbContxt = new QLBVXPEntities();
    }
}
