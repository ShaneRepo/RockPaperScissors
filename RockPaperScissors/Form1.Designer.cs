namespace RockPaperScissors
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.labelScoreUser = new System.Windows.Forms.Label();
            this.labelUserScore = new System.Windows.Forms.Label();
            this.labelUserChoice = new System.Windows.Forms.Label();
            this.labelCpuChoice = new System.Windows.Forms.Label();
            this.pictureBoxUserChoice = new System.Windows.Forms.PictureBox();
            this.pictureBoxCpuChoice = new System.Windows.Forms.PictureBox();
            this.labelScoreCpu = new System.Windows.Forms.Label();
            this.labelCpuScore = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonScissors = new System.Windows.Forms.RadioButton();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.radioButtonPaper = new System.Windows.Forms.RadioButton();
            this.radioButtonRock = new System.Windows.Forms.RadioButton();
            this.buttonEndGame = new System.Windows.Forms.Button();
            this.labelTie = new System.Windows.Forms.Label();
            this.labelTieScore = new System.Windows.Forms.Label();
            this.buttonHelp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserChoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCpuChoice)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(305, 168);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(12, 203);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(119, 23);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "Start Game";
            this.buttonStart.UseVisualStyleBackColor = true;
            // 
            // labelScoreUser
            // 
            this.labelScoreUser.AutoSize = true;
            this.labelScoreUser.Location = new System.Drawing.Point(554, 360);
            this.labelScoreUser.Name = "labelScoreUser";
            this.labelScoreUser.Size = new System.Drawing.Size(63, 13);
            this.labelScoreUser.TabIndex = 2;
            this.labelScoreUser.Text = "User Score:";
            // 
            // labelUserScore
            // 
            this.labelUserScore.AutoSize = true;
            this.labelUserScore.Location = new System.Drawing.Point(560, 411);
            this.labelUserScore.Name = "labelUserScore";
            this.labelUserScore.Size = new System.Drawing.Size(57, 13);
            this.labelUserScore.TabIndex = 3;
            this.labelUserScore.Text = "labelScore";
            // 
            // labelUserChoice
            // 
            this.labelUserChoice.AutoSize = true;
            this.labelUserChoice.Location = new System.Drawing.Point(552, 24);
            this.labelUserChoice.Name = "labelUserChoice";
            this.labelUserChoice.Size = new System.Drawing.Size(65, 13);
            this.labelUserChoice.TabIndex = 4;
            this.labelUserChoice.Text = "User Choice";
            // 
            // labelCpuChoice
            // 
            this.labelCpuChoice.AutoSize = true;
            this.labelCpuChoice.Location = new System.Drawing.Point(880, 24);
            this.labelCpuChoice.Name = "labelCpuChoice";
            this.labelCpuChoice.Size = new System.Drawing.Size(65, 13);
            this.labelCpuChoice.TabIndex = 5;
            this.labelCpuChoice.Text = "CPU Choice";
            // 
            // pictureBoxUserChoice
            // 
            this.pictureBoxUserChoice.Image = global::RockPaperScissors.Properties.Resources.rock;
            this.pictureBoxUserChoice.Location = new System.Drawing.Point(479, 67);
            this.pictureBoxUserChoice.Name = "pictureBoxUserChoice";
            this.pictureBoxUserChoice.Size = new System.Drawing.Size(225, 225);
            this.pictureBoxUserChoice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxUserChoice.TabIndex = 6;
            this.pictureBoxUserChoice.TabStop = false;
            // 
            // pictureBoxCpuChoice
            // 
            this.pictureBoxCpuChoice.Image = global::RockPaperScissors.Properties.Resources.scissors;
            this.pictureBoxCpuChoice.Location = new System.Drawing.Point(813, 67);
            this.pictureBoxCpuChoice.Name = "pictureBoxCpuChoice";
            this.pictureBoxCpuChoice.Size = new System.Drawing.Size(225, 225);
            this.pictureBoxCpuChoice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxCpuChoice.TabIndex = 7;
            this.pictureBoxCpuChoice.TabStop = false;
            // 
            // labelScoreCpu
            // 
            this.labelScoreCpu.AutoSize = true;
            this.labelScoreCpu.Location = new System.Drawing.Point(894, 362);
            this.labelScoreCpu.Name = "labelScoreCpu";
            this.labelScoreCpu.Size = new System.Drawing.Size(63, 13);
            this.labelScoreCpu.TabIndex = 8;
            this.labelScoreCpu.Text = "CPU Score:";
            // 
            // labelCpuScore
            // 
            this.labelCpuScore.AutoSize = true;
            this.labelCpuScore.Location = new System.Drawing.Point(894, 415);
            this.labelCpuScore.Name = "labelCpuScore";
            this.labelCpuScore.Size = new System.Drawing.Size(57, 13);
            this.labelCpuScore.TabIndex = 9;
            this.labelCpuScore.Text = "labelScore";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonScissors);
            this.groupBox1.Controls.Add(this.buttonSubmit);
            this.groupBox1.Controls.Add(this.radioButtonPaper);
            this.groupBox1.Controls.Add(this.radioButtonRock);
            this.groupBox1.Location = new System.Drawing.Point(52, 297);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 229);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Make Selection";
            // 
            // radioButtonScissors
            // 
            this.radioButtonScissors.AutoSize = true;
            this.radioButtonScissors.Location = new System.Drawing.Point(26, 161);
            this.radioButtonScissors.Name = "radioButtonScissors";
            this.radioButtonScissors.Size = new System.Drawing.Size(64, 17);
            this.radioButtonScissors.TabIndex = 2;
            this.radioButtonScissors.TabStop = true;
            this.radioButtonScissors.Text = "Scissors";
            this.radioButtonScissors.UseVisualStyleBackColor = true;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(52, 200);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(152, 23);
            this.buttonSubmit.TabIndex = 11;
            this.buttonSubmit.Text = "Submit Selection";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            // 
            // radioButtonPaper
            // 
            this.radioButtonPaper.AutoSize = true;
            this.radioButtonPaper.Location = new System.Drawing.Point(26, 114);
            this.radioButtonPaper.Name = "radioButtonPaper";
            this.radioButtonPaper.Size = new System.Drawing.Size(53, 17);
            this.radioButtonPaper.TabIndex = 1;
            this.radioButtonPaper.TabStop = true;
            this.radioButtonPaper.Text = "Paper";
            this.radioButtonPaper.UseVisualStyleBackColor = true;
            // 
            // radioButtonRock
            // 
            this.radioButtonRock.AutoSize = true;
            this.radioButtonRock.Location = new System.Drawing.Point(26, 61);
            this.radioButtonRock.Name = "radioButtonRock";
            this.radioButtonRock.Size = new System.Drawing.Size(51, 17);
            this.radioButtonRock.TabIndex = 0;
            this.radioButtonRock.TabStop = true;
            this.radioButtonRock.Text = "Rock";
            this.radioButtonRock.UseVisualStyleBackColor = true;
            // 
            // buttonEndGame
            // 
            this.buttonEndGame.Location = new System.Drawing.Point(139, 203);
            this.buttonEndGame.Name = "buttonEndGame";
            this.buttonEndGame.Size = new System.Drawing.Size(117, 23);
            this.buttonEndGame.TabIndex = 12;
            this.buttonEndGame.Text = "End Game";
            this.buttonEndGame.UseVisualStyleBackColor = true;
            this.buttonEndGame.Click += new System.EventHandler(this.buttonEndGame_Click);
            // 
            // labelTie
            // 
            this.labelTie.AutoSize = true;
            this.labelTie.Location = new System.Drawing.Point(721, 362);
            this.labelTie.Name = "labelTie";
            this.labelTie.Size = new System.Drawing.Size(61, 13);
            this.labelTie.TabIndex = 13;
            this.labelTie.Text = "Tie Games:";
            // 
            // labelTieScore
            // 
            this.labelTieScore.AutoSize = true;
            this.labelTieScore.Location = new System.Drawing.Point(725, 415);
            this.labelTieScore.Name = "labelTieScore";
            this.labelTieScore.Size = new System.Drawing.Size(57, 13);
            this.labelTieScore.TabIndex = 14;
            this.labelTieScore.Text = "labelScore";
            // 
            // buttonHelp
            // 
            this.buttonHelp.Location = new System.Drawing.Point(273, 203);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(75, 23);
            this.buttonHelp.TabIndex = 15;
            this.buttonHelp.Text = "Help";
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 591);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.labelTieScore);
            this.Controls.Add(this.labelTie);
            this.Controls.Add(this.buttonEndGame);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelCpuScore);
            this.Controls.Add(this.labelScoreCpu);
            this.Controls.Add(this.pictureBoxCpuChoice);
            this.Controls.Add(this.pictureBoxUserChoice);
            this.Controls.Add(this.labelCpuChoice);
            this.Controls.Add(this.labelUserChoice);
            this.Controls.Add(this.labelUserScore);
            this.Controls.Add(this.labelScoreUser);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.pictureBoxLogo);
            this.Name = "Form1";
            this.Text = "Rock Paper Scissors";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserChoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCpuChoice)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label labelScoreUser;
        private System.Windows.Forms.Label labelUserScore;
        private System.Windows.Forms.Label labelUserChoice;
        private System.Windows.Forms.Label labelCpuChoice;
        private System.Windows.Forms.PictureBox pictureBoxUserChoice;
        private System.Windows.Forms.PictureBox pictureBoxCpuChoice;
        private System.Windows.Forms.Label labelScoreCpu;
        private System.Windows.Forms.Label labelCpuScore;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonScissors;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.RadioButton radioButtonPaper;
        private System.Windows.Forms.RadioButton radioButtonRock;
        private System.Windows.Forms.Button buttonEndGame;
        private System.Windows.Forms.Label labelTie;
        private System.Windows.Forms.Label labelTieScore;
        private System.Windows.Forms.Button buttonHelp;
    }
}

