using System;
using System.Windows.Controls;
using System.Windows.Media;

namespace BHealthyApp
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void Calculate_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if (double.TryParse(txtWeight.Text, out double weight) &&
                double.TryParse(txtHeight.Text, out double height) &&
                height != 0)
            {
                // Convert height to meters for accurate BMI calculation
                height = height / 100;  // Assuming height is entered in centimeters

                double bmi = weight / (height * height);
                txtBMI.Text = bmi.ToString("F2"); // Format to two decimal places

                // Update background color based on BMI range
                if (bmi >= 18.5 && bmi <= 25)
                {
                    txtBMI.Background = Brushes.Green;
                }
                else
                {
                    txtBMI.Background = Brushes.Red;
                }
            }
            else
            {
                txtBMI.Text = "Invalid input";
                txtBMI.Background = Brushes.Yellow;
            }
        }
    }
}