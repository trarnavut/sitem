using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace HealthApp
{
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void ResultButton_Click(object sender, RoutedEventArgs e)
        {
            
            var selectedActivitiesCount = ActivitiesListBox.SelectedItems.Count;

            if (selectedActivitiesCount >= 2)
            {
                
                MessageBox.Show($"{selectedActivitiesCount} activities! Healthy!",
                                "Result",
                                MessageBoxButton.OK,
                                MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Not Enough Activity! Please select more activities.",
                                "Result",
                                MessageBoxButton.OK,
                                MessageBoxImage.Warning);
            }
        }

        private void VisitWebButton_Click(object sender, RoutedEventArgs e)
        {
            
            Window2 webWindow = new Window2();
            webWindow.Show();
            this.Close();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
           
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

       
    }
}
