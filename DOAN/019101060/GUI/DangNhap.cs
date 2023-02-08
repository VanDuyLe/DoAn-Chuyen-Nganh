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

namespace _019101060.GUI
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }
        public string sStringEncrypt = "";
        public string Encrypt(string chuoimahoa)
        {
            try
            {
                if (chuoimahoa == "") return "";
                bool useHashing = true;
                byte[] keyArray;
                byte[] chuoimahoaArray = UTF8Encoding.UTF8.GetBytes(chuoimahoa);
                if (useHashing)
                {
                    MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
                    keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(sStringEncrypt));
                }
                else keyArray = UTF8Encoding.UTF8.GetBytes(sStringEncrypt);
                TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
                tdes.Key = keyArray;
                tdes.Mode = CipherMode.ECB;
                tdes.Padding = PaddingMode.PKCS7;
                ICryptoTransform cTransform = tdes.CreateEncryptor();
                byte[] resultArray = cTransform.TransformFinalBlock(chuoimahoaArray, 0, chuoimahoaArray.Length);
                return Convert.ToBase64String(resultArray, 0, resultArray.Length);
            }
            catch (Exception)
            {
                MessageBox.Show("Khoá mã giải không tương thích");
                throw;
            }

        }

        private void Frm_LogIn_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {           
            DataTable dt = new DataTable();
            string mkmh = "";
            string tendn = txttk.Text;
            //sStringEncrypt = this.txttk.Text;
            mkmh = txtmk.Text;
            dt = NguoiDungDAO.TTNguoiDung(txttk.Text, mkmh);
            //String MANHANVIEN = dt.Rows[0]["MANHANHVIEN"].ToString() ;
            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0]["MACHUCVU"].ToString() == "CV002")
                {
                    MessageBox.Show("Đăng nhập thành công");
                    Main fr = new Main(tendn);
                    this.Hide();
                    fr.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thành công");
                    MainNV fr = new MainNV(tendn);
                    this.Hide();
                    fr.ShowDialog();
                    this.Show();
                }

            }
            else MessageBox.Show("Tên đăng nhập và mật khẩu chưa đúng");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DangKy fr = new DangKy();
            fr.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //if (checkBox1.Checked)
            //{
            //    Properties.Settings.Default.username = txttk.Text;
            //    Properties.Settings.Default.password = txtmk.Text;
            //    Properties.Settings.Default.Save();
            //}
            //else
            //{
            //    Properties.Settings.Default.Reset();
            //}
        }

        private void checkBox2_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                txtmk.PasswordChar = '\0';
            }
            else
            {
                txtmk.PasswordChar = '*';
            }
        }
    }
}
