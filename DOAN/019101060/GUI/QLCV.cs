using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _019101060.DTO;
using _019101060.DAO;
using _019101060.BUS;

namespace _019101060.GUI
{
    public partial class QLCV : Form
    {
        public QLCV()
        {
            InitializeComponent();
        }
        public void TT_CHUCVU()
        {
            lvchucvu.Items.Clear();
            DataTable dt = new DataTable();
            dt = ChucVuDAO.TTCHUCVU();
            int Sodong = dt.Rows.Count;
            int i;
            for (i = 0; i < Sodong; i++)
            {
                lvchucvu.Items.Add(dt.Rows[i]["MaChucVu"].ToString());
                lvchucvu.Items[i].SubItems.Add(dt.Rows[i]["TenChucVu"].ToString());
                groupBox2.Text = $"Thông tin chức vụ ({lvchucvu.Items.Count})";
            }
        }
        public void LoadLBCV()
        {
            DataTable dt = new DataTable();
            dt = ChucVuDAO.TTCHUCVU();
            lbchucvu.DataSource = dt;
            lbchucvu.DisplayMember = "TenChucVu";
            lbchucvu.ValueMember = "MaChucVu";
        }
        private void QLCV_Load(object sender, EventArgs e)
        {
            TT_CHUCVU();
            LoadLBCV();
        }

        private void lvchucvu_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = ChucVuDAO.CHUCVUCT(lvchucvu.SelectedItems[0].SubItems[0].Text);
            txtmacv.Text = dt.Rows[0]["MaChucVu"].ToString();
            txttencv.Text = dt.Rows[0]["TenChucVu"].ToString();
        }

        private void lbchucvu_Click(object sender, EventArgs e)
        {
            if (lbchucvu.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                DataTable dt = new DataTable();
                dt = ChucVuDAO.TTCHUCVUCT(lbchucvu.SelectedValue.ToString());
                txtmacv.Text = dt.Rows[0]["MaChucVu"].ToString();
                txttencv.Text = dt.Rows[0]["TenChucVu"].ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = ChucVuDAO.MaChucVuMAX();
            string mp = dt.Rows[0][0].ToString();
            txtmacv.Text = "CV" + (Convert.ToInt32(mp.Substring(mp.Length - 3, 3)) + 1).ToString("000");
            txttencv.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChucVuDTO cv = new ChucVuDTO();
            cv.machucvu = txtmacv.Text;
            cv.tenchucvu = txttencv.Text;
            ChucVuBUS.ThemChucVu(cv);
            TT_CHUCVU();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ChucVuDTO cv = new ChucVuDTO();
            cv.machucvu = txtmacv.Text;
            cv.tenchucvu = txttencv.Text;
            ChucVuBUS.CapNhatChucVu(cv);
            TT_CHUCVU();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa ko?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ChucVuDTO cv = new ChucVuDTO();
                cv.machucvu = txtmacv.Text;
                ChucVuBUS.XoaChucVu(cv);
                TT_CHUCVU();
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
