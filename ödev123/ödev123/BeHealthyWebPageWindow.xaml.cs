using System;
using System.Windows;

namespace BHealthyApp
{
    public partial class BeHealthyWebPageWindow : Window
    {
        public BeHealthyWebPageWindow()
        {
            InitializeComponent();
        }

        private void btnShowWebPage_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                webBrowser.Navigate(new Uri("https://www.who.int/"));
            }
            catch (UriFormatException ex)
            {
                MessageBox.Show("Geçersiz URL: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Web sayfası yüklenirken bir hata oluştu: " + ex.Message);
            }
        }

        private void btnBackToMenu_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}