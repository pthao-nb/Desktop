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

namespace QUANLYXE
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-N50OPETB;Initial Catalog=QUANLYXE;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM QUANTRI WHERE Manguoidung=@user AND Matkhau=@pass";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@user", txtUser.Text);
            cmd.Parameters.AddWithValue("@pass", txtPass.Text);

            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                MessageBox.Show("Đăng nhập thành công!");
                this.Hide();
                new Form2().Show(); // sang Form quản lý
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu");
            }
            conn.Close();
        }
    }
}
