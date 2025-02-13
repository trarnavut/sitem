using System;
using System.Windows;

namespace HealthApp
{
    public partial class WebWindow : Window
    {
        public WebWindow()
        {
            InitializeComponent();
        }

        private void ShowWebPage(object sender, RoutedEventArgs e)
        {
            WebFrame.Navigate(new Uri("https://www.who.int/"));
        }

        private void BackToMenu(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
