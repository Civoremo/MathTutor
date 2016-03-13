using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace MathTutor
{
    public partial class mainWin : Form
    {
        public static bool level1 = true;

        public mainWin()
        {
            InitializeComponent();
            
        }

        private void mainWin_Load(object sender, EventArgs e)
        {

        }

        private void num1_Click(object sender, EventArgs e)
        {
            answerBox.Text = (answerBox.Text + "1");
        }

        private void num2_Click(object sender, EventArgs e)
        {
            answerBox.Text = (answerBox.Text + "2");
        }

        private void num3_Click(object sender, EventArgs e)
        {
            answerBox.Text = (answerBox.Text + "3");
        }

        private void num4_Click(object sender, EventArgs e)
        {
            answerBox.Text = (answerBox.Text + "4");
        }

        private void num5_Click(object sender, EventArgs e)
        {
            answerBox.Text = (answerBox.Text + "5");
        }

        private void num6_Click(object sender, EventArgs e)
        {
            answerBox.Text = (answerBox.Text + "6");
        }

        private void num7_Click(object sender, EventArgs e)
        {
            answerBox.Text = (answerBox.Text + "7");
        }

        private void num8_Click(object sender, EventArgs e)
        {
            answerBox.Text = (answerBox.Text + "8");
        }

        private void num9_Click(object sender, EventArgs e)
        {
            answerBox.Text = (answerBox.Text + "9");
        }

        private void num0_Click(object sender, EventArgs e)
        {
            answerBox.Text = (answerBox.Text + "0");
        }

        private void numClear_Click(object sender, EventArgs e)
        {
            answerBox.Text = ("");
        }

        private void answerBt_Click(object sender, EventArgs e)
        {
            int additionAnswer;
            int a, b, c;
            int correctNum, wrongNum;

            int ranMax, ranMin;
            
            if (assign.Text == "A1")
            {
                ranMax = 5;
                ranMin = 0;
            }
            else if (assign.Text == "A2")
            {
                ranMax = 10;
                ranMin = 5;
            }
            else if (assign.Text == "A3")
            {
                ranMax = 20;
                ranMin = 10;
            }
            else if (assign.Text == "A4")
            {
                ranMax = 50;
                ranMin = 10;
            }
            else if (assign.Text == "A5")
            {
                ranMax = 100;
                ranMin = 50;
            }
            else
            {
                ranMax = 500;
                ranMin = 100;
            }


            if (answerBox.Text != "")
            {
                a = Convert.ToUInt16(questOne.Text);
                b = Convert.ToUInt16(questTwo.Text);
                c = Convert.ToUInt16(answerBox.Text);

                correctNum = Convert.ToUInt16(correctBt.Text);
                wrongNum = Convert.ToUInt16(wrongBt.Text);

                additionAnswer = a + b;

                if(additionAnswer == c)
                {
                    Random startNum = new Random();

                    int firstNum = startNum.Next(ranMin, ranMax);
                    int secondNum = startNum.Next(ranMin, ranMax);

                    questOne.Text = (firstNum + "");
                    questTwo.Text = (secondNum + "");

                    answerBox.Text = ("");
                    msgBt.Text = "";

                    correctNum += 1;
                    correctBt.Text = Convert.ToString(correctNum);
                    SystemSounds.Asterisk.Play();
                }
                else if (additionAnswer != c)
                {
                    wrongAswBox.Text = (questOne.Text + " + " + questTwo.Text + " = " + additionAnswer);

                    Random startNum = new Random();

                    int firstNum = startNum.Next(ranMin, ranMax);
                    int secondNum = startNum.Next(ranMin, ranMax);

                    questOne.Text = (firstNum + "");
                    questTwo.Text = (secondNum + "");

                    answerBox.Text = ("");

                    wrongNum += 1;
                    wrongBt.Text = Convert.ToString(wrongNum);
                    SystemSounds.Hand.Play();

                    /*answerBox.Text = ("");
                    msgBt.Text = "Try Again!";
                    wrongNum += 1;
                    wrongBt.Text = Convert.ToString(wrongNum);
                    SystemSounds.Hand.Play();
                     */
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void level1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            assign.Text = "A1";
            correctBt.Text = "0";
            wrongBt.Text = "0";

            wrongAswBox.Visible = false;

            Random startNum = new Random();

            int firstNum = startNum.Next(0, 5);
            int secondNum = startNum.Next(0, 5);

            questOne.Text = (firstNum + "");
            questTwo.Text = (secondNum + "");
        }

        public void level2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            assign.Text = "A2";
            correctBt.Text = "0";
            wrongBt.Text = "0";

            wrongAswBox.Visible = false;

            Random startNum = new Random();

            int firstNum = startNum.Next(5, 10);
            int secondNum = startNum.Next(5, 10);

            questOne.Text = (firstNum + "");
            questTwo.Text = (secondNum + "");
        }

        private void level3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            assign.Text = "A3";
            correctBt.Text = "0";
            wrongBt.Text = "0";

            wrongAswBox.Visible = false;

            Random startNum = new Random();

            int firstNum = startNum.Next(10, 20);
            int secondNum = startNum.Next(10, 20);

            questOne.Text = (firstNum + "");
            questTwo.Text = (secondNum + "");
        }

        private void level4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            assign.Text = "A4";
            correctBt.Text = "0";
            wrongBt.Text = "0";

            wrongAswBox.Visible = false;

            Random startNum = new Random();

            int firstNum = startNum.Next(10, 50);
            int secondNum = startNum.Next(10, 50);

            questOne.Text = (firstNum + "");
            questTwo.Text = (secondNum + "");
        }

        private void level5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            assign.Text = "A5";
            correctBt.Text = "0";
            wrongBt.Text = "0";

            wrongAswBox.Visible = false;

            Random startNum = new Random();

            int firstNum = startNum.Next(100, 500);
            int secondNum = startNum.Next(100, 500);

            questOne.Text = (firstNum + "");
            questTwo.Text = (secondNum + "");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                checkBox1.Text = "Disable Answers";
                wrongAswBox.Visible = true;
            }
            if (checkBox1.Checked == false)
            {
                checkBox1.Text = "Enable Answers";
                wrongAswBox.Visible = false;
            }
            
        }
    }
}
