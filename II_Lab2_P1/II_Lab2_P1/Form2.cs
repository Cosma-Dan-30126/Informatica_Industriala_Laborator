using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace II_Lab2_P1
{
    public partial class Form2 : Form
    {
        private string username;

        public Form2(string username)
        {
            InitializeComponent();
            label1.Text = "Hello, " + username + "!";
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}


