using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace QUANLYXE
{
    public partial class Form3 : Form
    {
        private string connectionString = "Data Source=LAPTOP-N50OPETB;Initial Catalog=QUANLYXE;Integrated Security=True";
        SqlConnection conn;

        public Form3()
        {
            InitializeComponent();
            conn = new SqlConnection(connectionString);
            this.Load += Form3_Load;
            cboBienso.SelectedIndexChanged += cboBienso_SelectedIndexChanged;
            btnThemchitiet.Click += btnThemchitiet_Click;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            LoadBienSo();
            LoadMaGoi();
            for (int i = 0; i < 30; i++)
            {
                DateTime day = DateTime.Today.AddDays(-i);
                cboThoigian.Items.Add(day.ToString("dd-MM-yyyy"));
            }
            cboThoigian.SelectedIndex = 0;
        }

        private void LoadBienSo()
        {
            cboBienso.Items.Clear();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT BienSo FROM XE";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cboBienso.Items.Add(reader.GetString(0));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải Biển số: " + ex.Message);
            }
        }

        private void LoadMaGoi()
        {
            cboMagoi.Items.Clear();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT MaGoi FROM GOIBAODUONG";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cboMagoi.Items.Add(reader.GetString(0));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải Mã gói: " + ex.Message);
            }
        }

        private void cboBienso_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboBienso.SelectedItem != null)
            {
                LoadLichSuBaoDuong(cboBienso.SelectedItem.ToString());
            }
        }

        private void LoadLichSuBaoDuong(string bienSo)
        {
            string query = @"SELECT ct.BienSo, xe.NhanHieu, ct.SoKMBaoDuong, ct.MaGoi,
                                    gd.TenGoi, ct.GiaTien, ct.ThoiGianBaoDuong
                            FROM CHITIET ct
                            LEFT JOIN XE xe ON ct.BienSo = xe.BienSo
                            LEFT JOIN GOIBAODUONG gd ON ct.MaGoi = gd.MaGoi
                            WHERE ct.BienSo = @BienSo";

            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            da.SelectCommand.Parameters.AddWithValue("@BienSo", bienSo);
            DataTable dt = new DataTable();
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                da.Fill(dt);
                dgvLichSuBaoDuong.DataSource = dt;

                // Tính tổng tiền - CÁCH AN TOÀN KHÔNG LỖI
                decimal tong = 0;
                foreach (DataRow row in dt.Rows)
                {
                    if (row["GiaTien"] != DBNull.Value)
                    {
                        try
                        {
                            tong += Convert.ToDecimal(row["GiaTien"]);
                        }
                        catch
                        {
                            // Nếu lỗi ép kiểu vẫn bỏ qua, không crash
                        }
                    }
                }

                lblTongtien.Text = $"Tổng tiền: {tong:#,##0} VNĐ";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThemchitiet_Click(object sender, EventArgs e)
        {
            string bienSo = cboBienso.Text;
            string maGoi = cboMagoi.Text;

            if (!int.TryParse(txtSokm.Text, out int soKm) ||
                !decimal.TryParse(txtGiatien.Text, out decimal giaTien))
            {
                MessageBox.Show("Số km hoặc giá tiền không hợp lệ!");
                return;
            }

            if (string.IsNullOrWhiteSpace(bienSo) || string.IsNullOrWhiteSpace(maGoi))
            {
                MessageBox.Show("Vui lòng chọn Biển số và Mã gói.");
                return;
            }

            if (!DateTime.TryParseExact(cboThoigian.Text, "dd-MM-yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime thoiGian))
            {
                MessageBox.Show("Ngày bảo dưỡng không hợp lệ.");
                return;
            }

            string insert = @"INSERT INTO CHITIET (BienSo, MaGoi, SoKMBaoDuong, GiaTien, ThoiGianBaoDuong)
                              VALUES (@BienSo, @MaGoi, @SoKm, @GiaTien, @ThoiGian)";

            SqlCommand cmd = new SqlCommand(insert, conn);
            cmd.Parameters.AddWithValue("@BienSo", bienSo);
            cmd.Parameters.AddWithValue("@MaGoi", maGoi);
            cmd.Parameters.AddWithValue("@SoKm", soKm);
            cmd.Parameters.AddWithValue("@GiaTien", giaTien);
            cmd.Parameters.AddWithValue("@ThoiGian", thoiGian);

            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                cmd.ExecuteNonQuery();
                MessageBox.Show("Đã thêm chi tiết bảo dưỡng.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm dữ liệu: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

            LoadLichSuBaoDuong(bienSo);

            txtSokm.Clear();
            txtGiatien.Clear();
        }

        private void dgvLichSuBaoDuong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Tùy chọn xử lý click vào dòng trong DataGridView nếu cần
        }
    }
}
