using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using _019101060.DTO;

namespace _019101060.DAO
{
    class NguoiDungDAO
    {
        public static DataTable TenNV(string tendn)
        {
            DataTable dt = new DataTable();
            string sql = "Select HOTENNV from TaiKhoan, NHANVIEN where TaiKhoan.MANHANVIEN = NHANVIEN.MANHANVIEN and TenTaiKhoan = '"+ tendn + "'";
            dt = KetNoiCSDL.DocDuLieu(sql);
            return dt;
        }

        public static DataTable TTNguoiDung(string tendn, string mk)
        {
            DataTable dt = new DataTable();
            string sql = "select * from TaiKhoan where TenTaiKhoan='" + tendn + "' and MatKhau='" + mk + "'";
            dt = KetNoiCSDL.DocDuLieu(sql);
            return dt;
        }
        public static DataTable ThemNguoiDung_Check(String nd)
        {
            string sql = "Select * From TaiKhoan where TenTaiKhoan = '" + nd + "' ";
            DataTable dt = new DataTable();
            dt = KetNoiCSDL.DocDuLieu(sql);
            return dt;
        }
        public static void ThemNguoiDung(NguoiDungDTO nd)
        {
            string sql = "Insert into TaiKhoan([TenTaiKhoan],[MatKhau],[MANHANVIEN],[MACHUCVU])Values('"+ nd.taikhoan +"', '"+ nd.matkhau +"', '"+ nd.manhanvien +"','"+ nd.machucvu +"')";
            DataTable dt = new DataTable();
            KetNoiCSDL.ThucThiTruyVan(sql);
        }
        public static DataTable TTTaiKhoan()
        {
            DataTable dt = new DataTable();
            string sql = "Select TenTaiKhoan, MatKhau, HOTENNV, TENCHUCVU from TaiKhoan, NHANVIEN, CHUCVU where TaiKhoan.MANHANVIEN = NHANVIEN.MANHANVIEN and TaiKhoan.MACHUCVU = CHUCVU.MACHUCVU";
            dt = KetNoiCSDL.DocDuLieu(sql);
            return dt;
        }
        public static DataTable TTNguoiDungCT(string mtk)
        {
            DataTable dt = new DataTable();
            string sql = "Select TenTaiKhoan, MatKhau, HOTENNV, TENCHUCVU from TaiKhoan, NHANVIEN, CHUCVU where TaiKhoan.MANHANVIEN = NHANVIEN.MANHANVIEN and TaiKhoan.MACHUCVU = CHUCVU.MACHUCVU and TenTaiKhoan = '"+ mtk + "'";
            dt = KetNoiCSDL.DocDuLieu(sql);
            return dt;
        }
        public static void CapNhatTaiKhoan(NguoiDungDTO tk)
        {
            string sql = "Update TaiKhoan set  MatKhau=N'" + tk.matkhau + "', MANHANVIEN='" + tk.manhanvien + "', MACHUCVU='" + tk.machucvu + "' where TenTaiKhoan=N'" + tk.taikhoan + "'";
            KetNoiCSDL.ThucThiTruyVan(sql);
        }
        public static void XoaTaiKhoan(NguoiDungDTO tk)
        {
            string sql = "Delete from TaiKhoan where TenTaiKhoan='" + tk.taikhoan + "'";
            KetNoiCSDL.ThucThiTruyVan(sql);
        }
    }
}
