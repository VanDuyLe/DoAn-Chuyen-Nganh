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
    public partial class QLSP : Form
    {
        public QLSP()
        {
            InitializeComponent();
        }
        public void LoadTreeView(TreeView tree)
        {
            tree.Nodes.Clear();
            DataTable dtdanhmuc = new DataTable();
            dtdanhmuc = DanhMucDAO.TTDANHMUCTREE();
            TreeNode nodeCha = new TreeNode();
            int slphong = dtdanhmuc.Rows.Count;

            DataTable dtsp = new DataTable();
            dtsp = SanPhamDAO.TTSanPhanTree();
            int slnv = dtsp.Rows.Count;

            for (int i = 0; i < slphong; i++)
            {
                nodeCha = tree.Nodes.Add(dtdanhmuc.Rows[i]["TenDanhMuc"].ToString());
                nodeCha.Tag = dtdanhmuc.Rows[i]["MaDanhMuc"].ToString();
                for (int j = 0; j < slnv; j++)
                {
                    if (dtdanhmuc.Rows[i]["MaDanhMuc"].ToString() == dtsp.Rows[j]["MaDanhMuc"].ToString())
                    {
                        TreeNode nodeCon = new TreeNode();
                        nodeCon.Text = dtsp.Rows[j]["TenSanPham"].ToString();
                        nodeCon.Tag = dtsp.Rows[j]["MASP"].ToString();
                        nodeCha.Nodes.Add(nodeCon);
                        groupBox2.Text = $"Thông tin sản phẩm ({dataGridView1.Rows.Count})";
                    }
                }
            }
        }
        public void LoadDMComboBox()
        {
            DataTable dt = new DataTable();
            dt = DanhMucDAO.TTDANHMUC();
            cbdanhmuc.DataSource = dt;
            cbdanhmuc.DisplayMember = "TenDanhMuc";
            cbdanhmuc.ValueMember = "MaDanhMuc";
        }

        private void QLSP_Load(object sender, EventArgs e)
        {
            LoadTreeView(trvdanhmuc);
            LoadDMComboBox();
            
        }

        private void trvdanhmuc_AfterSelect(object sender, TreeViewEventArgs e)
        {
            
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = SanPhamDAO.MaSanPhamMax();
            string mp = dt.Rows[0][0].ToString();
            txtmasp.Text = "SP" + (Convert.ToInt32(mp.Substring(mp.Length - 3, 3)) + 1).ToString("000");
            txttensp.Text = "";
            txtgia.Text = "";
            txthangsx.Text = "";
            cbdanhmuc.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SanPhamDTO sp = new SanPhamDTO();
            sp.masp = txtmasp.Text;
            sp.tensp = txttensp.Text;
            sp.gia = txtgia.Text;
            sp.soluong = nbsoluong.Text;
            sp.hangsx = txthangsx.Text;
            sp.madanhmuc = cbdanhmuc.SelectedValue.ToString();
            SanPhamBUS.ThemSanPham(sp);
            LoadTreeView(trvdanhmuc);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SanPhamDTO sp = new SanPhamDTO();
            sp.masp = txtmasp.Text;
            sp.tensp = txttensp.Text;
            sp.gia = txtgia.Text;
            sp.soluong = nbsoluong.Text;
            sp.hangsx = txthangsx.Text;
            sp.madanhmuc = cbdanhmuc.SelectedValue.ToString();
            SanPhamBUS.CapNhatSanPham(sp);
            LoadTreeView(trvdanhmuc);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát ko?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SanPhamDTO sp = new SanPhamDTO();
                sp.masp = txtmasp.Text;
                SanPhamBUS.XoaSanPham(sp);
                LoadTreeView(trvdanhmuc);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void trvdanhmuc_AfterSelect_1(object sender, TreeViewEventArgs e)
        {
            if (trvdanhmuc.SelectedNode.Parent == null)
            {
                DataTable dt = new DataTable();
                dt = SanPhamDAO.TTSanPhamTheoDanhMuc(trvdanhmuc.SelectedNode.Tag.ToString());
                dataGridView1.DataSource = dt;

            }
            else
            {
                DataTable dtnv = new DataTable();
                dtnv = SanPhamDAO.TTChiTietSanPhamTree(trvdanhmuc.SelectedNode.Tag.ToString());
                txtmasp.Text = dtnv.Rows[0]["masp"].ToString();
                txttensp.Text = dtnv.Rows[0]["tensanpham"].ToString();
                txtgia.Text = dtnv.Rows[0]["gia"].ToString();
                nbsoluong.Text = dtnv.Rows[0]["soluong"].ToString();
                txthangsx.Text = dtnv.Rows[0]["hangsx"].ToString();
                cbdanhmuc.Text = dtnv.Rows[0]["tendanhmuc"].ToString();
                soluong.Text = $"Số lượng sản phẩm {dataGridView1.Rows.Count - 1}";
            }
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellClick_2(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView1.CurrentRow.Selected = true;
                txtmasp.Text = dataGridView1.Rows[e.RowIndex].Cells["masp"].FormattedValue.ToString();
                txttensp.Text = dataGridView1.Rows[e.RowIndex].Cells["tensanpham"].FormattedValue.ToString();
                txtgia.Text = dataGridView1.Rows[e.RowIndex].Cells["gia"].FormattedValue.ToString();
                nbsoluong.Text = dataGridView1.Rows[e.RowIndex].Cells["soluong"].FormattedValue.ToString();
                txthangsx.Text = dataGridView1.Rows[e.RowIndex].Cells["hangsx"].FormattedValue.ToString();
                cbdanhmuc.Text = dataGridView1.Rows[e.RowIndex].Cells["madanhmuc"].FormattedValue.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RP_SP fr = new RP_SP();
            fr.Show();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
