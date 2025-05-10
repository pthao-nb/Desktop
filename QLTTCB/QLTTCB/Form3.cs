using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QLTTCB
{  
    public partial class Form3 : Form
    {
        String connectstring = @"Data Source=LAPTOP-N50OPETB;Initial Catalog=quanlythongtincanbo;Integrated Security=True;TrustServerCertificate=True";
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnHienthi_Click(object sender, EventArgs e)
        {
            LoadDonVi();
            TinhTongSoLuong();
        }

        private void LoadDonVi()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectstring))
                {
                    con.Open();
                    string query = "SELECT * FROM DonVi";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải đơn vị: " + ex.Message);
            }
        }

        private void TinhTongSoLuong()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectstring))
                {
                    string query = "SELECT SUM(HeSoLuong * 2500000) FROM CanBo";
                    SqlCommand cmd = new SqlCommand(query, con);
                    con.Open();
                    object result = cmd.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        lblTongsoluong.Text = "Tổng số lương: " + Convert.ToDecimal(result).ToString("N0") + " VND";
                    }
                    else
                    {
                        lblTongsoluong.Text = "Tổng số lương: 0 VND";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tính số lương: " + ex.Message);
            }
        }

        private void lblTongsoluong_Click(object sender, EventArgs e)
        {

        }
    }
}
