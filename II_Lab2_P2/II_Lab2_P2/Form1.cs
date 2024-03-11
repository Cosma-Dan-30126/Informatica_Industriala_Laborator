using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace II_Lab2_P2
{
    public partial class Form1 : Form
    {
        private string filePath = @"D:\A.Informatica_Industriala\II_Lab2_P2\II_Lab2_P2\TextFile1.txt";

        public Form1()
        {
            InitializeComponent();
            StreamReader stream = new StreamReader(filePath);
            { string line = " ";
                while ((line = stream.ReadLine()) != null)
                { listBox1.Items.Add(line); }
            }
        }

        private void Copiaza_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(listBox1.SelectedItem);
            
        }

        private void Sterge_Click(object sender, EventArgs e)
        {
            foreach (var item in listBox1.Items.Cast<object>().ToList())
            {
                listBox2.Items.Remove(item);
            }

        }



        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
