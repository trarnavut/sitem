using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace HealthApp
{
    public partial class BMIUserControl : UserControl
    {
        public BMIUserControl()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double height = double.Parse(HeightTextBox.Text);
                double weight = double.Parse(WeightTextBox.Text);
                double bmi = weight / (height * height);

                ResultTextBox.Text = bmi.ToString("F2");

                if (bmi >= 18.5 && bmi <= 25)
                {
                    ResultTextBox.Background = Brushes.Green;
                }
                else
                {
                    ResultTextBox.Background = Brushes.Red;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter valid numeric values for height and weight.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
