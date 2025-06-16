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
    public partial class Form2 : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-N50OPETB;Initial Catalog=QUANLYXE;Integrated Security=True");

        public Form2()
        {
            InitializeComponent();
            this.dgvThongtinxe.CellClick += new DataGridViewCellEventHandler(this.dgvThongtinxe_CellClick);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            cboGioiTinh.Items.Clear();
            cboGioiTinh.Items.Add("Nam");
            cboGioiTinh.Items.Add("Nữ");
            cboGioiTinh.SelectedIndex = 0;
        }

        private void LoadDanhSachXe()
        {
            string query = "SELECT * FROM XE";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();

            if (conn.State == ConnectionState.Closed)
                conn.Open();

            da.Fill(dt);
            conn.Close();

            dgvThongtinxe.AutoGenerateColumns = true;
            dgvThongtinxe.DataSource = dt;
        }

        private void ClearTextBoxes()
        {
            txtBienSo.Clear();
            txtHoTenKhachHang.Clear();
            txtNhanHieu.Clear();
            txtDiaChi.Clear();
            cboGioiTinh.SelectedIndex = 0;
            txtBienSo.Enabled = true; // mở lại textbox biển số khi xóa xong
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            LoadDanhSachXe();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string query = @"INSERT INTO XE (Bienso, HoTenKhachHang, NhanHieu, DiaChi, GioiTinh)
                             VALUES (@Bienso, @HoTen, @NhanHieu, @DiaChi, @GioiTinh)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Bienso", txtBienSo.Text);
            cmd.Parameters.AddWithValue("@HoTen", txtHoTenKhachHang.Text);
            cmd.Parameters.AddWithValue("@NhanHieu", txtNhanHieu.Text);
            cmd.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text);
            cmd.Parameters.AddWithValue("@GioiTinh", cboGioiTinh.Text);

            if (conn.State == ConnectionState.Closed)
                conn.Open();

            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Thêm xe thành công!");
            LoadDanhSachXe();
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBienSo.Text))
            {
                MessageBox.Show("Vui lòng chọn một xe để sửa.");
                return;
            }

            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                string query = @"
                    UPDATE XE
                    SET HoTenKhachHang = @TenKH,
                        NhanHieu = @NhanHieu,
                        DiaChi = @DiaChi,
                        GioiTinh = @GioiTinh
                    WHERE Bienso = @Bienso";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Bienso", txtBienSo.Text.Trim());
                cmd.Parameters.AddWithValue("@TenKH", txtHoTenKhachHang.Text.Trim());
                cmd.Parameters.AddWithValue("@NhanHieu", txtNhanHieu.Text.Trim());
                cmd.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text.Trim());
                cmd.Parameters.AddWithValue("@GioiTinh", cboGioiTinh.Text.Trim());

                int rows = cmd.ExecuteNonQuery();
                conn.Close();

                if (rows > 0)
                {
                    MessageBox.Show("Cập nhật thành công!");
                    LoadDanhSachXe();
                    ClearTextBoxes();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy xe để cập nhật.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi cập nhật: " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvThongtinxe.CurrentRow != null)
            {
                txtBienSo.Text = dgvThongtinxe.CurrentRow.Cells["Bienso"].Value.ToString();
            }

            DialogResult result = MessageBox.Show("Bạn có muốn xoá xe này không?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string query = "DELETE FROM XE WHERE Bienso=@Bienso";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Bienso", txtBienSo.Text);

                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                int rowsAffected = cmd.ExecuteNonQuery();
                conn.Close();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Xóa thành công!");
                    LoadDanhSachXe();
                    ClearTextBoxes();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy xe để xóa!");
                }
            }
        }

        private void dgvThongtinxe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0 && index < dgvThongtinxe.Rows.Count)
            {
                txtBienSo.Text = dgvThongtinxe.Rows[index].Cells["Bienso"].Value?.ToString();
                txtHoTenKhachHang.Text = dgvThongtinxe.Rows[index].Cells["HoTenKhachHang"].Value?.ToString();
                txtNhanHieu.Text = dgvThongtinxe.Rows[index].Cells["NhanHieu"].Value?.ToString();
                txtDiaChi.Text = dgvThongtinxe.Rows[index].Cells["DiaChi"].Value?.ToString();
                cboGioiTinh.Text = dgvThongtinxe.Rows[index].Cells["GioiTinh"].Value?.ToString();

                txtBienSo.Enabled = false; // khóa biển số khi sửa
            }
        }

        private void btnBaoduong_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }
    }
}
