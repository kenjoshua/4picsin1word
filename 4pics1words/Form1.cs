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
    public partial class Form1 : Form
    {
        int x;
        int counter = 0;
        int scoreValue = 0;


        public Form1()
        {
            InitializeComponent();
        }

            
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = "A";

            Label[] txt = { label1,label2, label3 };
            txt[counter].Text = button1.Text;

            if (counter <= 3)
            {
                counter++;
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Text = "F";

            Label[] txt = { label1, label2, label3 };
            txt[counter].Text = button2.Text;
            if (counter <= 3)
            {
                counter++;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Text = "N";

            Label[] txt = { label1, label2, label3, };
            txt[counter].Text = button3.Text;

            if (counter <= 3)
            {
                counter++;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            changeImage(x);


        }

        private void changeImage(int num)
        {
          switch (num)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.fan1;
                    pictureBox2.Image = Properties.Resources.fan2;
                    pictureBox3.Image = Properties.Resources.fan3;
                    pictureBox4.Image = Properties.Resources.fan4;
                    break;

                case 2:
                    pictureBox1.Image = Properties.Resources.box1;
                    pictureBox2.Image = Properties.Resources.box2;
                    pictureBox3.Image = Properties.Resources.box3;
                    pictureBox4.Image = Properties.Resources.box4;
                    break;

                case 3:

                    pictureBox1.Image = Properties.Resources.hot1;
                    pictureBox2.Image = Properties.Resources.Hot2;
                    pictureBox3.Image = Properties.Resources.hot3;
                    pictureBox4.Image = Properties.Resources.hot4;

                    break;
                case 4:

                    pictureBox1.Image = Properties.Resources.ice1;
                    pictureBox2.Image = Properties.Resources.ice2;
                    pictureBox3.Image = Properties.Resources.ice3;
                    pictureBox4.Image = Properties.Resources.ice4;

                    break;
                case 5:

                    pictureBox1.Image = Properties.Resources.wet1;
                    pictureBox2.Image = Properties.Resources.wet2;
                    pictureBox3.Image = Properties.Resources.wet3;
                    pictureBox4.Image = Properties.Resources.wet4;

                    break;

                    
            }
        }

        private void Next_Click(object sender, EventArgs e)
        {
            x++;

            if (x > 5)
            {
                x = 1;
            }
            changeImage(x);

            label1.Text = "";
            label2.Text = "";
            label3.Text = "";

            

         

        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home1 = new Home();
            home1.ShowDialog();
            this.Close();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }


        private void label1_Click(object sender, EventArgs e)
        {
            Label[] text = { label1, label2, label3 };

        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            Label[] text = { label1, label2, label3 };
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Label[] text = { label1, label2, label3 };

           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";

            counter = 0;

        }

        private void button12_Click(object sender, EventArgs e)
        {
            button12.Text = "B";

            Label[] txt = { label1, label2, label3 };
            txt[counter].Text = button12.Text;

            if (counter <= 3)
            {
                counter++;
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Text = "X";

            Label[] txt = { label1, label2, label3 };
            txt[counter].Text = button5.Text;

            if (counter <= 3)
            {
                counter++;
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Text = "W";

            Label[] txt = { label1, label2, label3 };
            txt[counter].Text = button6.Text;

            if (counter <= 3)
            {
                counter++;
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Text = "E";

            Label[] txt = { label1, label2, label3 };
            txt[counter].Text = button7.Text;

            if (counter <= 3)
            {
                counter++;
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.Text = "H";

            Label[] txt = { label1, label2, label3 };
            txt[counter].Text = button8.Text;

            if (counter <= 3)
            {
                counter++;
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Text = "Z";

            Label[] txt = { label1, label2, label3 };
            txt[counter].Text = button9.Text;

            if (counter <= 3)
            {
                counter++;
            }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            button10.Text = "O";

            Label[] txt = { label1, label2, label3 };
            txt[counter].Text = button10.Text;

            if (counter <= 3)
            {
                counter++;
            }

        }

        private void button11_Click(object sender, EventArgs e)
        {
            button11.Text = "T";

            Label[] txt = { label1, label2, label3 };
            txt[counter].Text = button11.Text;

            if (counter <= 3)
            {
                counter++;
            }

        }

        private void button13_Click(object sender, EventArgs e)
        {
            button13.Text = "C";

            Label[] txt = { label1, label2, label3 };
            txt[counter].Text = button13.Text;

            if (counter <= 3)
            {
                counter++;
            }

        }

        private void button14_Click(object sender, EventArgs e)
        {
            button14.Text = "B";

            Label[] txt = { label1, label2, label3 };
            txt[counter].Text = button14.Text;

            if (counter <= 3)
            {
                counter++;
            }

        }

        private void button15_Click(object sender, EventArgs e)
        {
            button15.Text = "I";

            Label[] txt = { label1, label2, label3 };
            txt[counter].Text = button15.Text;

            if (counter <= 3)
            {
                counter++;
            }

        }

        private void Score_TextChanged(object sender, EventArgs e)
        {
            
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (label1.Text == "F" && label2.Text == "A" && label3.Text == "N")
            {
                MessageBox.Show("Correct");
                scoreValue++;

                x++;

                if (x > 5)
                {
                    x = 1;
                }
                changeImage(x);
                counter = 0;

                label1.Text = "";
                label2.Text = "";
                label3.Text = "";
            }
            else if (label1.Text == "B" && label2.Text == "O" && label3.Text == "X")
            {
                MessageBox.Show("Correct");
                scoreValue++;

                x++;

                if (x > 5)
                {
                    x = 1;
                }
                changeImage(x);
                counter = 0;

                label1.Text = "";
                label2.Text = "";
                label3.Text = "";
            }
            else if (label1.Text == "I" && label2.Text == "C" && label3.Text == "E")
            {
                MessageBox.Show("Correct");
                scoreValue++;

                x++;

                if (x > 5)
                {
                    x = 1;
                }
                changeImage(x);
                counter = 0;

                label1.Text = "";
                label2.Text = "";
                label3.Text = "";
            }

            else if (label1.Text == "H" && label2.Text == "O" && label3.Text == "T")
            {
                MessageBox.Show("Correct");
                scoreValue++;

                x++;

                if (x > 5)
                {
                    x = 1;
                }
                changeImage(x);
                counter = 0;

                label1.Text = "";
                label2.Text = "";
                label3.Text = "";
            }
            else
            {
                MessageBox.Show("Incorrect");
            }

            labelScore.Text = "Score: " + scoreValue;


        }

        private void labelScore_Click(object sender, EventArgs e)
        {
           
        }

        private void labelScore_Click_1(object sender, EventArgs e)
        {
            
        }
    }
}
