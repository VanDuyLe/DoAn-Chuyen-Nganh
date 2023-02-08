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
using _019101060.DTO;
using _019101060.BUS;

namespace _019101060.GUI
{
    public partial class QLDM : Form
    {
        public QLDM()
        {
            InitializeComponent();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
        public void TT_DANHMUC()
        {
            lvdanhmuc.Items.Clear();
            DataTable dt = new DataTable();
            dt = DanhMucDAO.TTDANHMUC();
            int Sodong = dt.Rows.Count;
            int i;
            for (i = 0; i < Sodong; i++)
            {
                lvdanhmuc.Items.Add(dt.Rows[i]["MaDanhMuc"].ToString());
                lvdanhmuc.Items[i].SubItems.Add(dt.Rows[i]["TenDanhMuc"].ToString());
                groupBox2.Text = $"Thông tin danh mục ({lvdanhmuc.Items.Count})";
            }
        }

        private void QLDM_Load(object sender, EventArgs e)
        {
            TT_DANHMUC();
        }

        private void lvdanhmuc_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = DanhMucDAO.TTDANHMUCCT(lvdanhmuc.SelectedItems[0].SubItems[0].Text);
            txtdm.Text = dt.Rows[0]["MaDanhMuc"].ToString();
            txttendm.Text = dt.Rows[0]["TenDanhMuc"].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = DanhMucDAO.MADANHMUCMAX();
            string mp = dt.Rows[0][0].ToString();
            txtdm.Text = "DM" + (Convert.ToInt32(mp.Substring(mp.Length - 3, 3)) + 1).ToString("000");
            txttendm.Text = "";
            TT_DANHMUC();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DanhMucDTO dm = new DanhMucDTO();
            dm.madanhmuc = txtdm.Text;
            dm.tendanhmuc = txttendm.Text;
            DanhMucBUS.THEMDANHMUC(dm);
            TT_DANHMUC();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DanhMucDTO dm = new DanhMucDTO();
            dm.madanhmuc = txtdm.Text;
            dm.tendanhmuc = txttendm.Text;
            DanhMucBUS.CAPNHATDANHMUC(dm);
            lvdanhmuc.Items.Clear();
            TT_DANHMUC();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa ko?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DanhMucDTO dm = new DanhMucDTO();
                dm.madanhmuc = txtdm.Text;
                DanhMucBUS.XOADANHMUC(dm);
                TT_DANHMUC();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
