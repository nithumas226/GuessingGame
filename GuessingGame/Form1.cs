using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessingGame
{
    public partial class Form1 : Form
    {
        //Generating a random number and having a place to hold the players guess
        Random randGen = new Random();
        int actualValue;
        public Form1()
        {
            InitializeComponent();
            //Registering the random number as the value needed to guess
            actualValue = randGen.Next(1, 101);
            
        }

        private void guessButton_Click(object sender, EventArgs e)
        {
            //Creating and registering the players guess
            int playerGuess;
            playerGuess = Convert.ToInt32(numberInput.Text);

            //Register absolute number to see how far away the guess is
            int numAbsolute;
            numAbsolute = Math.Abs(playerGuess);

            //Determine if the player is too high, low or correct and displaying message
            if (playerGuess > actualValue)
            {
                outputLabel.Text = "Too High";
            }
            else if (playerGuess < actualValue)
            {
                outputLabel.Text = "Too Low";
            }
            else
            {
                outputLabel.Text = "Congrats. You Got It";
            }

        }
    }
}
