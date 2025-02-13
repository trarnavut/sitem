using System.Windows;
using System.Windows.Media;

namespace HealthApp
{
    public partial class BMIWindow : Window
    {
        public BMIWindow()
        {
            InitializeComponent();
        }

        // BMI Hesaplama
        private void CalculateBMI(object sender, RoutedEventArgs e)
        {
            try
            {
                // Kullanıcıdan alınan boy ve kilo değerlerini hesaplama
                double height = double.Parse(HeightInput.Text);
                double weight = double.Parse(WeightInput.Text);

                if (height > 0 && weight > 0)
                {
                    double bmi = weight / (height * height);
                    BMIResult.Text = $"Your BMI: {bmi:F2}";
                    BMIResult.Background = (bmi >= 18.5 && bmi <= 25) ? Brushes.Green : Brushes.Red;
                }
                else
                {
                    MessageBox.Show("Please enter positive values for height and weight.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            catch
            {
                MessageBox.Show("Invalid input! Please enter numerical values.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        // Aktivite Kontrolü
        private void CheckActivities(object sender, RoutedEventArgs e)
        {
            if (ActivitiesList.SelectedItems.Count >= 2)
            {
                MessageBox.Show("You are active enough! Good job!", "Healthy", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Not enough physical activities selected.", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        // BeHealthy Web Sayfasına Geçiş
        private void OpenWebWindow(object sender, RoutedEventArgs e)
        {
            WebWindow webWindow = new WebWindow(); // WebWindow daha önce oluşturulmuş bir pencere
            webWindow.Show();
            this.Hide();
        }

        // Ana Menüye Dönüş
        private void BackToMenu(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
