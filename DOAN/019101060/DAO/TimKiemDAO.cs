using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace _019101060.DAO
{
    class TimKiemDAO
    {
        public static DataTable TTSPtimkiem(string tensp)
        {
            DataTable dt = new DataTable();
            string sql = "Select * From SanPham where TenSanPham like N'%" + tensp + "%'";
            dt = KetNoiCSDL.DocDuLieu(sql);
            return dt;
        }
        public static DataTable TTSP()
        {
            DataTable dt = new DataTable();
            string sql = "Select * From SanPham ";
            dt = KetNoiCSDL.DocDuLieu(sql);
            return dt;
        }
    }
}
