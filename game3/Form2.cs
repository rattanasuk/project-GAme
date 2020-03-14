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
    public partial class Form2 : Form
    {
        Int32 score = 0;
        public Form2()
        {
            InitializeComponent();
        }
        public void CheckButton(Button bttn1, Button bttn2)
        {
            if (bttn2.Text == "")
            {
                bttn2.Text = bttn1.Text;
                bttn1.Text = "";
            }
        }
        public void shuffle()
        {
            int i, j, RN;
            int[] a = new int[16];
            Boolean flag = false;
            i = 1;
            j = 1;

            do
            {
                Random rnd = new Random();

                RN = Convert.ToInt32((rnd.Next(0, 15)) + 1);
                for (j = 1; j <= i; j++)
                {
                    if (a[j] == RN)
                    {
                        flag = true;
                        break;
                    }

                }
                if (flag == true)
                {
                    flag = false;
                }
                else
                {
                    a[i] = RN;
                    i = i + 1;
                }
            }
            while (i <= 15);
            Button1.Text = Convert.ToString(a[1]);
            Button2.Text = Convert.ToString(a[2]);
            Button3.Text = Convert.ToString(a[3]);
            Button4.Text = Convert.ToString(a[4]);
            Button5.Text = Convert.ToString(a[5]);
            Button6.Text = Convert.ToString(a[6]);
            Button7.Text = Convert.ToString(a[7]);
            Button8.Text = Convert.ToString(a[8]);
            Button9.Text = Convert.ToString(a[9]);
            Button10.Text = Convert.ToString(a[10]);
            Button11.Text = Convert.ToString(a[11]);
            Button12.Text = Convert.ToString(a[12]);
            Button13.Text = Convert.ToString(a[13]);
            Button14.Text = Convert.ToString(a[14]);
            Button15.Text = Convert.ToString(a[15]);
            Button16.Text = "";
            label1.Text = "Score : " + score;
        }
        public void CheckSolved()
        {
            if (Button1.Text == "1" && Button2.Text == "2" && Button3.Text == "3" && Button4.Text == "4" && Button5.Text == "5" && Button6.Text == "6" && Button7.Text == "7" && Button8.Text == "8" && Button9.Text == "9" && Button10.Text == "10" && Button11.Text == "11" && Button12.Text == "12" && Button13.Text == "13" && Button14.Text == "14" && Button15.Text == "15" && Button16.Text == "")

            {
                score = score + 1 ;
                MessageBox.Show("สุดยอดผู้เล่น :" +score);
                
                
            }
            if (Button1.Text == "1" && Button2.Text == "2" && Button3.Text == "3" && Button4.Text == "4" && Button5.Text == "5" && Button6.Text == "6" && Button7.Text == "7" && Button8.Text == "8" && Button9.Text == "9"
                && Button10.Text == "10" && Button11.Text == "11" && Button12.Text == "12" && Button13.Text == "13" && Button14.Text == "14" && Button15.Text == "15" && Button16.Text == "")

            {
              
                
            }
            score = score + 1;
            label1.Text = "Score : " + score + "Click";

        }
        private void Button9_Click(object sender, EventArgs e)
        {

            CheckButton(Button9, Button5);
            CheckButton(Button9, Button10);
            CheckButton(Button9, Button13);

            CheckSolved();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            CheckButton(Button1, Button2);
            CheckButton(Button1, Button5);

            CheckSolved();
        }

        private void Button2_Click(object sender, EventArgs e)
        {

            CheckButton(Button2, Button1);
            CheckButton(Button2, Button3);
            CheckButton(Button2, Button6);

            CheckSolved();
        }

        private void Button3_Click(object sender, EventArgs e)
        {

            CheckButton(Button3, Button2);
            CheckButton(Button3, Button4);
            CheckButton(Button3, Button7);

            CheckSolved();
        }

        private void Button4_Click(object sender, EventArgs e)
        {

            CheckButton(Button4, Button3);
            CheckButton(Button4, Button8);

            CheckSolved();
        }

        private void Button5_Click(object sender, EventArgs e)
        {

            CheckButton(Button5, Button1);
            CheckButton(Button5, Button6);
            CheckButton(Button5, Button9);

            CheckSolved();
        }

        private void Button6_Click(object sender, EventArgs e)
        {

            CheckButton(Button6, Button2);
            CheckButton(Button6, Button5);
            CheckButton(Button6, Button7);
            CheckButton(Button6, Button10);

            CheckSolved();
        }

        private void Button7_Click(object sender, EventArgs e)
        {

            CheckButton(Button7, Button3);
            CheckButton(Button7, Button6);
            CheckButton(Button7, Button8);
            CheckButton(Button7, Button11);

            CheckSolved();
        }

        private void Button8_Click(object sender, EventArgs e)
        {

            CheckButton(Button8, Button4);
            CheckButton(Button8, Button7);
            CheckButton(Button8, Button12);

            CheckSolved();
        }

        private void Button10_Click(object sender, EventArgs e)
        {

            CheckButton(Button10, Button6);
            CheckButton(Button10, Button9);
            CheckButton(Button10, Button11);
            CheckButton(Button10, Button14);

            CheckSolved();
        }

        private void Button11_Click(object sender, EventArgs e)
        {

            CheckButton(Button11, Button7);
            CheckButton(Button11, Button10);
            CheckButton(Button11, Button12);
            CheckButton(Button11, Button15);

            CheckSolved();
        }

        private void Button12_Click(object sender, EventArgs e)
        {

            CheckButton(Button12, Button8);
            CheckButton(Button12, Button11);
            CheckButton(Button12, Button16);

            CheckSolved();
        }

        private void Button13_Click(object sender, EventArgs e)
        {

            CheckButton(Button13, Button9);
            CheckButton(Button13, Button14);

            CheckSolved();
        }

        private void Button14_Click(object sender, EventArgs e)
        {

            CheckButton(Button14, Button10);
            CheckButton(Button14, Button13);
            CheckButton(Button14, Button15);

            CheckSolved();
        }

        private void Button15_Click(object sender, EventArgs e)
        {

            CheckButton(Button15, Button11);
            CheckButton(Button15, Button14);
            CheckButton(Button15, Button16);

            CheckSolved();
        }

        private void Button16_Click(object sender, EventArgs e)
        {

            CheckButton(Button16, Button12);
            CheckButton(Button16, Button15);

            CheckSolved();
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            shuffle();
        }

        private void ToolStripButton2_Click(object sender, EventArgs e)
        {
            
            Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            shuffle();
        }
    }

}
