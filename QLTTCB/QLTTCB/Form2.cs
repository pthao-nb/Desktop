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
    public partial class Form2 : Form
    {
        string connectstring = "Data Source=LAPTOP-N50OPETB;Initial Catalog=quanlythongtincanbo;Integrated Security=True;Encrypt=False";
        public Form2()
        {
            InitializeComponent();
            //this.Load += new EventHandler(Form2_Load);

        }
        private void Form2_Load(object sender, EventArgs e)
        {
            HienThiCanBo();
        }

        private void HienThiCanBo()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectstring))
                {
                    con.Open();
                    string query = @"
                SELECT 
                    cb.MaSo,
                    cb.HoTen,
                    cb.NgaySinh,
                    cb.GioiTinh,
                    dv.TenDonVi,
                    nct.TenNgach,
                    cb.HesoLuong
                FROM CanBo AS cb
                JOIN DonVi AS dv ON cb.MaDonVi = dv.MaDonVi
                JOIN NgachCongTac AS nct ON cb.MaNgach = nct.MaNgach";


                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;

                    MessageBox.Show("Số dòng lấy được: " + dt.Rows.Count.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
        }
        private void btnLoc_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectstring))
                {
                    con.Open();

                    string query = @"
                SELECT 
                    cb.MaSo,
                    cb.HoTen,
                    cb.NgaySinh,
                    cb.GioiTinh,
                    dv.TenDonVi,
                    nct.TenNgach,
                    cb.HesoLuong
                FROM CanBo AS cb
                JOIN DonVi AS dv ON cb.MaDonVi = dv.MaDonVi
                JOIN NgachCongTac AS nct ON cb.MaNgach = nct.MaNgach
                WHERE cb.MaSo LIKE '%' + @maso + '%'
            ";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@maso", cbMaSo.Text);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView1.DataSource = dt;
                    MessageBox.Show("Tìm thấy " + dt.Rows.Count.ToString() + " cán bộ.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tra cứu: " + ex.Message);
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void danhMụcCácĐơnVịToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();  // tạo đối tượng form 3
            f3.ShowDialog();         // mở form dưới dạng hộp thoại (modal)
        }

    }
}