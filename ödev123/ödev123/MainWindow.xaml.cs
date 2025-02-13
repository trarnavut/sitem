using System.Windows;

namespace BHealthyApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnBMIActivities_Click(object sender, RoutedEventArgs e)
        {
            BMIActivitiesWindow bmiWindow = new BMIActivitiesWindow();
            bmiWindow.Show();
            this.Hide(); // Ana pencereyi gizle
            bmiWindow.Closed += (s, args) => this.Show(); //BMI penceresi kapandığında ana pencereyi göster.
        }

        private void btnBeHealthyWebPage_Click(object sender, RoutedEventArgs e)
        {
            BeHealthyWebPageWindow webPageWindow = new BeHealthyWebPageWindow();
            webPageWindow.Show();
            this.Hide();// Ana pencereyi gizle
            webPageWindow.Closed += (s, args) => this.Show(); //Web sayfası penceresi kapandığında ana pencereyi göster.
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}