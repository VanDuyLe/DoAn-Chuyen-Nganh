using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using _019101060.DTO;
using _019101060.BUS;

namespace _019101060.DAO
{
    class SanPhamDAO
    {
        public static DataTable TK_SanPham(String tenSanPham)
        {
            DataTable dt = new DataTable();
            string sql = "Select * From SanPham where TenSanPham like N'%"+ tenSanPham + "%'";
            dt = KetNoiCSDL.DocDuLieu(sql);
            return dt;
        }
        public static DataTable GiaSanPham(string gia)
        {
            DataTable dt = new DataTable();
            string sql = " Select MASP, TenSanPham, Gia From SANPHAM where MASP = '" + gia + "'";
            dt = KetNoiCSDL.DocDuLieu(sql);
            return dt;
        }
        public static DataTable TT_SanPham()
        {
            DataTable dt = new DataTable();
            string sql = "Select * From SanPham";
            dt = KetNoiCSDL.DocDuLieu(sql);
            return dt;
        }
        public static DataTable TTSanPhanTree()
        {
            DataTable dt = new DataTable();
            string sql = "Select * From SANPHAM";
            dt = KetNoiCSDL.DocDuLieu(sql);
            return dt;
        }
        public static DataTable TTSanPhamTheoDanhMuc(string mdm)
        {
            DataTable dt = new DataTable();
            string sql = "select * from SanPham where MaDanhMuc='" + mdm + "'";
            dt = KetNoiCSDL.DocDuLieu(sql);
            return dt;
        }
        public static DataTable TTChiTietSanPhamTree(string msp)
        {
            DataTable dt = new DataTable();
            string sql = "Select masp, tensanpham, gia, soluong, hangsx, tendanhmuc from SANPHAM sp, DANHMUC dm where sp.MADANHMUC = dm.MADANHMUC  and MASP = '"+ msp +"'";
            dt = KetNoiCSDL.DocDuLieu(sql);
            return dt;
        }
        public static DataTable MaSanPhamMax()
        {
            DataTable dt = new DataTable();
            string sql = "Select top 1 MaSP From SANPHAM order by MaSP desc";
            dt = KetNoiCSDL.DocDuLieu(sql);
            return dt;
        }
        public static void ThemSanPham(SanPhamDTO sp)
        {
            string sql = "INSERT INTO SANPHAM([MASP], [TENSANPHAM], [GIA], [SOLUONG], [HANGSX], [MADANHMUC] ) VALUES ('"+ sp.masp +"', '"+ sp.tensp +"', '"+ sp.gia +"', '"+ sp.soluong +"', '"+ sp.hangsx +"','"+ sp.madanhmuc +"')";
            KetNoiCSDL.ThucThiTruyVan(sql);
        }
        public static void CapNhatSanPham(SanPhamDTO sp)
        {
            string sql = "Update SANPHAM set TENSANPHAM=N'" + sp.tensp + "', GIA=N'" + sp.gia + "', SOLUONG='" + sp.soluong + "', HANGSX='" + sp.hangsx + "',MADANHMUC='" + sp.madanhmuc + "' where MASP= '" + sp.masp + "'";
            KetNoiCSDL.ThucThiTruyVan(sql);
        }
        public static void XoaSanPham(SanPhamDTO sp)
        {
            string sql = "Delete from SANPHAM where MASP='" + sp.masp + "'";
            KetNoiCSDL.ThucThiTruyVan(sql);
        }
    }
}
