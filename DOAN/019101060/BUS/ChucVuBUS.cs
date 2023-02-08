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
    class ChucVuBUS
    {
        public static void ThemChucVu(ChucVuDTO cv)
        {
            try
            {
                ChucVuDAO.ThemChucVu(cv);
            }
            catch
            {
                MessageBox.Show("Thêm chức vụ không thành công");
            }
        }
        public static void XoaChucVu(ChucVuDTO cv)
        {
            try
            {
                ChucVuDAO.XoaChucVu(cv);
            }
            catch
            {
                MessageBox.Show("Xóa chức vụ không thành công");
            }
        }
        public static void CapNhatChucVu(ChucVuDTO cv)
        {
            try
            {
                ChucVuDAO.CapNhatChucVu(cv);
            }
            catch
            {
                MessageBox.Show("Cập nhật chức vụ không thành công");
            }
        }
    }
}
