using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace II_Tema1
{
    public partial class Form1 : Form

    {
        private List<Animal> animale = new List<Animal>();
        public Form1()
        {
            InitializeComponent();
            InitializeComboBox();
        }

        private void InitializeComboBox()
        {
            comboBoxAnimalute.Items.Add("Caine");
            comboBoxAnimalute.Items.Add("Soparla");
            comboBoxAnimalute.Items.Add("Pelican");
            comboBoxAnimalute.Items.Add("Pisica");
            comboBoxAnimalute.Items.Add("Paianjen");
            comboBoxAnimalute.Items.Add("Papagal");

        }

        private void addButtonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string name = textBoxNume.Text;
            string specie = comboBoxAnimalute.SelectedItem.ToString();
            if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(specie))
            {
                Animal animal = new Animal(name, specie);
                animale.Add(animal);
                UpdateListBox();
                DisplayAnimal(animal);
            }
            else
            {
                MessageBox.Show("Vă rugăm să completați toate câmpurile!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                animale.RemoveAt(listBox1.SelectedIndex);
                UpdateListBox();
                poza.Image = null;
            }
            else
            {
                MessageBox.Show("Vă rugăm să selectați un animal din lista de animale!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void EXIT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void UpdateListBox()
        {
            listBox1.Items.Clear();
            foreach (Animal animal in animale)
            { listBox1.Items.Add(animal); }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(listBox1.SelectedIndex)
            {
                case 0:
                    poza.Image = new Bitmap("D:\\A.Informatica_Industriala\\II_Tema1\\II_Tema1\\Resources\\Caine.jpeg");
                    break;
                case 1:
                    poza.Image = new Bitmap("D:\\A.Informatica_Industriala\\II_Tema1\\II_Tema1\\Resources\\Soparla.jpg");
                    break;
                case 2:
                    poza.Image = new Bitmap("D:\\A.Informatica_Industriala\\II_Tema1\\II_Tema1\\Resources\\Pelican.jpeg");
                    break;
                case 3:
                    poza.Image = new Bitmap("D:\\A.Informatica_Industriala\\II_Tema1\\II_Tema1\\Resources\\Pisica.jpg");
                    break;
                case 4:
                    poza.Image = new Bitmap("D:\\A.Informatica_Industriala\\II_Tema1\\II_Tema1\\Resources\\Paianjen.jpg");
                    break;
                case 5:
                    poza.Image = new Bitmap("D:\\A.Informatica_Industriala\\II_Tema1\\II_Tema1\\Resources\\Papagal.jpg");
                    break;


            }
        }

        private void DisplayAnimal(Animal animal)
        {
            poza.Image = animal.GetImage();

        }
    }

    public class Animal
    {
        public string Name { get; set; }
        public string Specie { get; set; }

        //Creeam un constructor pentru Animal
        public Animal(string nume, string specie)
        {
            Name = nume;
            Specie = specie;

        }

        //Scrierea informatiilor despre animal cu ajutorul metodei ToString
        public override string ToString()
        {
            return Name + " - " + Specie;
        }

        //Metoda cu scop de afisare a pozei animalului
        public Image GetImage()
        {
            if (Specie != null)
            {
                switch (Specie.ToLower())
                {
                    case "caine":
                        return Properties.Resources.Caine;
                    case "soparla":
                        return Properties.Resources.Soparla;
                    case "pelican":
                        return Properties.Resources.Pelican;
                    case "pisica":
                        return Properties.Resources.Pisica;
                    case "paianjen":
                        return Properties.Resources.Paianjen;
                    case "papagal":
                        return Properties.Resources.Papagal;
                    default:
                        return null;
                }
            }
            return null;
        }
    }

    }


