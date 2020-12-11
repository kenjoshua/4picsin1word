using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4pics1words
{
    public partial class Form3 : Form
    {

        int counter = 0;
        int scoreValue = 0;
        int x;

        public Form3()
        {
            InitializeComponent();
        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";

            counter = 0;

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            button1.Text = "B";

            Label[] txt = { label1, label2, label3, label4, label5 };
            txt[counter].Text = button1.Text;

            if (counter <= 5)
            {
                counter++;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            button2.Text = "D";

            Label[] txt = { label1, label2, label3, label4, label5 };
            txt[counter].Text = button2.Text;

            if (counter <= 5)
            {
                counter++;
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            button3.Text = "E";

            Label[] txt = { label1, label2, label3, label4, label5 };
            txt[counter].Text = button3.Text;

            if (counter <= 5)
            {
                counter++;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Text = "Z";

            Label[] txt = { label1, label2, label3, label4, label5 };
            txt[counter].Text = button4.Text;

            if (counter <= 5)
            {
                counter++;
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            button5.Text = "S";

            Label[] txt = { label1, label2, label3, label4, label5 };
            txt[counter].Text = button5.Text;

            if (counter <= 5)
            {
                counter++;
            }
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            button6.Text = "O";

            Label[] txt = { label1, label2, label3, label4, label5 };
            txt[counter].Text = button6.Text;

            if (counter <= 5)
            {
                counter++;
            }
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            button7.Text = "Y";

            Label[] txt = { label1, label2, label3, label4, label5 };
            txt[counter].Text = button7.Text;

            if (counter <= 5)
            {
                counter++;
            }
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            button8.Text = "R";

            Label[] txt = { label1, label2, label3, label4, label5 };
            txt[counter].Text = button8.Text;

            if (counter <= 5)
            {
                counter++;
            }
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            button9.Text = "U";

            Label[] txt = { label1, label2, label3, label4, label5 };
            txt[counter].Text = button9.Text;

            if (counter <= 5)
            {
                counter++;
            }
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            button10.Text = "C";

            Label[] txt = { label1, label2, label3, label4, label5 };
            txt[counter].Text = button10.Text;

            if (counter <= 5)
            {
                counter++;
            }
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            button11.Text = "W";

            Label[] txt = { label1, label2, label3, label4, label5 };
            txt[counter].Text = button11.Text;

            if (counter <= 5)
            {
                counter++;
            }
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            button12.Text = "L";

            Label[] txt = { label1, label2, label3, label4, label5 };
            txt[counter].Text = button12.Text;

            if (counter <= 5)
            {
                counter++;
            }
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            button13.Text = "A";

            Label[] txt = { label1, label2, label3, label4, label5 };
            txt[counter].Text = button13.Text;

            if (counter <= 5)
            {
                counter++;
            }
        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            button14.Text = "Q";

            Label[] txt = { label1, label2, label3, label4, label5 };
            txt[counter].Text = button14.Text;

            if (counter <= 5)
            {
                counter++;
            }
        }

        private void button15_Click_1(object sender, EventArgs e)
        {
            button15.Text = "D";

            Label[] txt = { label1, label2, label3, label4, label5 };
            txt[counter].Text = button15.Text;

            if (counter <= 5)
            {
                counter++;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            button16.Text = "K";

            Label[] txt = { label1, label2, label3, label4, label5 };
            txt[counter].Text = button16.Text;

            if (counter <= 5)
            {
                counter++;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (label1.Text == "C" && label2.Text == "R" && label3.Text == "A" && label4.Text == "Z" && label5.Text == "Y")
            {
                MessageBox.Show("Correct");
                scoreValue++;

                x++;

                if (x > 3)
                {
                    x = 1;
                }
                changeImage(x);
                counter = 0;

                label1.Text = "";
                label2.Text = "";
                label3.Text = "";
                label4.Text = "";
                label5.Text = "";
                
            }
            if (label1.Text == "B" && label2.Text == "O" && label3.Text == "R" && label4.Text == "E" && label5.Text == "D")
            {
                MessageBox.Show("Correct");
                scoreValue++;

                x++;

                if (x > 3)
                {
                    x = 1;
                }
                changeImage(x);
                counter = 0;

                label1.Text = "";
                label2.Text = "";
                label3.Text = "";
                label4.Text = "";
                label5.Text = "";

            }
            if (label1.Text == "B" && label2.Text == "L" && label3.Text == "O" && label4.Text == "C" && label5.Text == "K")
            {
                MessageBox.Show("Correct");
                scoreValue++;

                x++;

                if (x > 3)
                {
                    x = 1;
                }
                changeImage(x);
                counter = 0;

                label1.Text = "";
                label2.Text = "";
                label3.Text = "";
                label4.Text = "";
                label5.Text = "";

            }
            else
            {
                MessageBox.Show("Incorrect");
            }

            labelScore.Text = "Score: " + scoreValue;

        }

        private void changeImage(int num)
        {
            switch (num)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.block1;
                    pictureBox2.Image = Properties.Resources.block2;
                    pictureBox3.Image = Properties.Resources.block3;
                    pictureBox4.Image = Properties.Resources.block4;
                    break;

                case 2:
                    pictureBox1.Image = Properties.Resources.crazy1;
                    pictureBox2.Image = Properties.Resources.crazy2;
                    pictureBox3.Image = Properties.Resources.crazy3;
                    pictureBox4.Image = Properties.Resources.crazy4;
                    break;

                case 3:

                    pictureBox1.Image = Properties.Resources.bored1;
                    pictureBox2.Image = Properties.Resources.bored2;
                    pictureBox3.Image = Properties.Resources.bored3;
                    pictureBox4.Image = Properties.Resources.bored4;
                    break;
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home1 = new Home();
            home1.ShowDialog();
            this.Close();
        }
    }
}
