using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _019101060.DTO;
using System.Data;

namespace _019101060.DAO
{
    class HoaDonDAO
    {
        public static DataTable ChiTietHoaDonChiTiet(string msp)
        {
            DataTable dt = new DataTable();
            string sql = "select sp.MaSP, sp.TenSanPham, sp.Gia, hd.SoLuong, (hd.SoLuong*sp.Gia) ThanhTien from SANPHAM sp, CTHD hd where hd.MaSP =  sp.MaSP and hd.MaSP=  '" + msp + "'";
            dt = KetNoiCSDL.DocDuLieu(sql);
            return dt;
        }
        public static DataTable TTChiTietHoaDon(string mhd)
        {
            DataTable dt = new DataTable();
            string sql = "select sp.MASP, ct.MaHD, sp.TenSanPham , ct.SoLuong, ct.Gia, ct.SoLuong*sp.Gia ThanhTien from CTHD ct, SANPHAM sp where sp.MaSP = ct.MaSP and  ct.MaHD = '" + mhd + "'";
            dt = KetNoiCSDL.DocDuLieu(sql);
            return dt;
        }
        public static DataTable TTHoaDonChiTiet(string mhd)
        {
            DataTable dt = new DataTable();
            string sql = "select hd.MaHD, hd.NgayLapHD, nv.HoTenNV, kh.TenKH  from HOADON hd, NHANVIEN nv, KHACHHANG kh where hd.MaKH = kh.MaKH and hd.MaNhanVien = nv.MaNhanVien and hd.MaHD =  '" + mhd + "'";
            dt = KetNoiCSDL.DocDuLieu(sql);
            return dt;
        }
        public static DataTable TTHoaDon()
        {
            DataTable dt = new DataTable();
            string sql = "select hd.MaHD, hd.NgayLapHD, nv.HoTenNV, kh.TenKH  from HOADON hd, NHANVIEN nv, KHACHHANG kh where hd.MaKH = kh.MaKH and hd.MaNhanVien = nv.MaNhanVien";
            dt = KetNoiCSDL.DocDuLieu(sql);
            return dt;
        }
        public static DataTable MaHoaDonMAX()
        {
            DataTable dt = new DataTable();
            string sql = "Select top 1 MaHD From HOADON order by MaHD desc";
            dt = KetNoiCSDL.DocDuLieu(sql);
            return dt;
        }
        public static void Them_HD(HoaDonDTO hd)
        {
            string sql = "INSERT INTO HOADON([MaHD], [NgayLapHD], [MaNhanVien], [MaKH])VALUES ('" + hd.mahd + "','" + hd.ngaylaphd + "','" + hd.manhanvien + "','" + hd.makhachhang + "')";
            KetNoiCSDL.ThucThiTruyVan(sql);
        }
        public static void Xoa_HD(HoaDonDTO hd)
        {
            string sql = "delete from HoaDon where MaHD='" + hd.mahd + "'";
            KetNoiCSDL.ThucThiTruyVan(sql);
        }
        public static void CapNhat_HD(HoaDonDTO hd)
        {
            string sql = "Update HoaDon set MaHD= '" + hd.mahd + "',NgayLapHD='" + hd.ngaylaphd + "',MaNhanVien='" + hd.manhanvien + "', MaKH='" + hd.makhachhang + "'   where MaHD = '" + hd.mahd + "'";
            KetNoiCSDL.ThucThiTruyVan(sql);
        }
    }
}
