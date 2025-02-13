using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace BHealthyApp
{
    public partial class BMIUserControl : UserControl
    {
        public BMIUserControl()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(txtHeight.Text, out double height) && double.TryParse(txtWeight.Text, out double weight))
            {
                if (height <= 0 || weight <= 0)
                {
                    MessageBox.Show("Boy ve kilo değerleri 0'dan büyük olmalıdır.");
                    return;
                }
                double bmi = weight / (height * height);
                txtBMI.Text = bmi.ToString("0.00");

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
                MessageBox.Show("Lütfen geçerli sayısal değerler girin.");
            }
        }
    }
}