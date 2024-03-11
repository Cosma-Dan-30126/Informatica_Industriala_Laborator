using System;
using System.IO;
using System.Windows.Forms;

namespace II_Lab2_P1
{
    public partial class Form1 : Form
    {
        private string filePath = @"D:\A.Informatica_Industriala\II_Lab2_P1\II_Lab2_P1\TextFile1.txt";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Verifică dacă fișierul de credențiale există
            if (File.Exists(filePath))
            {
                try
                {
                    // Deschide fișierul și citeste utilizatorul și parola
                    using (StreamReader sr = new StreamReader(filePath))
                    {
                        string username = sr.ReadLine();
                        string password = sr.ReadLine();
                        txtUsername.Text = username;
                        txtPassword.Text = password;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"A apărut o eroare la citirea din fișierul de credențiale: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Fișierul de credențiale nu există!");
            }
        }

        private bool CheckCredentials(string username, string password)
        {
            // Verifică utilizatorul și parola citite din fișier
            if (File.Exists(filePath))
            {
                try
                {
                    using (StreamReader sr = new StreamReader(filePath))
                    {
                        string fileUsername = sr.ReadLine();
                        string filePassword = sr.ReadLine();
                        return (username == fileUsername && password == filePassword);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"A apărut o eroare la citirea din fișierul de credențiale: {ex.Message}");
                }
            }
            return false;
        }


        private void Login_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Verifică utilizatorul și parola
            if (CheckCredentials(username, password))
            {
                // Autentificare reușită, deschide formularul secundar și ascunde formularul de login
                Form2 form2 = new Form2(username);
                form2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Utilizator sau parolă incorecte!");
            }
        }



    }
}