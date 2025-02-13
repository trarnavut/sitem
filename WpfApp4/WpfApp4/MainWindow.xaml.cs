using System.Windows;

namespace HealthApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BMIButton_Click(object sender, RoutedEventArgs e)
        {
            Window1 bmiWindow = new Window1();
            bmiWindow.Show();
            this.Hide();
        }

        private void WebPageButton_Click(object sender, RoutedEventArgs e)
        {
            Window2 webPageWindow = new Window2();
            webPageWindow.Show();
            this.Hide();
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
