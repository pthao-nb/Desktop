using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLNV
{
    public partial class Form2 : Form
    {
        string connectstring = "Data Source=LAPTOP-N50OPETB;Initial Catalog=quanlynhanvien;Integrated Security=True;TrustServerCertificate=True";
        public Form2()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form2_Load);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Hienthinhanvien();
            LoadTenNhanVien();
        }

        private void Hienthinhanvien()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectstring))
                {
                    con.Open();
                    string query = "SELECT MaNV, HoTen, NgaySinh, DiaChi, DienThoai FROM NhanVien";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        SqlDataAdapter adt = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adt.Fill(dt);
                        MessageBox.Show("Số dòng lấy được: " + dt.Rows.Count.ToString());
                        dataGridView1.AutoGenerateColumns = true;
                        dataGridView1.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
        }

        private void LoadTenNhanVien()
        {
            using (SqlConnection con = new SqlConnection(connectstring))
            {
                string query = "SELECT DISTINCT hoten FROM nhanvien";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cbTenNV.DataSource = dt;
                cbTenNV.DisplayMember = "hoten";
                cbTenNV.ValueMember = "hoten";
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btnThêm_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy dữ liệu từ dòng mới trong DataGridView (dòng cuối cùng đang được nhập)
                int rowIndex = dataGridView1.Rows.Count - 2; // -2 để tránh dòng trống mới
                DataGridViewRow row = dataGridView1.Rows[rowIndex];

                string manv = row.Cells["manv"].Value?.ToString();
                string hoten = row.Cells["hoten"].Value?.ToString();
                DateTime ngaysinh = Convert.ToDateTime(row.Cells["ngaysinh"].Value);
                string diachi = row.Cells["diachi"].Value?.ToString();
                string dienthoai = row.Cells["dienthoai"].Value?.ToString();

                using (SqlConnection con = new SqlConnection(connectstring))
                {
                    con.Open();
                    string sql = "INSERT INTO nhanvien (manv, hoten, ngaysinh, diachi, dienthoai) " +
                                 "VALUES (@MaNV, @HoTen, @NgaySinh, @DiaChi, @DienThoai)";
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@MaNV", manv);
                        cmd.Parameters.AddWithValue("@HoTen", hoten);
                        cmd.Parameters.AddWithValue("@NgaySinh", ngaysinh);
                        cmd.Parameters.AddWithValue("@DiaChi", diachi);
                        cmd.Parameters.AddWithValue("@DienThoai", dienthoai);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Thêm thành công!");
                Hienthinhanvien();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm: " + ex.Message);
            }
        }

        private void btnSửa_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow != null)
                {
                    string manv = dataGridView1.CurrentRow.Cells["manv"].Value.ToString();
                    string hoten = dataGridView1.CurrentRow.Cells["hoten"].Value.ToString();
                    DateTime ngaysinh = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["ngaysinh"].Value);
                    string diachi = dataGridView1.CurrentRow.Cells["diachi"].Value.ToString();
                    string dienthoai = dataGridView1.CurrentRow.Cells["dienthoai"].Value.ToString();

                    using (SqlConnection con = new SqlConnection(connectstring))
                    {
                        con.Open();
                        string sql = "UPDATE nhanvien SET hoten = @HoTen, ngaysinh = @NgaySinh, diachi = @DiaChi, dienthoai = @DienThoai WHERE manv = @MaNV";
                        using (SqlCommand cmd = new SqlCommand(sql, con))
                        {
                            cmd.Parameters.AddWithValue("@MaNV", manv);
                            cmd.Parameters.AddWithValue("@HoTen", hoten);
                            cmd.Parameters.AddWithValue("@NgaySinh", ngaysinh);
                            cmd.Parameters.AddWithValue("@DiaChi", diachi);
                            cmd.Parameters.AddWithValue("@DienThoai", dienthoai);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Sửa thành công!");
                    Hienthinhanvien();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi sửa: " + ex.Message);
            }
        }

        private void btnXóa_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow != null)
                {
                    string manv = dataGridView1.CurrentRow.Cells["manv"].Value?.ToString();

                    using (SqlConnection con = new SqlConnection(connectstring))
                    {
                        con.Open();
                        string sql = "DELETE FROM nhanvien WHERE manv = @MaNV";
                        using (SqlCommand cmd = new SqlCommand(sql, con))
                        {
                            cmd.Parameters.AddWithValue("@MaNV", manv);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Xóa thành công!");
                    Hienthinhanvien();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xóa: " + ex.Message);
            }
        }

        private void btnTracuu_Click(object sender, EventArgs e)
        {
            if (cbTenNV.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn tên nhân viên cần tra cứu!");
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(connectstring))
                {
                    con.Open();
                    string query = "SELECT manv, hoten, ngaysinh, diachi, dienthoai FROM nhanvien WHERE hoten LIKE '%' + @HoTen + '%'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@HoTen", cbTenNV.SelectedValue.ToString());

                    SqlDataAdapter adt = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adt.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tra cứu: " + ex.Message);
            }
        }
            private void B(object sender, EventArgs e)
             {

             }
    }
}
