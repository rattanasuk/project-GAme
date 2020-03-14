using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace game3
{
    public partial class Form5 : Form
    {

        bool Jump = false;
        int pipeSpeed = 5;
        int gravity = 5;
        int Inscore = 0;
       
        public Form5()
        {
            InitializeComponent();
            scoreText.Text = "Game Over!";
            endText2.Text = "Your final score is : " + endText1.Text;
            gameDesigner.Text = "Game Designed By your name here";
            scoreText.Visible = false;
            endText2.Visible = false;
            gameDesigner.Visible = false;
            new Settings();
            

            StartGame();
        }
        private void gameTimer_Tick(object sender, EventArgs e)
        {
            pipeBottom.Left -= pipeSpeed;
            pipeTop.Left -= pipeSpeed;
            FlappyBird.Top += gravity;
            endText1.Text = "" + Inscore;
            endText2.Text = "Your final score is : " + endText1.Text;

           
            if (pipeBottom.Left < -80)
            {
                pipeBottom.Left = 1000;
                Inscore += 1;
            }
            else if (pipeTop.Left < -95)
            {
                pipeTop.Left = 1100;
                Inscore += 1;
            }
            if (FlappyBird.Bounds.IntersectsWith(ground.Bounds))
            {
                endGame();
            }
            else if (FlappyBird.Bounds.IntersectsWith(pipeBottom.Bounds))
            {
                endGame();
            }
            else if (FlappyBird.Bounds.IntersectsWith(pipeTop.Bounds))
            {
                endGame();
               
            }
        }

        private void GameKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {

                Jump = true;
                gravity = -5;
            }
        }

        private void GameKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {

                Jump = false;
                gravity = 5;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
        }

        private void endGame()
        {
            gameTimer.Stop();
            scoreText.Visible = true;
            endText2.Visible = true;
            gameDesigner.Visible = true;
            if (Settings.GameOver == true)
            {
                if (Input.KeyPress(Keys.Enter))
                {
                    StartGame();
                }
            }



        }

        private void pipeTop_Click(object sender, EventArgs e)
        {

        }

        private void pipeBottom_Click(object sender, EventArgs e)
        {

        }
        private void StartGame()
        {
            gameTimer.Start();
            pipeBottom.Left -= pipeSpeed;
            pipeTop.Left -= pipeSpeed;
            FlappyBird.Top += gravity;
            endText1.Text = "" + Inscore;
            endText2.Text = "Your final score is : " + endText1.Text;
            new Settings();
            scoreText.Visible = false;
            endText2.Visible = false;
            gameDesigner.Visible = false;
        }
    }
}
