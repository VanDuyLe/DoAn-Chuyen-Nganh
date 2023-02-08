using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _019101060.DTO;
using _019101060.DAO;

namespace _019101060.BUS
{
    class HoaDonBUS
    {
        public static void Them_HD(HoaDonDTO hd)
        {
            try
            {
                MessageBox.Show("Thêm thành công");
                HoaDonDAO.Them_HD(hd);
            }
            catch (Exception)
            {
                MessageBox.Show("Thêm không thành công");
            }
        }
        public static void Xoa_HD(HoaDonDTO hd)
        {
            if (MessageBox.Show("Bạn có muốn xoá hay không", "Xác Nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    MessageBox.Show("Xoá thành công");
                    HoaDonDAO.Xoa_HD(hd);
                }
                catch (Exception)
                {
                    MessageBox.Show("Xoá không thành công");
                }
            }
        }
        public static void CapNhat_HD(HoaDonDTO hd)
        {
            if (MessageBox.Show("Bạn có muốn cập nhật hay không", "Xác Nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                {
                    try
                    {
                        MessageBox.Show("Cập nhật thành công");
                        HoaDonDAO.CapNhat_HD(hd);
                    }
                    catch
                    {
                        MessageBox.Show("Cập nhật không thành công");
                    }
                }
            }
        }
    }
}
