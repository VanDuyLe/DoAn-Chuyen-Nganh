using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management.Instrumentation;
using System.Security.Cryptography;
using _019101060.DAO;
using _019101060.DTO;
using _019101060.BUS;

namespace _019101060.GUI
{
    public partial class DangKy : Form
    {
        public DangKy()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NguoiDungDTO tk = new NguoiDungDTO();
            tk.taikhoan = txttk.Text;
            tk.matkhau = txtmk.Text;
            tk.machucvu = cbcv.SelectedValue.ToString();
            tk.manhanvien = cbnv.SelectedValue.ToString();
            NguoiDungBUS.ThemNguoiDung(tk);
            TT_TaiKhoan();
        }
        public void TT_TaiKhoan()
        {
            lvtaikhoan.Items.Clear();
            DataTable dt = new DataTable();
            dt = NguoiDungDAO.TTTaiKhoan();
            int Sodong = dt.Rows.Count;
            int i;
            for (i = 0; i < Sodong; i++)
            {
                lvtaikhoan.Items.Add(dt.Rows[i][0].ToString());
                lvtaikhoan.Items[i].SubItems.Add("**********".ToString());
                lvtaikhoan.Items[i].SubItems.Add(dt.Rows[i][2].ToString());
                lvtaikhoan.Items[i].SubItems.Add(dt.Rows[i][3].ToString());
                groupBox2.Text = $"Thông tin tài khoản ({lvtaikhoan.Items.Count})";

            }
        }
        public void LoadDLComBoBoxMaNhanVien()
        {
            DataTable dt = new DataTable();
            dt = NhanVienDAO.TTNhanVienChiTiet();
            cbnv.DataSource = dt;
            cbnv.DisplayMember = "HOTENNV";
            cbnv.ValueMember = "MANHANVIEN";
        }
        public void LoadDLComBoBoxMaChucVu()
        {
            DataTable dt = new DataTable();
            dt = ChucVuDAO.TTCHUCVU();
            cbcv.DataSource = dt;
            cbcv.DisplayMember = "TenChucVu";
            cbcv.ValueMember = "MaChucVu";
        }

        private void Frm_DangKy_Load(object sender, EventArgs e)
        {
            TT_TaiKhoan();
            LoadDLComBoBoxMaNhanVien();
            LoadDLComBoBoxMaChucVu();
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void lvtaikhoan_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = NguoiDungDAO.TTNguoiDungCT(lvtaikhoan.SelectedItems[0].SubItems[0].Text);
            txttk.Text = dt.Rows[0]["TenTaiKhoan"].ToString();
            txtmk.Text = dt.Rows[0]["MatKhau"].ToString();
            cbcv.Text = dt.Rows[0]["TENCHUCVU"].ToString();
            cbnv.Text = dt.Rows[0]["HOTENNV"].ToString();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            NguoiDungDTO tk = new NguoiDungDTO();
            tk.taikhoan = txttk.Text;
            tk.matkhau = txtmk.Text;
            tk.machucvu = cbcv.SelectedValue.ToString();
            tk.manhanvien = cbnv.SelectedValue.ToString();
            NguoiDungBUS.CapNhatTaiKhoan(tk);
            TT_TaiKhoan();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NguoiDungDTO tk = new NguoiDungDTO();
            tk.taikhoan = txttk.Text;
            NguoiDungBUS.XoaTaiKhoan(tk);
            TT_TaiKhoan();
        }
    }
}
