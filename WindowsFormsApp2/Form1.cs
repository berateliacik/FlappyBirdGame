using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Runtime.InteropServices;


namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        int pipeSpeed = 8;
        int gravity = 15;
        int score = 0;



        [DllImport("winmm.dll")]
        private static extern int waveOutSetVolume(IntPtr hwo, uint dwVolume);

        public static void soundVolume(int volume)
        {
            int NewVolume = ((ushort.MaxValue / 10) * volume);
            uint NewVolumeAllChannels = (((uint)NewVolume & 0x0000ffff) | ((uint)NewVolume << 16));
            waveOutSetVolume(IntPtr.Zero, NewVolumeAllChannels);
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void endGame()
        {
            // this is the game end function, this function will when the bird touches the ground or the pipes
            gameTimer.Stop(); // stop the main timer
            //scoreText.Text += " GAME OVER!"; // show the game over text on the score text, += is used to add the new string of text next to the score instead of overriding it
            gameOverText.Text = "GAME OVER!";

            pictureBox1.Visible = true;

        }

        private void picture_Click(object sender, EventArgs e)
        {
            Form2 main = new Form2();
            main.Show();
            this.Hide();
        }

        private void GameTimerEvent(object sender, EventArgs e)
        {

            pictureBox1.Visible = false;

            flappyBird.Top += gravity; // link the flappy bird picture box to the gravity, += means it will add the speed of gravity to the picture boxes top location so it will move down
            pipeBottom.Left -= pipeSpeed; // link the bottom pipes left position to the pipe speed integer, it will reduce the pipe speed value from the left position of the pipe picture box so it will move left with each tick
            pipeTop.Left -= pipeSpeed; // the same is happening with the top pipe, reduce the value of pipe speed integer from the left position of the pipe using the -= sign
            scoreText.Text = "" + score; // show the current score on the score text label

            // below we are checking if any of the pipes have left the screen

            if (pipeBottom.Left < -150)
            {
                // if the bottom pipes location is -150 then we will reset it back to 800 and add 1 to the score
                pipeBottom.Left = 800;
                score++;
                System.Media.SoundPlayer sound = new System.Media.SoundPlayer();
                sound.SoundLocation = "point.wav";
                sound.Play();

            }
            if (pipeTop.Left < -180)
            {
                // if the top pipe location is -180 then we will reset the pipe back to the 950 and add 1 to the score
                pipeTop.Left = 950;
                score++;
                System.Media.SoundPlayer soundScore = new System.Media.SoundPlayer();
                soundScore.SoundLocation = "point.wav";
                soundScore.Play();
            }


            // the if statement below is checking if the pipe hit the ground, pipes or if the player has left the screen from the top
            // the two pipe symbols stand for OR inside of an if statement so we can have multiple conditions inside of this if statement because its all going to do the same thing

            if (flappyBird.Bounds.IntersectsWith(pipeBottom.Bounds) ||
                flappyBird.Bounds.IntersectsWith(pipeTop.Bounds) ||
                flappyBird.Bounds.IntersectsWith(ground.Bounds) || flappyBird.Top < -25
                )
            {
                // if any of the conditions are met from above then we will run the end game function
                System.Media.SoundPlayer soundOver = new System.Media.SoundPlayer();
                soundOver.SoundLocation = "over.wav";
                soundOver.Play();



                endGame();


            }

            // if score is greater then 5 then we will increase the pipe speed to 15
            if (score > 5)
            {
                pipeSpeed = 10;
            }

            // if score is greater then 5 then we will increase the pipe speed to 15
            if (score > 10)
            {
                pipeSpeed = 15;
            }

            if (score > 20)
            {
                pipeSpeed = 20;
            }


        }

        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                // if the space key is pressed then the gravity will be set to -15
                gravity = -15;
            }
        }

        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                // if the space key is released then gravity is set back to 15
                gravity = 15;
                System.Media.SoundPlayer soundJump = new System.Media.SoundPlayer();
                soundJump.SoundLocation = "jump.wav";
                soundJump.Play();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form2 main = new Form2();
            main.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pbOn_Click(object sender, EventArgs e)
        {
            pbOn.Visible = false;
            pbOff.Visible = true;

            soundVolume(0);

        }

        private void pbOff_Click(object sender, EventArgs e)
        {

            pbOff.Visible = false;
            pbOn.Visible = true;
            soundVolume(100);
        }


    }
}
