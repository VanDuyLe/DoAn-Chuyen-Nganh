using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using _019101060.DTO;

namespace _019101060.DAO
{
    class ChucVuDAO
    {
        public static DataTable TTCHUCVU()
        {
            DataTable dt = new DataTable();
            string sql = "Select * From CHUCVU";
            dt = KetNoiCSDL.DocDuLieu(sql);
            return dt;
        }
        public static void XoaChucVu(ChucVuDTO cv)
        {
            string sql = "Delete From CHUCVU where MaChucVu='" + cv.machucvu + "'";
            KetNoiCSDL.ThucThiTruyVan(sql);
        }
        public static void CapNhatChucVu(ChucVuDTO cv)
        {
            string sql = "Update CHUCVU set TenChucVu=N'" + cv.tenchucvu + "' where MaChucVu = '" + cv.machucvu + "'";
            KetNoiCSDL.ThucThiTruyVan(sql);
        }
        public static void ThemChucVu(ChucVuDTO cv)
        {
            string sql = "INSERT INTO CHUCVU([MaChucVu], [TenChucVu])VALUES('" + cv.machucvu + "',N'" + cv.tenchucvu + "')";
            KetNoiCSDL.ThucThiTruyVan(sql);
        }
        public static DataTable MaChucVuMAX()
        {
            DataTable dt = new DataTable();
            string sql = "Select top 1 MaChucVu From CHUCVU order by MaChucVu desc";
            dt = KetNoiCSDL.DocDuLieu(sql);
            return dt;
        }
        public static DataTable CHUCVUCT(string cvu)
        {
            DataTable dt = new DataTable();
            string sql = "Select * From CHUCVU where MaChucVu = '" + cvu + "'";
            dt = KetNoiCSDL.DocDuLieu(sql);
            return dt;
        }
        public static DataTable TTCHUCVUCT(string cvu)
        {
            DataTable dt = new DataTable();
            string sql = "Select * From CHUCVU where MaChucVu = '" + cvu + "'";
            dt = KetNoiCSDL.DocDuLieu(sql);
            return dt;
        }
    }
}
