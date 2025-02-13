using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 DeptForm = new Form2();
            DeptForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                comboBox1.Items.Add("Computer Eng.");
                comboBox1.Items.Add("Software Eng");
                comboBox1.Items.Add("Information Systems Eng.");

            }
            private void button1_Click(object sender, EventArgs e)
            {
                MessageBox.Show("Your department:" + comboBox1.SelectedItem);
            }
        }
    }
}
