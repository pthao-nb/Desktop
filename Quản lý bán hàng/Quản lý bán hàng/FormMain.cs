using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyBanHang;

namespace Quản_lý_bán_hàng
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void btnQuanlysanpham_Click(object sender, EventArgs e)
        {
            FormSanPham formSP = new FormSanPham(); // form quản lý sản phẩm
            formSP.ShowDialog();
        }

        private void btnQuanlyhoadon_Click(object sender, EventArgs e)
        {
            FormHoaDon formHD = new FormHoaDon(); // form quản lý hóa đơn (bạn đã làm)
            formHD.ShowDialog();
        }
    }
}
