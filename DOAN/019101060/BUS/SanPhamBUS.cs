using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _019101060.DAO;
using _019101060.DTO;
using System.Windows.Forms;

namespace _019101060.BUS
{
    class SanPhamBUS
    {
        public static void ThemSanPham(SanPhamDTO sp)
        {
            try
            {
                SanPhamDAO.ThemSanPham(sp);
            }
            catch
            {
                MessageBox.Show("Thêm sản phẩm không thành công");
            }
        }
        public static void CapNhatSanPham(SanPhamDTO sp)
        {
            try
            {
                SanPhamDAO.CapNhatSanPham(sp);
            }
            catch
            {
                MessageBox.Show("Cập nhật sản phẩm không thành công");
            }
        }
        public static void XoaSanPham(SanPhamDTO sp)
        {
            try
            {
                SanPhamDAO.XoaSanPham(sp);
            }
            catch
            {
                MessageBox.Show("Xóa sản phẩm không thành công");
            }
        }
    }
}
