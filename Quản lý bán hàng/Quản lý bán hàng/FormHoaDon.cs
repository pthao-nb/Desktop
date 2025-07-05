using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class FormHoaDon : Form
    {
        private string connectionString = "Data Source=.;Initial Catalog=QLBANHANG;Integrated Security=True";

        public FormHoaDon()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            LoadSanPham();
            LoadKhachHang();

            // Gán sự kiện
            cboTenSP.SelectedIndexChanged += cboTenSP_SelectedIndexChanged;
            nudSoluong.ValueChanged += nudSoluong_ValueChanged;

            // Cấu hình DataGridView
            dgvChitietHD.ColumnCount = 5;
            dgvChitietHD.Columns[0].Name = "Mã SP";
            dgvChitietHD.Columns[1].Name = "Tên sản phẩm";
            dgvChitietHD.Columns[2].Name = "Số lượng";
            dgvChitietHD.Columns[3].Name = "Đơn giá";
            dgvChitietHD.Columns[4].Name = "Thành tiền";
        }

        private void LoadSanPham()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM SanPham", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cboTenSP.DataSource = dt;
                cboTenSP.DisplayMember = "TenSP";
                cboTenSP.ValueMember = "MaSP";

                if (dt.Rows.Count > 0)
                    txtDongia.Text = dt.Rows[0]["DonGia"].ToString();
            }
        }

        private void LoadKhachHang()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM KhachHang", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cboTenKH.DataSource = dt;
                cboTenKH.DisplayMember = "TenKH";
                cboTenKH.ValueMember = "MaKH";
            }
        }

        // Đổi tên cho đúng control event handler
        private void cboTenSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTenSP.SelectedValue != null)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT DonGia FROM SanPham WHERE MaSP = @MaSP";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MaSP", cboTenSP.SelectedValue.ToString());

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        txtDongia.Text = dt.Rows[0]["DonGia"].ToString();
                        TinhThanhTien();
                    }
                }
            }
        }

        private void nudSoluong_ValueChanged(object sender, EventArgs e)
        {
            TinhThanhTien();
        }

        private void TinhThanhTien()
        {
            int soLuong = (int)nudSoluong.Value;
            if (decimal.TryParse(txtDongia.Text, out decimal donGia))
            {
                decimal thanhTien = soLuong * donGia;
                txtThanhtien.Text = thanhTien.ToString("N0");
            }
        }

        private void TinhTongTien()
        {
            decimal tongTien = 0;
            foreach (DataGridViewRow row in dgvChitietHD.Rows)
            {
                if (row.IsNewRow) continue;

                if (decimal.TryParse(row.Cells[4].Value.ToString(), out decimal thanhTien))
                {
                    tongTien += thanhTien;
                }
            }
            txtTongtien.Text = tongTien.ToString("N0") + " VNĐ";
        }

        private void btnHienthi_Click_1(object sender, EventArgs e)
        {
            if (cboTenSP.SelectedValue == null) return;

            string maSP = cboTenSP.SelectedValue.ToString();
            string tenSP = cboTenSP.Text;
            int soLuong = (int)nudSoluong.Value;
            decimal donGia = Convert.ToDecimal(txtDongia.Text);
            decimal thanhTien = soLuong * donGia;

            // Thêm dòng vào DataGridView
            dgvChitietHD.Rows.Add(maSP, tenSP, soLuong, donGia.ToString("N0"), thanhTien.ToString("N0"));

            // Cập nhật tổng tiền
            TinhTongTien();
        }
    }
}
