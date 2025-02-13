using System;
using System.Windows;

namespace BHealthyApp
{
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        private void btnShowWebPage_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                webBrowser.Navigate(new Uri("https://www.who.int/"));
            }
            catch (UriFormatException)
            {
                MessageBox.Show("Geçersiz URL.");
            }
        }

        private void btnBackToMenu_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}