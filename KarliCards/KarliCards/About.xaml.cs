using System.Windows;

namespace KarliCards
{
    public partial class About : Window
    {
        public About()
        {
            InitializeComponent();
        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            // Mở cửa sổ Options.xaml
            Options optionsWindow = new Options();
            optionsWindow.Show();

            // Đóng cửa sổ About.xaml
            this.Close();
        }
    }
}
