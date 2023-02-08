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
    class DanhMucBUS
    {
        public static void THEMDANHMUC(DanhMucDTO dm)
        {
            try
            {
                DanhMucDAO.THEMDANHMUC(dm);
            }
            catch
            {
                MessageBox.Show("Thêm danh mục không thành công");
            }
        }
        public static void XOADANHMUC(DanhMucDTO dm)
        {
            try
            {
                DanhMucDAO.XOADANHMUC(dm);
            }
            catch
            {
                MessageBox.Show("Xóa danh mục không thành công");
            }
        }
        public static void CAPNHATDANHMUC(DanhMucDTO dm)
        {
            try
            {
                DanhMucDAO.CAPNHATDANHMUC(dm);
            }
            catch
            {
                MessageBox.Show("Cập danh mục cấp không thành công");
            }
        }
    }
}
