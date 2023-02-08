using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace _019101060.DAO
{
    class KetNoiCSDL
    {
        private static SqlConnection cnn = new SqlConnection();
        public static void MoKetNoiCSDL()
        {
            try
            {
                string sqlcon = @"Data Source=DESKTOP-ODGP1BV\SQLEXPRESS;Initial Catalog=QLBHLT;Integrated Security=True";
                cnn.ConnectionString = sqlcon;
                if (cnn.State == ConnectionState.Closed)
                    cnn.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Kết nối CSDL không thành công");
            }
        }
        public static void DongKetNoi()
        {
            if (cnn.State == ConnectionState.Open)
                cnn.Close();
        }
        public static DataTable DocDuLieu(string sql)
        {
            MoKetNoiCSDL();
            SqlCommand cd = new SqlCommand(sql, cnn);
            SqlDataReader dr = cd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            DongKetNoi();
            return dt;
        }
        public static void ThucThiTruyVan(string sql)
        {
            MoKetNoiCSDL();
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.ExecuteNonQuery();
            DongKetNoi();
        }
    }
}
