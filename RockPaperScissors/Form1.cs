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
        int draw = 0;    
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
            return cpuPick = rand.Next(1, 4);
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
        // method to toString the scores
        private void parseEm()
        {
            labelTieScore.Text = draw.ToString();
            labelUserScore.Text = userScore.ToString();
            labelCpuScore.Text = cpuScore.ToString();

        }
        // method to update score, rock=1, paper=2, scissors=3, u =user, c=cpu
        private void update(int d, int u, int c)
        {
            if (u == 1 && c == 1)
            {
                draw++;
                pictureBoxUserChoice.Image = Properties.Resources.rock;
                pictureBoxCpuChoice.Image = Properties.Resources.rock;
                
            }
            if (u == 1 && c == 2)
            {
                cpuScore++;
                pictureBoxUserChoice.Image = Properties.Resources.rock;
                pictureBoxCpuChoice.Image = Properties.Resources.paper;
            }
            if (u == 1 && c == 3)
            {
                userScore++;
                pictureBoxUserChoice.Image = Properties.Resources.rock;
                pictureBoxCpuChoice.Image = Properties.Resources.scissors;
            }
            if (u == 2 && c == 1)
            {
                userScore++;
                pictureBoxUserChoice.Image = Properties.Resources.paper;
                pictureBoxCpuChoice.Image = Properties.Resources.rock;
            }
            if (u == 2 && c == 2)
            {
                draw++;
                pictureBoxUserChoice.Image = Properties.Resources.paper;
                pictureBoxCpuChoice.Image = Properties.Resources.paper;
            }
            if (u == 2 && c == 3)
            {
                cpuScore++;
                pictureBoxUserChoice.Image = Properties.Resources.paper;
                pictureBoxCpuChoice.Image = Properties.Resources.scissors;
            }
            if (u == 3 && c == 1)
            {
                cpuScore++;
                pictureBoxUserChoice.Image = Properties.Resources.scissors;
                pictureBoxCpuChoice.Image = Properties.Resources.rock;
            }
            if (u == 3 && c == 2)
            {
                userScore++;
                pictureBoxUserChoice.Image = Properties.Resources.scissors;
                pictureBoxCpuChoice.Image = Properties.Resources.paper;
            }
            if (u == 3 && c == 3)
            {
                draw++;
                pictureBoxUserChoice.Image = Properties.Resources.scissors;
                pictureBoxCpuChoice.Image = Properties.Resources.scissors;
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
