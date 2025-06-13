using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            int num1 = Convert.ToInt32(txtOp1.Text);
            int num2 = Convert.ToInt32(txtOp2.Text);
            int answer = num1 + num2;
            txtAns.Text = answer.ToString();
        }

        private void btnSubtract_Click(object sender, RoutedEventArgs e)
        {
            int num1 = Convert.ToInt32(txtOp1.Text);
            int num2 = Convert.ToInt32(txtOp2.Text);
            int answer = num1 - num2;
            txtAns.Text = answer.ToString();
        }

        private void chkCenter_Checked_1(object sender, RoutedEventArgs e)
        {
            if ((bool)chkCenter.IsChecked)
            {
                txtOp1.TextAlignment = TextAlignment.Center;
                txtOp2.TextAlignment = TextAlignment.Center;
                txtAns.TextAlignment = TextAlignment.Center;
            }
            else
            {
                txtOp1.TextAlignment = TextAlignment.Left;
                txtOp2.TextAlignment = TextAlignment.Left;
                txtAns.TextAlignment = TextAlignment.Left;
            }
        }
    }
}