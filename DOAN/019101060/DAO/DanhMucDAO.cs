using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using _019101060.DTO;

namespace _019101060.DAO
{
    class DanhMucDAO
    {
        public static DataTable TTDANHMUC()
        {
            DataTable dt = new DataTable();
            string sql = "Select * From DANHMUC";
            dt = KetNoiCSDL.DocDuLieu(sql);
            return dt;
        }
        public static DataTable TTDANHMUCTREE()
        {
            DataTable dt = new DataTable();
            string sql = "Select * From DANHMUC";
            dt = KetNoiCSDL.DocDuLieu(sql);
            return dt;
        }
        public static DataTable TTDANHMUCCT(string mdm)
        {
            DataTable dt = new DataTable();
            string sql = "select MaDanhMuc, TenDanhMuc from DANHMUC where MaDanhMuc = '" + mdm + "'";
            dt = KetNoiCSDL.DocDuLieu(sql);
            return dt;
        }
        public static void XOADANHMUC(DanhMucDTO dm)
        {
            string sql = "Delete From DANHMUC where MaDanhMuc='" + dm.madanhmuc + "'";
            KetNoiCSDL.ThucThiTruyVan(sql);
        }
        public static void CAPNHATDANHMUC(DanhMucDTO dm)
        {
            string sql = "Update DANHMUC set TenDanhMuc=N'" + dm.tendanhmuc + "' where MaDanhMuc = '" + dm.madanhmuc + "'";
            KetNoiCSDL.ThucThiTruyVan(sql);
        }
        public static void THEMDANHMUC(DanhMucDTO dm)
        {
            string sql = "INSERT INTO DANHMUC([MaDanhMuc], [TenDanhMuc])VALUES('" + dm.madanhmuc + "',N'" + dm.tendanhmuc + "')";
            KetNoiCSDL.ThucThiTruyVan(sql);
        }
        public static DataTable MADANHMUCMAX()
        {
            DataTable dt = new DataTable();
            string sql = "Select top 1 MaDanhMuc From DANHMUC order by MaDanhMuc desc";
            dt = KetNoiCSDL.DocDuLieu(sql);
            return dt;
        }
    }
}
