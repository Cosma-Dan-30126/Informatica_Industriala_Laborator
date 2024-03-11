using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace II_Lab2_P4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listBox1.Items.Add("Audi");
            listBox1.Items.Add("BMW");
            listBox1.Items.Add("A6");
            listBox1.Items.Add("Seria5");
            listBox1.Items.Add("Motor mare");
            listBox1.Items.Add("Motor mic");

            // Vom adauga un eveniment pentru a ne putea apuca de selectarea elementelor din listBox
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            button1.Click += button1_Click;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string selectedItem = listBox1.SelectedItem.ToString();
            switch (selectedItem)
            {
                case "Audi":
                    pictureBox1.Image = Properties.Resources.car1; 
                    break;
                case "BMW":
                    pictureBox1.Image = Properties.Resources.car2; 
                    break;
                case "A6":
                    pictureBox1.Image = Properties.Resources.brand1; 
                    break;
                case "Seria5":
                    pictureBox1.Image = Properties.Resources.brand2; 
                    break;
                case "Motor mare":
                    pictureBox1.Image = Properties.Resources.engine1; 
                    break;
                case "Motor mic":
                    pictureBox1.Image = Properties.Resources.engine2; 
                    break;
                default:
                    pictureBox1.Image = null;
                    break;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string radioButton1Selection = radioButton1.Checked ? radioButton1.Text : radioButton2.Text;
            string radioButton2Selection = radioButton3.Checked ? radioButton3.Text : radioButton4.Text;
            MessageBox.Show($"Opțiunile selectate sunt:\n{radioButton1Selection}\n{radioButton2Selection}", "Rezultat");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
