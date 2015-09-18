using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScissors
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // declare & initilize variables
        const string HELP = "Select a radio button and click submit to play a round.\n" +
            "Win States: Rock beats Scissors and loses to Paper.\n" +
            "Scissors beats Paper and loses to Rock.\n" +
            "Paper beats Rock and loses to Scissors.\n" +
            "Scores are on the right. Good luck and have Fun!";
            
        int userScore = 0;  // user score
        int cpuScore = 0;  // cpu score
        int userPick = 0;  // user and cpu choices are as follows:
        int cpuPick = 0;  // 1 = rock  2 = paper  3 = scissors
        Boolean rock = false;
        Boolean paper = false;
        Boolean scissors = false;
        // method to display help instructions
        private void instructions()
        {
            MessageBox.Show(HELP);
        }
        // method to randomize cpu choice
        private int cpuSelection()
        {
            Random rand = new Random();
            return rand.Next(1, 4);
        }
        // method to get user choice
        private int userSelection()
        {
            if (radioButtonRock.Checked == true)
            {
                 return userPick = 1;
            }
            else if (radioButtonPaper.Checked == true)
            {
                return userPick = 2;
            }
            else 
            {
                return userPick = 3;
            }
        }
        // help click event
        private void buttonHelp_Click(object sender, EventArgs e)
        {
            instructions();
        }
        // end game click event
        private void buttonEndGame_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks for playing!");
            this.Close();
        }
    }
}
