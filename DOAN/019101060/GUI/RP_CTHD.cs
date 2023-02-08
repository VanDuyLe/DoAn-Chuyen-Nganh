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
    public partial class RP_CTHD : Form
    {
        private String MaHD;
        public RP_CTHD(String MaHD)
        {
            InitializeComponent();
            this.MaHD = MaHD;
        }
        public static DataTable ThongTinReport(String MaHD)
        {
            string sql = "SELECT HOADON.MaHD, TENKH, TENSANPHAM, CTHD.SoLuong, SANPHAM.GIA, (CTHD.SoLuong*SANPHAM.GIA) as ThanhTien FROM HOADON, CTHD ,KHACHHANG, SANPHAM WHERE HOADON.MaHD = CTHD.MaHD AND HOADON.MAKH = KHACHHANG.MAKH AND CTHD.MaSP = SANPHAM.MASP AND HOADON.MaHD = '"+ MaHD + "'";
            DataTable dt = new DataTable();
            dt = KetNoiCSDL.DocDuLieu(sql);
            return dt;
        }

        private void RP_CTHD_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = ThongTinReport(MaHD);
            CrystalReportCTHD cry = new CrystalReportCTHD();
            cry.SetDataSource(dt);
            crystalReportViewer1.ReportSource = cry;
        }
    }
}
