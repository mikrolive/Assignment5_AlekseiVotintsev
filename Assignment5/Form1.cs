using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        int number = 0;
        int guesses = 0; 
        public Form1()
        {
            InitializeComponent();
            generation();
        }

        private void generation()
        {
            number = random.Next(1, 100);

            guessthenumber.Text = "Guess the number from 1 to 100!";

        }
        private void numbercheck(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(guess.Text);

            guesses += 1;
            count.Text = "Count of guesses: " + guesses;

            if (i > number)
            {
                MessageBox.Show("Too high!");
            }
            else if (i < number)
            {
                MessageBox.Show("Too low!");
            }
            else
            {
                MessageBox.Show("Congratulations, you guessed the answer!");
                generation();
                guess.Text = "";
                guesses = 0;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void number_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
