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
    public partial class BirdForm : Form
    {
        Form1 form1 = new Form1();
        int count = 0;

        string[] array = { "Sparrow", "Pigeon", "KingFisher", "Eagle", "Crane", "Owl", "Parrot", "Crow" };
        public BirdForm()
        {
            InitializeComponent();
            pictureBox6.Image = imageList1.Images[count];
            label9.Text = array[count];
            label13.Visible = false;
            label12.Visible = false;
            label11.Visible = false;
            label10.Visible = false;
            label17.Visible = false;
            label16.Visible = false;
            label15.Visible = false;
            label14.Visible = false;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (count < 8)
            {
                count++;
                try
                {
                    pictureBox6.Image = imageList1.Images[count];
                    label9.Text = array[count];
                }
                catch
                {
                    MessageBox.Show("The End");
                }
            }
            else
            {
                return;
            }
            
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(count > 0)
            {
                count--;
                pictureBox6.Image = imageList1.Images[count];
                label9.Text = array[count];
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            
            
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            label13.Visible = true;
            
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            label12.Visible = true;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            label11.Visible = true;
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            label10.Visible = true;
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            label17.Visible = true;
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            label16.Visible = true;
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            label15.Visible = true;
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            label14.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int correct = 0, wrong = 0;
            if(radioButton4.Checked)
            {
                correct++;
            }
            else
            {
                wrong++;
            }

            if (radioButton19.Checked)
            {
                correct++;
            }
            else
            {
                wrong++;
            }

            if (radioButton14.Checked)
            {
                correct++;
            }
            else
            {
                wrong++;
            }

            if (radioButton9.Checked)
            {
                correct++;
            }
            else
            {
                wrong++;
            }

            if(radioButton1.Checked == false && radioButton2.Checked == false && radioButton3.Checked == false && radioButton4.Checked == false)
            {
                MessageBox.Show("Option not Selected!");
                return;
            }

            if(radioButton17.Checked == false && radioButton18.Checked == false && radioButton19.Checked == false && radioButton20.Checked == false)
            {
                MessageBox.Show("Option not Selected!");
                return;
            }

            if(radioButton13.Checked == false && radioButton14.Checked == false && radioButton15.Checked == false && radioButton16.Checked == false)
            {
                MessageBox.Show("Option not Selected!");
                return;
            }

            if(radioButton9.Checked == false && radioButton10.Checked == false && radioButton11.Checked == false && radioButton12.Checked == false)
            {
                MessageBox.Show("Option not Selected!");
                return;
            }

            var ans =MessageBox.Show("Your Result : "+Environment.NewLine+
                "Correct Answers : "+correct.ToString()+ Environment.NewLine +
                "Wrong Answers : " + wrong.ToString()+Environment.NewLine +
                "CLick 'OK' to take the quiz again", "Caption"
                , MessageBoxButtons.OKCancel);
            if(ans == DialogResult.OK)
            {
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;
                radioButton17.Checked = false;
                radioButton18.Checked = false;
                radioButton19.Checked = false;
                radioButton20.Checked = false;
                radioButton13.Checked = false;
                radioButton14.Checked = false;
                radioButton15.Checked = false;
                radioButton16.Checked = false;
                radioButton9.Checked = false;
                radioButton10.Checked = false;
                radioButton11.Checked = false;
                radioButton12.Checked = false;
            }
            


        }

        private void AnimalForm_Load(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            form1.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            form1.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            form1.Show();
        }
    }
}
