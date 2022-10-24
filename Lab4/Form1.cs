using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void animals_Click(object sender, EventArgs e)
        {
           // animals.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            AnimalForm animalForm = new AnimalForm();
            animalForm.Show();
            Hide();
        }

        private void birds_Click(object sender, EventArgs e)
        {
            //birds.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            BirdForm birdForm = new BirdForm();
            birdForm.Show();
            Hide();
        }

        private void colors_Click(object sender, EventArgs e)
        {
            //colors.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            ColorForm colorForm = new ColorForm();
            colorForm.Show();
            Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
