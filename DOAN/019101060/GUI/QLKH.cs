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
    public partial class Frm_QLKH : Form
    {
        private string tendn;
        public Frm_QLKH(String tendn)
        {
            InitializeComponent();
            this.tendn = tendn;
        }

        public void TT_KHACHHANG()
        {
            lvkhachhang.Items.Clear();
            DataTable dt = new DataTable();
            dt = KhachHangDAO.TT_KHACHHANG();
            int Sodong = dt.Rows.Count;
            int i;
            for (i = 0; i < Sodong; i++)
            {
                lvkhachhang.Items.Add(dt.Rows[i][0].ToString());
                lvkhachhang.Items[i].SubItems.Add(dt.Rows[i]["tenkh"].ToString());
                lvkhachhang.Items[i].SubItems.Add(dt.Rows[i]["diachikh"].ToString());
                if (dt.Rows[i]["gioitinhkh"].ToString() == "True")
                    lvkhachhang.Items[i].SubItems.Add("Nam");
                else lvkhachhang.Items[i].SubItems.Add("Nữ");
                lvkhachhang.Items[i].SubItems.Add(dt.Rows[i]["sdtkh"].ToString());
                lvkhachhang.Items[i].SubItems.Add(dt.Rows[i]["hotennv"].ToString());
                gbkh.Text = $"Thông tin khách hàng ({lvkhachhang.Items.Count})";

            }
        }
        public void TextboxKH() { 
        DataTable dt = new DataTable();
        dt = NhanVienDAO.TTNhanVien();
            txttennv.DataSource = dt;
            txttennv.DisplayMember = "hotennv";
            txttennv.ValueMember = "manhanvien";
        }
        public void LoadDLComBoBoxtennv()
        {
            txttennv.Text = tendn.ToString();
        }

        private void Frm_QLKH_Load(object sender, EventArgs e)
        {
            TT_KHACHHANG();
            LoadDLComBoBoxtennv();
            TextboxKH();
        }

        private void lvkhachhang_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = KhachHangDAO.MaKhachHangMax();
            string mp = dt.Rows[0][0].ToString();
            txtkh.Text = "KH" + (Convert.ToInt32(mp.Substring(mp.Length - 3, 3)) + 1).ToString("000");
            txtdiachi.Text = "";
            txttenkh.Text = "";
            txtsdt.Text = "";
            TT_KHACHHANG();
            LoadDLComBoBoxtennv();

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void lvkhachhang_Click(object sender, EventArgs e)
        {
            
        }

        private void btluu_Click(object sender, EventArgs e)
        {
            KhachHangDTO kh = new KhachHangDTO();
            kh.makh = txtkh.Text;
            kh.tenkh = txttenkh.Text;
            kh.diachikh = txtdiachi.Text;
            kh.dienthoai = txtsdt.Text;
            kh.ngaysinh = dtngaysinh.Value.ToString("MM/dd/yyyy");
            if (rdNam.Checked == true)
                kh.gioitinh = "1";
            else kh.gioitinh = "0";
            kh.manv = txttennv.SelectedValue.ToString();
            KhachHangBUS.ThemKhachHang(kh);
            TT_KHACHHANG();
        }

        private void btcapnhat_Click(object sender, EventArgs e)
        {
            KhachHangDTO kh = new KhachHangDTO();
            kh.makh = txtkh.Text;
            kh.tenkh = txttenkh.Text;
            kh.diachikh = txtdiachi.Text;
            kh.dienthoai = txtsdt.Text;
            kh.ngaysinh = dtngaysinh.Value.ToString("MM/dd/yyyy");
            if (rdNam.Checked == true)
                kh.gioitinh = "1";
            else kh.gioitinh = "0";
            kh.manv = txttennv.SelectedValue.ToString();
            KhachHangBUS.CapNhatKhachHang(kh);
            TT_KHACHHANG();
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa ko?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                KhachHangDTO kh = new KhachHangDTO();
                kh.makh = txtkh.Text;
                KhachHangBUS.XoaNhanVien(kh);
                TT_KHACHHANG();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Frm_QLKH_Click(object sender, EventArgs e)
        {

        }

        private void lvkhachhang_Click_1(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = KhachHangDAO.TTKhachHangChiTiet(lvkhachhang.SelectedItems[0].SubItems[0].Text);
            txtkh.Text = dt.Rows[0]["MaKH"].ToString();
            txttenkh.Text = dt.Rows[0]["tenkh"].ToString();
            txtdiachi.Text = dt.Rows[0]["DiaChikh"].ToString();
            txtsdt.Text = dt.Rows[0]["SDTkh"].ToString();
            dtngaysinh.Text = dt.Rows[0]["ngaysinhkh"].ToString();
            if (dt.Rows[0]["gioitinhkh"].ToString() == "True")
                rdNam.Checked = true;
            else rdNu.Checked = true;
            txttennv.Text = dt.Rows[0]["hotennv"].ToString();
        }

        private void btin_Click(object sender, EventArgs e)
        {

        }
    }
}
