using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using BHealthyApp; // Assuming your BMIUserControl class resides here
using System.Diagnostics; // For opening a web browser

namespace BHealthyApp
{
    /// <summary>
    /// Interaction logic for BMIActivitiesWindow.xaml
    /// </summary>
    public partial class BMIActivitiesWindow : Window
    {
        public BMIActivitiesWindow()
        {
            InitializeComponent();
        }

        private void btnResult_Click(object sender, RoutedEventArgs e)
        {
            // Get weight and height values from BMIUserControl
            double weight;
            double height;

            try
            {
                weight = double.Parse(bmiControl.WeightTextBox.Text);
                height = double.Parse(bmiControl.HeightTextBox.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input. Please enter numeric values for weight and height.", "Error");
                return;
            }

            // Convert height to meters (assuming input is in centimeters)
            height /= 100;

            // Calculate BMI
            double bmi = weight / (height * height);

            // Display BMI with two decimal places
            ResultTextBox.Text = bmi.ToString("F2");

            // Set background color based on BMI category
            if (bmi >= 18.5 && bmi <= 25)
            {
                ResultTextBox.Background = Brushes.Green; // Healthy
            }
            else if (bmi < 18.5)
            {
                ResultTextBox.Background = Brushes.Orange; // Underweight
            }
            else
            {
                ResultTextBox.Background = Brushes.Red; // Overweight
            }
        }

        private void btnVisitWeb_Click(object sender, RoutedEventArgs e)
        {
            // Open Be Healthy website in a new browser window
            Process.Start("https://www.behealthy.com"); // Replace with actual URL
        }

        private void btnBackToMenu_Click(object sender, RoutedEventArgs e)
        {
            // Close this window (assuming there's no menu window to navigate to)
            this.Close();
        }
    }
}