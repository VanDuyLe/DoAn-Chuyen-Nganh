using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _019101060.DTO;

namespace _019101060.DAO
{
    class ChiTietHoaDonDAO
    {
        public static void Them_CTHD(CTHDDTO cthd)
        {
            string sql = "INSERT INTO CTHD([MaHD], [MaSP], [SoLuong], [Gia])VALUES ('" + cthd.mahd + "',N'" + cthd.masanpham + "','" + cthd.soluong + "','" + cthd.gia + "')";
            KetNoiCSDL.ThucThiTruyVan(sql);
        }
        public static void Xoa_CTHD(CTHDDTO cthd)
        {
            string sql = "delete from CTHD where MaSP='" + cthd.masanpham + "'";
            KetNoiCSDL.ThucThiTruyVan(sql);
        }
        public static void CapNhat_CTHD(CTHDDTO cthd)
        {
            string sql = "Update CTHD set MaSP= '" + cthd.masanpham + "',SoLuong='" + cthd.soluong + "',Gia='" + cthd.gia + "'  where MaSP = '" + cthd.masanpham + "'";
            KetNoiCSDL.ThucThiTruyVan(sql);
        }
        public static void CapNhatSoLuongKho(string sl,string masp)
        {
            string sql = "Update SANPHAM set SOLUONG = SOLUONG-'" + sl + "' WHERE MASP = '" + masp + "'";
            KetNoiCSDL.ThucThiTruyVan(sql);
        }
    }
}
