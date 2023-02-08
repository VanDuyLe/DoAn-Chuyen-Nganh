using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _019101060.DTO;
using _019101060.DAO;
using System.Windows.Forms;

namespace _019101060.BUS
{
    class NguoiDungBUS
    {
        public static void ThemNguoiDung(NguoiDungDTO tk)
        {
            try
            {
                MessageBox.Show("Tạo tài khoản thành công");
                NguoiDungDAO.ThemNguoiDung(tk);
            }
            catch (Exception)
            {
                MessageBox.Show("Tạo tài khoản không thành công");
            }
        }
        public static void CapNhatTaiKhoan(NguoiDungDTO tk)
        {
            try
            {
                MessageBox.Show("Cập nhật tài khoản thành công");
                NguoiDungDAO.CapNhatTaiKhoan(tk);
            }
            catch (Exception)
            {
                MessageBox.Show("Cập nhật tài khoản không thành công");
            }
        }
        public static void XoaTaiKhoan(NguoiDungDTO tk)
        {
            try
            {
                MessageBox.Show("Xóa tài khoản thành công");
                NguoiDungDAO.XoaTaiKhoan(tk);
            }
            catch (Exception)
            {
                MessageBox.Show("Xóa tài khoản không thành công");
            }
        }
    }
}
