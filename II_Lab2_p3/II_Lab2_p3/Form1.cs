using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace II_Lab2_p3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void adunareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double nr1) && double.TryParse(textBox2.Text, out double nr2))
            {
                double rezultat = nr1 + nr2;
                textBox3.Text = rezultat.ToString();
            }
            else
            {
                MessageBox.Show("Numerele nu corespund cerintei date!!!");
            }

        }

        private void scadereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double nr1) && double.TryParse(textBox2.Text, out double nr2))
            {
                double rezultat = nr1 - nr2;
                textBox3.Text = rezultat.ToString();
            }
            else
            {
                MessageBox.Show("Numerele nu corespund cerintei date!!!");
            }

        }

        private void inmultireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double nr1) && double.TryParse(textBox2.Text, out double nr2))
            {
                double rezultat = nr1 * nr2;
                textBox3.Text = rezultat.ToString();
            }
            else
            {
                MessageBox.Show("Numerele nu corespund cerintei date!!!");

            }


        }

        private void impartireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double nr1) && double.TryParse(textBox2.Text, out double nr2))
            {
                if (nr2 != 0)
                {
                    double rezultat = nr1 / nr2;
                    textBox3.Text = rezultat.ToString();
                }
                else
                {
                    MessageBox.Show("Nu se poate împărți la zero.");
                }
            }
            else
            {
                MessageBox.Show("Numerele nu corespund cerintei date!!!");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

       
}
