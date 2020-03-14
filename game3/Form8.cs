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
    public partial class Form8 : Form
    {
        bool turn = true; 
        int turn_count = 0;
        static string Player1, Player2;
        
        public Form8()
        {
            InitializeComponent();
        }

        public static void setPlayerNames(string n1, string n2)
        {
           
            Player1 = n1;
            Player2 = n2;
        }


        private void abotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("By Game.ICT");
        }

        private void eToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
                b.Text = "X";
            else
                b.Text = "O";
            turn = !turn;
            b.Enabled = false;
            turn_count++;
            checkFormWinner();
            Console.Beep();
        }
        private void checkFormWinner()
        {
            bool there_is_a_winner = false;

            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled))
                there_is_a_winner = true;
            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
                there_is_a_winner = true;
            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
                there_is_a_winner = true;
            else if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
                there_is_a_winner = true;
            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
                there_is_a_winner = true;
            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled))
                there_is_a_winner = true;
            else if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
                there_is_a_winner = true;
            else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!C1.Enabled))
                there_is_a_winner = true;

            if (there_is_a_winner)
            {
                disableButtons();

                String winner = "";
                if (turn)
                {
                    winner = Player2;
                    o_win_count.Text = (Int32.Parse(o_win_count.Text) + 1).ToString();
                    Console.Beep();
                    Console.Beep();
                    Console.Beep();
                }
                else
                {
                    winner = Player1;
                    x_win_count.Text = (Int32.Parse(x_win_count.Text) + 1).ToString();
                    Console.Beep();
                    Console.Beep();
                    Console.Beep();
                }           
                MessageBox.Show(winner + " Wins!", "ผู้ชนะ");
            }
            else
            {
                if (turn_count == 9)
                {                  
                    draw_count.Text = (Int32.Parse(draw_count.Text) + 1).ToString();
                    MessageBox.Show("Draw!", "ผลลัพธ์");
                    Console.Beep();
                    Console.Beep();
                    Console.Beep();
                }
            }

        }
        private void disableButtons()
        { 
            try
            {

                foreach (Control C in Controls)
                {
                    Button b = (Button)C;
                    b.Enabled = false;
                }
            }
            catch { }
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turn = true;
            turn_count = 0;

            

                foreach (Control C in Controls)
                {
                try
                  {
                    Button b = (Button)C;
                    b.Enabled = true;
                    b.Text = "";
                  }
                   catch { }
            }
            
        }

        private void button_enter(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Enabled)
            {
                if (turn)
                    b.Text = "X";
                else
                    b.Text = "O";
                Console.Beep();
                Console.Beep();
                Console.Beep();
            }
            Console.Beep();
            Console.Beep();
            Console.Beep();
        }

        private void button_leave(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Enabled)
            {
                b.Text = "";
                Console.Beep();
                Console.Beep();
                Console.Beep();
            }
        }

        private void resetWinCountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            o_win_count.Text = "0";
            x_win_count.Text = "0";
            draw_count.Text = "0";
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form9 f2 = new Form9();
            f2.ShowDialog();
            label1.Text = Player1;
            label3.Text = Player2;
        }
    }
}
