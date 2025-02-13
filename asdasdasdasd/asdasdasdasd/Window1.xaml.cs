using BHealthyApp;
using System.Linq;
using System.Windows;

namespace BHealthyApp.Pages  // Assuming this is your namespace
{
    public partial class BMIAndActivities : Window
    {
        public BMIAndActivities()
        {
            InitializeComponent();
        }

        private void Result_Click(object sender, RoutedEventArgs e)
        {
            var selectedItems = ActivitiesListBox.SelectedItems;
            int selectedCount = selectedItems.Count;

            if (selectedCount == 0)
            {
                MessageBox.Show("You have not selected any activity!", "Result");
            }
            else if (selectedCount == 1)
            {
                MessageBox.Show("1 activity: Try to add more activities for a healthy lifestyle!", "Result");
            }
            else if (selectedCount == 2)
            {
                MessageBox.Show("2 activities: Healthy!", "Result");
            }
            else
            {
                MessageBox.Show($"{selectedCount} activities: Great! Keep it up!", "Result");
            }
        }

        private void VisitWeb_Click(object sender, RoutedEventArgs e)
        {
            var webWindow = new BeHealthyWeb();  // Assuming you have a BeHealthyWeb class for the website window
            webWindow.Show();
            this.Hide();
        }

        private void BackToMenu_Click(object sender, RoutedEventArgs e)
        {
            var mainWindow = new MainWindow();
            mainWindow.Show();
            this.Hide();
        }
    }
}