using System.Windows;

namespace HealthApp
{
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        private void ShowWebPageButton_Click(object sender, RoutedEventArgs e)
        {
            
            WebFrame.Source = new Uri("https://www.who.int/");
        }

        private void BackToMenuButton_Click(object sender, RoutedEventArgs e)
        {
            
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
