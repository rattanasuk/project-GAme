﻿using System;
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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void play_Click_1(object sender, EventArgs e)
        {
           
            if (bestScoreCheck.Checked )
            {
                MainForm mainForm = new MainForm(true);
                mainForm.Show();
            }
            else
            {
                MainForm mainForm = new MainForm(false);
                mainForm.Show();
            }
        }
        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void about_Click(object sender, EventArgs e)
        {
            MessageBox.Show("By Game.ICT");
        }
    }
}
