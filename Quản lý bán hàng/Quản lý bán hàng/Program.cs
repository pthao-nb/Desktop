using System;
using System.Windows.Forms;
using Quản_lý_bán_hàng;

namespace QuanLyBanHang
{
    static class Program
    {
        /// <summary>
        /// Điểm bắt đầu chính của ứng dụng.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Khởi động bằng FormMain
            Application.Run(new FormMain());
        }
    }
}
