using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;


namespace PlayGameArcade
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        bool coinOn = false;
        SoundPlayer errorSound = new SoundPlayer(Properties.Resources.errorSound);
        public Form1()
        {
            InitializeComponent();
        }
        private void startButton_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            SoundPlayer countSound1 = new SoundPlayer(Properties.Resources.arcadeCountdown1);
            SoundPlayer countSound2 = new SoundPlayer(Properties.Resources.arcadeCountdown2);
            SoundPlayer countSound3 = new SoundPlayer(Properties.Resources.arcadeCountdown3);
            SoundPlayer startSound = new SoundPlayer(Properties.Resources.gameStart);
            SoundPlayer musicLoop = new SoundPlayer(Properties.Resources.gameMusic);
            startButton.Hide();
            insertCoin.Text = "Get Ready";
            startPrompt.Text = ":Starting In:";
            Thread.Sleep(250);

            countSound1.Play();
            Form1.ActiveForm.BackColor = Color.Black;
            countdown.Visible = true;
            Refresh();

            Thread.Sleep(1000);
            countdown.Text = "2";
            countSound2.Play();
            Refresh();

            Thread.Sleep(1000);
            countSound3.Play();
            countdown.Text = "1";
            Refresh();

            Thread.Sleep(1000);
            startSound.Play();
            countdown.Text = ":GO:";
            startPrompt.Text = "Game Starting";
            Form1.ActiveForm.BackColor = Color.RoyalBlue;
            Refresh();

            Thread.Sleep(1000);
            musicLoop.Play();
            Form1.ActiveForm.BackgroundImage = Properties.Resources.gameStarted;
            Refresh();
            Thread.Sleep(500);
            timer2.Enabled = true;
        }

        private void startPrompt_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (coinOn == false)
            {
                insertCoin.Visible = true;
                coinOn = true;
            }
            else
            {
                insertCoin.Visible = false;
                coinOn = false;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Form1.ActiveForm.BackgroundImage = Properties.Resources.glitchScreen;
            if (coinOn == false)
            {
                int colorGenerator = rnd.Next(1, 9);
                if (colorGenerator == 1)
                {
                    errorText.ForeColor = Color.Red;

                }
                if (colorGenerator == 2)
                {
                    errorText.ForeColor = Color.Orange;

                }
                if (colorGenerator == 3)
                {
                    errorText.ForeColor = Color.Yellow;

                }
                if (colorGenerator == 4)
                {
                    errorText.ForeColor = Color.Green;

                }
                if (colorGenerator == 5)
                {
                    errorText.ForeColor = Color.Blue;

                }
                if (colorGenerator == 6)
                {
                    errorText.ForeColor = Color.Indigo;

                }
                if (colorGenerator == 7)
                {
                    errorText.ForeColor = Color.Violet;

                }
                if (colorGenerator == 8)
                {
                    errorText.ForeColor = Color.Black;

                }
                if (colorGenerator == 9)
                {
                    errorText.ForeColor = Color.White;
                }
                errorText.Visible = true;
                errorSound.Play();
                coinOn = true;
            }
            else
            {
                errorText.Visible = false;
                errorSound.Play();
                coinOn = false;
            }
        }
    }
}
