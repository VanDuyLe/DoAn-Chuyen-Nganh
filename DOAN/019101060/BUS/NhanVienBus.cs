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
    class NhanVienBUS
    {
        public static void ThemNhanVien(NhanVienDTO nv)
        {
            try
            {
                NhanVienDAO.ThemNhanVien(nv);
            }
            catch
            {
                MessageBox.Show("Thêm nhân viên không thành công");
            }
        }
        public static void CapNhatNhanVien(NhanVienDTO nv)
        {
            try
            {
                NhanVienDAO.CapNhatNhanVien(nv);
            }
            catch
            {
                MessageBox.Show("Cập nhật nhân viên không thành công");
            }
        }
        public static void XoaNhanVien(NhanVienDTO nv)
        {
            try
            {
                NhanVienDAO.XoaNhanVien(nv);
            }
            catch
            {
                MessageBox.Show("Xóa nhân viên không thành công");
            }
        }
    }
}
