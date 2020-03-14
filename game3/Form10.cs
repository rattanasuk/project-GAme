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
    public partial class Form10 : Form
    {

        bool left = false;
        bool right = false;
        bool jump = false;

        int jumpSpeed = 10;
        int force = 8;
        int score = 0;

        public Form10()
        {
            InitializeComponent();
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                left = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                right = true;
            }
            if (e.KeyCode == Keys.Space && !jump)
            {
                jump = true;
            }

            player.Top += jumpSpeed;

            if (jump && force < 0)
            {
                jump = false;
            }
            if (left)
            {
                player.Left -= 5;
            }
            if (right)
            {
                player.Left += 5;
            }
            if (jump)
            {
                jumpSpeed = -12;
                force -= 1;
            }
            else
            {
                jumpSpeed = 12;
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "platform")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds) && !jump)
                    {
                        force = 8;
                        player.Top = x.Top - player.Height;
                    }
                }

                if (x is PictureBox && x.Tag == "coin")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds) && !jump)
                    {
                        this.Controls.Remove(x);
                        score++;
                    }
                }
            }

            if (player.Bounds.IntersectsWith(door.Bounds))
            {
                timer1.Stop();
                MessageBox.Show("You WIN");
            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                left = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                right = false;
            }
            if (jump)
            {
                jump = false;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            player.Top += jumpSpeed;

            if (jump && force < 0)
            {
                jump = false;
            }
            if (left)
            {
                player.Left -= 5;
            }
            if (right)
            {
                player.Left += 5;
            }
            if (jump)
            {
                jumpSpeed = -12;
                force -= 1;
            }
            else
            {
                jumpSpeed = 12;
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "platform")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds) && !jump)
                    {
                        force = 8;
                        player.Top = x.Top - player.Height;
                    }
                }

                if (x is PictureBox && x.Tag == "coin")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds) && !jump)
                    {
                        this.Controls.Remove(x);
                        score++;
                    }
                }
            }

            if (player.Bounds.IntersectsWith(door.Bounds))
            {
                timer1.Stop();
                MessageBox.Show("You WIN");
            }
        }
    }
}
