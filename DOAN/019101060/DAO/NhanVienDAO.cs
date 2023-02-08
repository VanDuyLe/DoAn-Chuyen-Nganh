using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using _019101060.DTO;

namespace _019101060.DAO
{
    class NhanVienDAO
    {
        public static DataTable TTNhanVien()
        {
            DataTable dt = new DataTable();
            string sql = "Select * From NhanVien";
            dt = KetNoiCSDL.DocDuLieu(sql);
            return dt;
        }
        public static DataTable TTNhanVienChiTiet()
        {
            DataTable dt = new DataTable();
            string sql = "Select manhanvien, hotennv, diachinv, ngaysinh, gioitinh, sdtnv,  tenchucvu from NhanVien nv, ChucVu cv where nv.MACHUCVU=cv.MACHUCVU ";
            dt = KetNoiCSDL.DocDuLieu(sql);
            return dt;
        }
        public static DataTable TTNhanVienCT(string mnv)
        {
            DataTable dt = new DataTable();
            string sql = "Select manhanvien, hotennv, diachinv, ngaysinh, gioitinh, sdtnv,  tenchucvu from NhanVien nv, ChucVu cv where nv.MaChucVu = cv.MaChucVu and MaNhanVien ='" + mnv + "'";
            dt = KetNoiCSDL.DocDuLieu(sql);
            return dt;
        }
        public static DataTable MaNhanVienMax()
        {
            DataTable dt = new DataTable();
            string sql = "Select top 1 MaNhanVien From NHANVIEN order by MaNhanVien desc";
            dt = KetNoiCSDL.DocDuLieu(sql);
            return dt;
        }
        public static void ThemNhanVien(NhanVienDTO nv)
        {
            string sql = "INSERT INTO NHANVIEN([MaNhanVien], [HoTennv], [DiaChinv], [NgaySinh], [GioiTinh], [SDTnv], [MaChucVu])VALUES('"+ nv.manhanvien +"',N'"+ nv.hoten +"',N'"+ nv.diachi +"','"+ nv.ngaysinh +"','"+ nv.gioitinh +"','"+ nv.dienthoai +"','"+ nv.machucvu +"')";
            KetNoiCSDL.ThucThiTruyVan(sql);
        }
        public static void CapNhatNhanVien(NhanVienDTO nv)
        {
            string sql = "Update NHANVIEN set HoTennv=N'" + nv.hoten + "', DiaChinv=N'" + nv.diachi + "', NgaySinh='" + nv.ngaysinh + "', GioiTinh='" + nv.gioitinh + "', SDTnv='" + nv.dienthoai + "',MaChucVu='" + nv.machucvu + "' where MaNhanVien= '" + nv.manhanvien + "'";
            KetNoiCSDL.ThucThiTruyVan(sql);
        }
        public static void XoaNhanVien(NhanVienDTO nv)
        {
            string sql = "Delete from NHANVIEN where MaNhanVien='" + nv.manhanvien + "'";
            KetNoiCSDL.ThucThiTruyVan(sql);
        }
    }
}
