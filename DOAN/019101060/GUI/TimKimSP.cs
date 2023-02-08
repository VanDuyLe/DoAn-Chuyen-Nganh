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
    public partial class TimKimSP : Form
    {
        public TimKimSP()
        {
            InitializeComponent();
        }
        public void LoadGV()
        {
            DataTable dt = new DataTable();
            dt = TimKiemDAO.TTSP();
            dgvtimkiem.DataSource = dt;
            groupBox1.Text = $"Thông tin sản phẩm ({dgvtimkiem.Rows.Count})";
            soluong.Text = $"Số lượng sản phẩm {dgvtimkiem.Rows.Count - 1}";
        }
        

        private void TimKimSP_Load(object sender, EventArgs e)
        {
            LoadGV();
        }

        private void btntim_Click(object sender, EventArgs e)
        {
            
        }

        private void btnhienthitatca_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            dgvtimkiem.DataSource = SanPhamDAO.TK_SanPham(txttimkiem.Text.Trim());
            groupBox1.Text = $"Thông tin sản phẩm ({dgvtimkiem.Rows.Count-1})"; 
            soluong.Text = $"Số lượng sản phẩm {dgvtimkiem.Rows.Count - 1}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
