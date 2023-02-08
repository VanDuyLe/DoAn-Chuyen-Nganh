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
    public partial class MainNV : Form
    {
        public MainNV(String tendn)
        {
            InitializeComponent();
            string tennhanvien;
            DataTable dt = new DataTable();
            dt = NguoiDungDAO.TenNV(tendn);
            tennhanvien = dt.Rows[0][0].ToString();
            label3.Text = tennhanvien.ToString();

        }

        private void quảnLíKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string tendn = label3.Text;
            Frm_QLKH fr = new Frm_QLKH(tendn);
            fr.Show();
        }

        private void quảnLíSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLSP fr = new QLSP();
            fr.Show();
        }

        private void tìmKiếmSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimKimSP fr = new TimKimSP();
            fr.Show();
        }

        private void quảnLíDanhMụcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLDM fr = new QLDM();
            fr.Show();
        }

        private void quảnLíHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string tendn = label3.Text;
            HoaDon fr = new HoaDon(tendn);
            fr.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void MainNV_Load(object sender, EventArgs e)
        {

        }
    }
}
