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
    class ChiTietHoaDonBUS
    {
        public static void Them_CTHD(CTHDDTO cv)
        {
            try
            {
                MessageBox.Show("Thêm thành công");
                ChiTietHoaDonDAO.Them_CTHD(cv);
            }
            catch (Exception)
            {
                MessageBox.Show("Thêm không thành công");
            }
        }
        public static void Xoa_ChucVu(CTHDDTO cv)
        {
            if (MessageBox.Show("Bạn có muốn xoá hay không", "Xác Nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    MessageBox.Show("Xoá thành công");
                    ChiTietHoaDonDAO.Xoa_CTHD(cv);
                }
                catch (Exception)
                {
                    MessageBox.Show("Xoá không thành công");
                }
            }
        }
        public static void CapNhat_ChucVu(CTHDDTO cv)
        {
            if (MessageBox.Show("Bạn có muốn cập nhật hay không", "Xác Nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                {
                    try
                    {
                        MessageBox.Show("Cập nhật thành công");
                        ChiTietHoaDonDAO.CapNhat_CTHD(cv);
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
