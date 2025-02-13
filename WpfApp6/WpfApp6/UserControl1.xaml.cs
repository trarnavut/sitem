using System;
using System.Windows;
using System.Windows.Controls;

namespace WPFUserControl
{
    /// <summary>
    /// Interaction logic for MyUserControl.xaml 
    /// </summary> 

    public partial class MyUserControl : UserControl
    {

        public MyUserControl()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            txtBox.Text = "You have just clicked the button";
        }
    }
}