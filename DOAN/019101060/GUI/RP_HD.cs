using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _019101060.DAO;

namespace _019101060.GUI
{
    public partial class RP_HD : Form
    {

        public RP_HD()
        {
            InitializeComponent();
        }
        public static DataTable ThongTinReport()
        {
            string sql = "Select hd.MaHD, TENKH, HOTENNV, NgayLapHD, TENSANPHAM, ct.SoLuong, sp.GIA, (ct.SoLuong*sp.GIA) as ThanhTien from HOADON hd, CTHD ct,NHANVIEN nv, KHACHHANG kh, SANPHAM sp where hd.MaHD = ct.MaHD and hd.MAKH = kh.MAKH and hd.MaNhanVien = nv.MANHANVIEN and ct.MaSP = sp.MASP";
            DataTable dt = new DataTable();
            dt = KetNoiCSDL.DocDuLieu(sql);
            return dt;
        }

        private void RP_HD_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = ThongTinReport();
            CrystalReportHD cry = new CrystalReportHD();
            cry.SetDataSource(dt);
            crystalReportViewer1.ReportSource = cry;
        }
    }
}
