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
    public partial class QLNV : Form
    {
        public QLNV()
        {
            InitializeComponent();
        }
        public void TT_NHANVIEN()
        {
            lvnhanvien.Items.Clear();
            DataTable dt = new DataTable();
            dt = NhanVienDAO.TTNhanVienChiTiet();
            int Sodong = dt.Rows.Count;
            int i;
            for (i = 0; i < Sodong; i++)
            {
                lvnhanvien.Items.Add(dt.Rows[i][0].ToString());
                lvnhanvien.Items[i].SubItems.Add(dt.Rows[i]["hotennv"].ToString());
                lvnhanvien.Items[i].SubItems.Add(dt.Rows[i]["diachinv"].ToString());
                lvnhanvien.Items[i].SubItems.Add(dt.Rows[i]["ngaysinh"].ToString());
                if (dt.Rows[i]["gioitinh"].ToString() == "True")
                    lvnhanvien.Items[i].SubItems.Add("Nam");
                else lvnhanvien.Items[i].SubItems.Add("Nữ");
                lvnhanvien.Items[i].SubItems.Add(dt.Rows[i]["sdtnv"].ToString());
                lvnhanvien.Items[i].SubItems.Add(dt.Rows[i]["tenchucvu"].ToString());
                gbnv.Text =  $"Thông tin nhân viên ({lvnhanvien.Items.Count})";
            }
        }
        public void LoadDLComBoBoxMaChucVu()
        {
            DataTable dt = new DataTable();
            dt = ChucVuDAO.TTCHUCVU();
            cbchucvu.DataSource = dt;
            cbchucvu.DisplayMember = "TenChucVu";
            cbchucvu.ValueMember = "MaChucVu";
        }

        private void QLNV_Load(object sender, EventArgs e)
        {
            TT_NHANVIEN();
            LoadDLComBoBoxMaChucVu();
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = NhanVienDAO.MaNhanVienMax();
            string mp = dt.Rows[0][0].ToString();
            txtmanv.Text = "NV" + (Convert.ToInt32(mp.Substring(mp.Length - 3, 3)) + 1).ToString("000");
            txttennv.Text = "";
            txtdiachi.Text = "";
            txtsdt.Text = "";
            cbchucvu.Text = "";
            TT_NHANVIEN();
        }

        private void lvnhanvien_Click(object sender, EventArgs e)
        {
            
        }

        private void btghi_Click(object sender, EventArgs e)
        {
            NhanVienDTO nv = new NhanVienDTO();
            nv.manhanvien = txtmanv.Text;
            nv.hoten = txttennv.Text;
            nv.diachi = txtdiachi.Text;
            nv.ngaysinh = dtngaysinh.Value.ToString("MM/dd/yyyy");
            if (rdnam.Checked == true)
                nv.gioitinh = "1";
            else nv.gioitinh = "0";
            nv.dienthoai = txtsdt.Text;
            nv.machucvu = cbchucvu.SelectedValue.ToString();
            NhanVienBUS.ThemNhanVien(nv);
            TT_NHANVIEN();
        }

        private void btsua_Click(object sender, EventArgs e)
        {
            NhanVienDTO nv = new NhanVienDTO();
            nv.manhanvien = txtmanv.Text;
            nv.hoten = txttennv.Text;
            nv.diachi = txtdiachi.Text;
            nv.ngaysinh = dtngaysinh.Value.ToString("MM/dd/yyyy");
            if (rdnam.Checked == true)
                nv.gioitinh = "1";
            else nv.gioitinh = "0";
            nv.dienthoai = txtsdt.Text;
            nv.machucvu = cbchucvu.SelectedValue.ToString();
            NhanVienBUS.CapNhatNhanVien(nv);
            TT_NHANVIEN();
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            NhanVienDTO nv = new NhanVienDTO();
            nv.manhanvien = txtmanv.Text;
            NhanVienBUS.XoaNhanVien(nv);
            TT_NHANVIEN();
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void QLNV_Click(object sender, EventArgs e)
        {

        }

        private void lvnhanvien_Click_1(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = NhanVienDAO.TTNhanVienCT(lvnhanvien.SelectedItems[0].SubItems[0].Text);
            txtmanv.Text = dt.Rows[0][0].ToString();
            txttennv.Text = dt.Rows[0][1].ToString();
            txtdiachi.Text = dt.Rows[0]["DiaChiNV"].ToString();
            dtngaysinh.Text = dt.Rows[0]["NgaySinh"].ToString();
            if (dt.Rows[0]["GioiTinh"].ToString() == "True")
                rdnam.Checked = true;
            else rdnu.Checked = true;
            txtsdt.Text = dt.Rows[0]["sdtnv"].ToString();
            cbchucvu.Text = dt.Rows[0]["TenChucVu"].ToString();
        }

        private void btin_Click(object sender, EventArgs e)
        {
            RP_QLNV fr = new RP_QLNV();
            fr.Show();
        }
    }
}
