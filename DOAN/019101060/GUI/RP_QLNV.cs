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
    public partial class RP_QLNV : Form
    {
        public RP_QLNV()
        {
            InitializeComponent();
        }
        public static DataTable ThongTinReport()
        {
            string sql = "Select cv.MACHUCVU, TENCHUCVU, HOTENNV, case when GIOITINH = 0 then N'Nữ' when GIOITINH = 1 then N'Nam' else N'Không xác định' end GIOITINH, NGAYSINH, DIACHINV, SDTNV FROM NHANVIEN nv, CHUCVU cv where nv.MACHUCVU = cv.MACHUCVU";
            DataTable dt = new DataTable();
            dt = KetNoiCSDL.DocDuLieu(sql);
            return dt;
        }

        private void RP_QLNV_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = ThongTinReport();
            CrystalReportNV cry = new CrystalReportNV();
            cry.SetDataSource(dt);
            crystalReportViewer1.ReportSource = cry;
        }
    }
}
