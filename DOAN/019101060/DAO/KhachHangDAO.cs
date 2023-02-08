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
    class KhachHangDAO
    {
        public static DataTable TT_KHACHHANG()
        {
            DataTable dt = new DataTable();
            string sql = "Select makh, tenkh, diachikh, sdtkh, gioitinhkh, ngaysinhkh, hotennv from KHACHHANG kh, NHANVIEN nv where kh.MANHANVIEN = nv.MANHANVIEN";
            dt = KetNoiCSDL.DocDuLieu(sql);
            return dt;
        }
        public static DataTable TTKhachHangChiTiet(string mkh)
        {
            DataTable dt = new DataTable();
            string sql = "Select makh, tenkh, diachikh, sdtkh, gioitinhkh, ngaysinhkh, hotennv from KHACHHANG kh, NHANVIEN nv where kh.MANHANVIEN = nv.MANHANVIEN and MAKH = '"+ mkh +"'";
            dt = KetNoiCSDL.DocDuLieu(sql);
            return dt;
        }
        public static DataTable MaKhachHangMax()
        {
            DataTable dt = new DataTable();
            string sql = "Select top 1 Makh From KhachHang order by Makh desc";
            dt = KetNoiCSDL.DocDuLieu(sql);
            return dt;
        }
        public static void ThemKhachHang(KhachHangDTO kh)
        {
            string sql = "INSERT INTO KHACHHANG([MAKH], [TENKH], [DIACHIKH], [GIOITINHKH], [SDTKH], NGAYSINHKH, [MANHANVIEN]) VALUES ('"+ kh.makh +"', N'"+ kh.tenkh +"', N'"+ kh.diachikh +"', '"+ kh.gioitinh +"', '"+ kh.dienthoai +"','"+ kh.ngaysinh +"', '"+ kh.manv +"')";            
            KetNoiCSDL.ThucThiTruyVan(sql);
        }
        public static void CapNhatKhachHang(KhachHangDTO kh)
        {
            string sql = "Update KHACHHANG set TENKH=N'" + kh.tenkh + "', DIACHIKH=N'" + kh.diachikh + "', GIOITINHKH='" + kh.gioitinh + "', SDTKH='" + kh.dienthoai + "', NGAYSINHKH='" + kh.ngaysinh + "',MANHANVIEN='" + kh.manv + "' where MAKH= '" + kh.makh + "'";
            KetNoiCSDL.ThucThiTruyVan(sql);
        }
        public static void XoaKhachHang(KhachHangDTO kh)
        {
            string sql = "Delete from KHACHHANG where MAKH='" + kh.makh + "'";
            KetNoiCSDL.ThucThiTruyVan(sql);
        }
    }
}
