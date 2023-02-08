using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _019101060.DAO;
using _019101060.DTO;

namespace _019101060.BUS
{
    class KhachHangBUS
    {
        public static void ThemKhachHang(KhachHangDTO kh)
        {
            try
            {
                KhachHangDAO.ThemKhachHang(kh);
            }
            catch
            {
                MessageBox.Show("Thêm khách hàng không thành công");
            }
        }
        public static void CapNhatKhachHang(KhachHangDTO kh)
        {
            try
            {
                KhachHangDAO.CapNhatKhachHang(kh);
            }
            catch
            {
                MessageBox.Show("Cập nhật Khách hàng không thành công");
            }
        }
        public static void XoaNhanVien(KhachHangDTO kh)
        {
            try
            {
                KhachHangDAO.XoaKhachHang(kh);
            }
            catch
            {
                MessageBox.Show("Xóa Khách hàng không thành công");
            }
        }
    }
}
