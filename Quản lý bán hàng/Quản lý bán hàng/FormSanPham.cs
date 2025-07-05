using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class FormSanPham : Form
    {
        private string connectionString = "Data Source=.;Initial Catalog=QLBANHANG;Integrated Security=True";

        public FormSanPham()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
        }

        private void LoadSanPham()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM SANPHAM";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvHienthi.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
                }
            }
        }

        private void btnHienthi_Click(object sender, EventArgs e)
        {
            LoadSanPham();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO SANPHAM (MaSP, TenSP, DonViTinh, DonGia) VALUES (@MaSP, @TenSP, @DonViTinh, @DonGia)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaSP", txtMaSP.Text);
                cmd.Parameters.AddWithValue("@TenSP", txtTenSP.Text);
                cmd.Parameters.AddWithValue("@DonViTinh", txtDonvitinh.Text);
                cmd.Parameters.AddWithValue("@DonGia", float.Parse(txtDongia.Text));
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                LoadSanPham();
                ClearFields();
            }
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    foreach (DataGridViewRow row in dgvHienthi.Rows)
                    {
                        if (row.IsNewRow) continue;

                        string maSP = row.Cells["MaSP"].Value?.ToString();
                        string tenSP = row.Cells["TenSP"].Value?.ToString();
                        string donViTinh = row.Cells["DonViTinh"].Value?.ToString();
                        string donGiaStr = row.Cells["DonGia"].Value?.ToString();

                        if (string.IsNullOrEmpty(maSP) || string.IsNullOrEmpty(tenSP)) continue;

                        if (!decimal.TryParse(donGiaStr, out decimal donGia))
                            continue;

                        string query = @"UPDATE SANPHAM 
                                         SET TenSP = @TenSP, DonViTinh = @DonViTinh, DonGia = @DonGia 
                                         WHERE MaSP = @MaSP";

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@MaSP", maSP);
                            cmd.Parameters.AddWithValue("@TenSP", tenSP);
                            cmd.Parameters.AddWithValue("@DonViTinh", donViTinh);
                            cmd.Parameters.AddWithValue("@DonGia", donGia);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Cập nhật thành công!");
                    LoadSanPham();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi cập nhật: " + ex.Message);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvHienthi.SelectedRows.Count > 0)
            {
                DialogResult confirm = MessageBox.Show("Bạn có chắc muốn xóa sản phẩm này?", "Xác nhận", MessageBoxButtons.YesNo);

                if (confirm == DialogResult.Yes)
                {
                    DataGridViewRow row = dgvHienthi.SelectedRows[0];
                    string maSP = row.Cells["MaSP"].Value?.ToString();

                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        try
                        {
                            conn.Open();
                            string query = "DELETE FROM SANPHAM WHERE MaSP = @MaSP";
                            using (SqlCommand cmd = new SqlCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("@MaSP", maSP);
                                cmd.ExecuteNonQuery();
                            }

                            MessageBox.Show("Xóa thành công!");
                            LoadSanPham();
                            ClearFields();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi xóa: " + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm để xóa.");
            }
        }

        private void dgvHienthi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvHienthi.CurrentRow;
                txtMaSP.Text = row.Cells["MaSP"].Value.ToString();
                txtTenSP.Text = row.Cells["TenSP"].Value.ToString();
                txtDonvitinh.Text = row.Cells["DonViTinh"].Value.ToString();
                txtDongia.Text = row.Cells["DonGia"].Value.ToString();
            }
        }

        private void ClearFields()
        {
            txtMaSP.Clear();
            txtTenSP.Clear();
            txtDonvitinh.Clear();
            txtDongia.Clear();
        }
    }
}
