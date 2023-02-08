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
    public partial class RP_SP : Form
    {
        public RP_SP()
        {
            InitializeComponent();
        }
        public static DataTable ThongTinReport()
        {
            string sql = "Select dm.MADANHMUC, dm.TENDANHMUC, TENSANPHAM, GIA, SOLUONG, HANGSX from DANHMUC dm, SANPHAM sp where dm.MADANHMUC = sp.MADANHMUC";
            DataTable dt = new DataTable();
            dt = KetNoiCSDL.DocDuLieu(sql);
            return dt;
        }

        private void RP_SP_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = ThongTinReport();
            CrystalReportSP cry = new CrystalReportSP();
            cry.SetDataSource(dt);
            crystalReportViewer1.ReportSource = cry;
        }
    }
}
