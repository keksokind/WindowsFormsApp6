using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private int randomNumber;

        public Form1()
        {
            InitializeComponent();
            Random rnd = new Random();
            randomNumber = rnd.Next(0, 101);
        }

        private void inpBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void hint_big_or_low_Click(object sender, EventArgs e)
        {

        }

        private void checkNum_Click(object sender, EventArgs e)
        {
            int userInput;
            if (int.TryParse(inpBox.Text, out userInput))
            {
                if (userInput > randomNumber)
                {
                    hint_big_or_low.Text = "Less";
                }
                else if (userInput < randomNumber)
                {
                    hint_big_or_low.Text = "More";
                }
                else
                {
                    hint_big_or_low.Text = "You right!";
                }
            }
            else
            {
                hint_big_or_low.Text = "Type a number!";
            }
        }
    }
}