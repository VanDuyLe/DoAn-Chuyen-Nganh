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
    public partial class HoaDon : Form
    {
        private string tendn;
        public HoaDon(String tendn)
        {
            InitializeComponent();
            this.tendn = tendn;

        }

        public void LoadCBKhachHang()
        {
            DataTable dt = new DataTable();
            dt = KhachHangDAO.TT_KHACHHANG();
            cbxKhachHang.DataSource = dt;
            cbxKhachHang.DisplayMember = "TenKH";
            cbxKhachHang.ValueMember = "MaKH";
        }
        public void LoadCBNhanVienn()
        {
            DataTable dt = new DataTable();
            dt = NhanVienDAO.TTNhanVienChiTiet();
            cbxNhanVien.DataSource = dt;
            cbxNhanVien.DisplayMember = "hotennv";
            cbxNhanVien.ValueMember = "manhanvien";
        }
        public void LoadCBNhanVien()
        {
            cbxNhanVien.Text = tendn.ToString();
        }
        public void LoadCBBCTHD()
        {
            DataTable dt = new DataTable();
            dt = SanPhamDAO.TT_SanPham();
            cbbsanpham.DataSource = dt;
            cbbsanpham.DisplayMember = "TenSanPham";
            cbbsanpham.ValueMember = "MaSP";
        }

        public void TTHoaDon()
        {
            lvHoaDon.Items.Clear();
            DataTable dt = new DataTable();
            dt = HoaDonDAO.TTHoaDon();
            int Sodong = dt.Rows.Count;
            int i;
            for (i = 0; i < Sodong; i++)
            {
                lvHoaDon.Items.Add(dt.Rows[i][0].ToString());
                lvHoaDon.Items[i].SubItems.Add(dt.Rows[i][1].ToString());
                lvHoaDon.Items[i].SubItems.Add(dt.Rows[i][2].ToString());
                lvHoaDon.Items[i].SubItems.Add(dt.Rows[i][3].ToString());
                groupBox2.Text = $"Thông tin hóa đơn ({lvHoaDon.Items.Count})";

            }
        }

        private void HoaDon_Load(object sender, EventArgs e)
        {
            TTHoaDon();
            LoadCBBCTHD();
            LoadCBNhanVien();
            LoadCBKhachHang();
            LoadCBNhanVienn();
        }

        private void lvHoaDon_Click(object sender, EventArgs e)
        {
            
        }

        private void lvCTHD_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lvCTHD_Click(object sender, EventArgs e)
        {
            
        }

        private void cbbsanpham_Click(object sender, EventArgs e)
        {
            
        }

        private void btthemsp_Click(object sender, EventArgs e)
        {
            
        }

        private void btsuasp_Click(object sender, EventArgs e)
        {
            
        }

        private void btnXoaSP_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cbbsanpham_Click_1(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = SanPhamDAO.GiaSanPham(cbbsanpham.SelectedValue.ToString());
            txtDonGia.Text = dt.Rows[0]["Gia"].ToString();
        }

        private void btthemsp_Click_1(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            CTHDDTO cthd = new CTHDDTO();
            cthd.mahd = txtMaHD.Text;
            cthd.masanpham = cbbsanpham.SelectedValue.ToString();
            cthd.gia = txtDonGia.Text;
            cthd.soluong = txtSoLuong.Text;
            ChiTietHoaDonBUS.Them_CTHD(cthd);
            txtDonGia.Text = "";
            TTHoaDon();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = HoaDonDAO.MaHoaDonMAX();
            string nv = dt.Rows[0][0].ToString();
            txtMaHD.Text = "HD" + (Convert.ToInt32(nv.Substring(nv.Length - 3, 3)) + 1).ToString("000");
            LoadCBNhanVien();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            HoaDonDTO hd = new HoaDonDTO();
            hd.mahd = txtMaHD.Text;
            hd.ngaylaphd = dtpNgayLap.Value.ToString("MM/dd/yyyy");
            hd.manhanvien = cbxNhanVien.SelectedValue.ToString();
            hd.makhachhang = cbxKhachHang.SelectedValue.ToString();
            HoaDonBUS.Them_HD(hd);
            TTHoaDon();
            LoadCBNhanVien();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            HoaDonDTO hd = new HoaDonDTO();
            hd.mahd = txtMaHD.Text;
            hd.ngaylaphd = dtpNgayLap.Value.ToString("MM/dd/yyyy");
            hd.manhanvien = cbxNhanVien.Text;
            hd.makhachhang = cbxKhachHang.SelectedValue.ToString();
            HoaDonBUS.CapNhat_HD(hd);
            TTHoaDon();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            HoaDonDTO hd = new HoaDonDTO();
            hd.mahd = txtMaHD.Text;
            HoaDonBUS.Xoa_HD(hd);
            TTHoaDon();
        }

        private void btsuasp_Click_1(object sender, EventArgs e)
        {
            CTHDDTO cthd = new CTHDDTO();
            cthd.mahd = txtMaHD.Text;
            cthd.masanpham = cbbsanpham.SelectedValue.ToString();
            cthd.gia = txtDonGia.Text;
            cthd.soluong = txtSoLuong.Text;
            ChiTietHoaDonBUS.CapNhat_ChucVu(cthd);
            TTHoaDon();
        }

        private void btnXoaSP_Click_1(object sender, EventArgs e)
        {
            CTHDDTO cthd = new CTHDDTO();
            cthd.masanpham = cbbsanpham.SelectedValue.ToString();
            ChiTietHoaDonBUS.Xoa_ChucVu(cthd);
            TTHoaDon();
        }

        private void lvHoaDon_Click_1(object sender, EventArgs e)
        {
            lvCTHD.Items.Clear();
            DataTable dt = new DataTable();
            dt = HoaDonDAO.TTHoaDonChiTiet(lvHoaDon.SelectedItems[0].SubItems[0].Text);
            txtMaHD.Text = dt.Rows[0][0].ToString();
            dtpNgayLap.Text = dt.Rows[0][1].ToString();
            cbxNhanVien.Text = dt.Rows[0][2].ToString();
            cbxKhachHang.Text = dt.Rows[0][3].ToString();
            DataTable cthd = new DataTable();
            cthd = HoaDonDAO.TTChiTietHoaDon(lvHoaDon.SelectedItems[0].SubItems[0].Text);
            int Sodong = cthd.Rows.Count;
            int i;
            for (i = 0; i < Sodong; i++)
            {
                lvCTHD.Items.Add(cthd.Rows[i][0].ToString());
                lvCTHD.Items[i].SubItems.Add(cthd.Rows[i][2].ToString());
                lvCTHD.Items[i].SubItems.Add(cthd.Rows[i][3].ToString());
                lvCTHD.Items[i].SubItems.Add(cthd.Rows[i][4].ToString());
                lvCTHD.Items[i].SubItems.Add(cthd.Rows[i][5].ToString());
                groupBox4.Text = $"Thông tin CTHD ({lvCTHD.Items.Count})";
            }
        }

        private void lvCTHD_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String MaHD = txtMaHD.Text;
            RP_CTHD fr = new RP_CTHD(MaHD);
            fr.Show();
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void lvCTHD_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void lvCTHD_Click_2(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = HoaDonDAO.ChiTietHoaDonChiTiet(lvCTHD.SelectedItems[0].SubItems[0].Text);
            cbbsanpham.Text = dt.Rows[0][1].ToString();
            txtDonGia.Text = dt.Rows[0][2].ToString();
            txtSoLuong.Text = dt.Rows[0][3].ToString();
            txtthanhtien.Text = dt.Rows[0][4].ToString();
        }
    }
}
