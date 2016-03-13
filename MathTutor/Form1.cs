using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.IO;

namespace MathTutor
{
    public partial class mainWin : Form
    {
        public static bool level1 = true;
        public static bool bAdd = false;
        public static bool bSub = false;
        public static bool bMult = false;
        public static bool bDiv = false;

        public int ranMax, ranMin, ranMid;
        

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
            if (bAdd == true && bSub == false && bMult == false && bDiv == false)
            {
                AdditionSolver();
            }
            if (bAdd == false && bSub == true && bMult == false && bDiv == false)
            {
                SubtractionSolver();
            }
            if (bAdd == false && bSub == false && bMult == true && bDiv == false)
            {
                MultiplicationSolver();
            }
            if (bAdd == false && bSub == false && bMult == false && bDiv == true)
            {
                DivisionSolver();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #region Addition menu
        private void level1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bAdd = true;
            bSub = false;
            bMult = false;
            bDiv = false;

            assign.Text = "A1";
            correctBt.Text = "0";
            wrongBt.Text = "0";
            label1.Text = "+";

            wrongAswBox.Visible = false;

            Random startNum = new Random();

            int firstNum = startNum.Next(0, 5);
            int secondNum = startNum.Next(0, 5);

            questOne.Text = (firstNum + "");
            questTwo.Text = (secondNum + "");
        }

        public void level2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bAdd = true;
            bSub = false;
            bMult = false;
            bDiv = false;
            assign.Text = "A2";
            correctBt.Text = "0";
            wrongBt.Text = "0";
            label1.Text = "+";

            wrongAswBox.Visible = false;

            Random startNum = new Random();

            int firstNum = startNum.Next(5, 10);
            int secondNum = startNum.Next(5, 10);

            questOne.Text = (firstNum + "");
            questTwo.Text = (secondNum + "");
        }

        private void level3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bAdd = true;
            bSub = false;
            bMult = false;
            bDiv = false;
            assign.Text = "A3";
            correctBt.Text = "0";
            wrongBt.Text = "0";
            label1.Text = "+";

            wrongAswBox.Visible = false;

            Random startNum = new Random();

            int firstNum = startNum.Next(10, 20);
            int secondNum = startNum.Next(10, 20);

            questOne.Text = (firstNum + "");
            questTwo.Text = (secondNum + "");
        }

        private void level4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bAdd = true;
            bSub = false;
            bMult = false;
            bDiv = false;
            assign.Text = "A4";
            correctBt.Text = "0";
            wrongBt.Text = "0";
            label1.Text = "+";

            wrongAswBox.Visible = false;

            Random startNum = new Random();

            int firstNum = startNum.Next(10, 50);
            int secondNum = startNum.Next(10, 50);

            questOne.Text = (firstNum + "");
            questTwo.Text = (secondNum + "");
        }

        private void level5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bAdd = true;
            bSub = false;
            bMult = false;
            bDiv = false;
            assign.Text = "A5";
            correctBt.Text = "0";
            wrongBt.Text = "0";

            label1.Text = "+";

            wrongAswBox.Visible = false;

            Random startNum = new Random();

            int firstNum = startNum.Next(100, 500);
            int secondNum = startNum.Next(100, 500);

            questOne.Text = (firstNum + "");
            questTwo.Text = (secondNum + "");
        }
        #endregion

        #region Subtraction Menu
        private void level1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int tempNum;
            bAdd = false;
            bSub = true;
            bMult = false;
            bDiv = false;

            label1.Text = "-";
            assign.Text = "S1";
            correctBt.Text = "0";
            wrongBt.Text = "0";

            Random startNum = new Random();

            int firstNum = startNum.Next(0, 10);
            int secondNum = startNum.Next(0, 10);

            if (firstNum >= secondNum)
            {
                questOne.Text = (firstNum + "");
                questTwo.Text = (secondNum + "");
            }
            else if (secondNum > firstNum)
            {
                tempNum = secondNum;
                secondNum = firstNum;
                firstNum = tempNum;

                questOne.Text = (firstNum + "");
                questTwo.Text = (secondNum + "");
            }

        }

        private void level2ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int tempNum;
            bAdd = false;
            bSub = true;
            bMult = false;
            bDiv = false;

            label1.Text = "-";
            assign.Text = "S2";
            correctBt.Text = "0";
            wrongBt.Text = "0";

            Random startNum = new Random();

            int firstNum = startNum.Next(0, 20);
            int secondNum = startNum.Next(1, 10);

            if (firstNum >= secondNum)
            {
                questOne.Text = (firstNum + "");
                questTwo.Text = (secondNum + "");
            }
            else if (secondNum > firstNum)
            {
                tempNum = secondNum;
                secondNum = firstNum;
                firstNum = tempNum;

                questOne.Text = (firstNum + "");
                questTwo.Text = (secondNum + "");
            }
        }

        private void level3ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int tempNum;
            bAdd = false;
            bSub = true;
            bMult = false;
            bDiv = false;

            label1.Text = "-";
            assign.Text = "S3";
            correctBt.Text = "0";
            wrongBt.Text = "0";

            Random startNum = new Random();

            int firstNum = startNum.Next(0, 40);
            int secondNum = startNum.Next(2, 15);

            if (firstNum >= secondNum)
            {
                questOne.Text = (firstNum + "");
                questTwo.Text = (secondNum + "");
            }
            else if (secondNum > firstNum)
            {
                tempNum = secondNum;
                secondNum = firstNum;
                firstNum = tempNum;

                questOne.Text = (firstNum + "");
                questTwo.Text = (secondNum + "");
            }
        }

        private void level4ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int tempNum;
            bAdd = false;
            bSub = true;
            bMult = false;
            bDiv = false;

            label1.Text = "-";
            assign.Text = "S4";
            correctBt.Text = "0";
            wrongBt.Text = "0";

            Random startNum = new Random();

            int firstNum = startNum.Next(0, 100);
            int secondNum = startNum.Next(2, 25);

            if (firstNum >= secondNum)
            {
                questOne.Text = (firstNum + "");
                questTwo.Text = (secondNum + "");
            }
            else if (secondNum > firstNum)
            {
                tempNum = secondNum;
                secondNum = firstNum;
                firstNum = tempNum;

                questOne.Text = (firstNum + "");
                questTwo.Text = (secondNum + "");
            }
        }
        #endregion
                
        #region Multiplication Menu
        private void level1ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            bAdd = false;
            bSub = false;
            bMult = true;
            bDiv = false;

            label1.Text = "*";
            assign.Text = "M1";
            correctBt.Text = "0";
            wrongBt.Text = "0";

            Random startNum = new Random();

            int firstNum = startNum.Next(0, 5);
            int secondNum = startNum.Next(0, 5);

            questOne.Text = (firstNum + "");
            questTwo.Text = (secondNum + "");
        }

        private void level2ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            bAdd = false;
            bSub = false;
            bMult = true;
            bDiv = false;

            label1.Text = "*";
            assign.Text = "M2";
            correctBt.Text = "0";
            wrongBt.Text = "0";

            Random startNum = new Random();

            int firstNum = startNum.Next(0, 10);
            int secondNum = startNum.Next(0, 5);

            questOne.Text = (firstNum + "");
            questTwo.Text = (secondNum + "");
        }

        private void level3ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            bAdd = false;
            bSub = false;
            bMult = true;
            bDiv = false;

            label1.Text = "*";
            assign.Text = "M3";
            correctBt.Text = "0";
            wrongBt.Text = "0";

            Random startNum = new Random();

            int firstNum = startNum.Next(0, 10);
            int secondNum = startNum.Next(0, 10);

            questOne.Text = (firstNum + "");
            questTwo.Text = (secondNum + "");
        }

        private void level4ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            bAdd = false;
            bSub = false;
            bMult = true;
            bDiv = false;

            label1.Text = "*";
            assign.Text = "M4";
            correctBt.Text = "0";
            wrongBt.Text = "0";

            Random startNum = new Random();

            int firstNum = startNum.Next(0, 15);
            int secondNum = startNum.Next(0, 10);

            questOne.Text = (firstNum + "");
            questTwo.Text = (secondNum + "");
        }
        #endregion

        #region Division Menu
        private void level1ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            bAdd = false;
            bSub = false;
            bMult = false;
            bDiv = true;

            label1.Text = " /";
            assign.Text = "D1";
            correctBt.Text = "0";
            wrongBt.Text = "0";

            Random startNum = new Random();

            int firstNum = startNum.Next(1, 5);
            int secondNum = startNum.Next(1, 5);

            int tempDivision = firstNum * secondNum;

            questOne.Text = (tempDivision + "");
            questTwo.Text = (secondNum + "");
        }

        private void level2ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            bAdd = false;
            bSub = false;
            bMult = false;
            bDiv = true;

            label1.Text = " /";
            assign.Text = "D2";
            correctBt.Text = "0";
            wrongBt.Text = "0";

            Random startNum = new Random();

            int firstNum = startNum.Next(1, 10);
            int secondNum = startNum.Next(1, 10);

            int tempDivision = firstNum * secondNum;

            questOne.Text = (tempDivision + "");
            questTwo.Text = (secondNum + "");
        }

        private void level3ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            bAdd = false;
            bSub = false;
            bMult = false;
            bDiv = true;

            label1.Text = " /";
            assign.Text = "D3";
            correctBt.Text = "0";
            wrongBt.Text = "0";

            Random startNum = new Random();

            int firstNum = startNum.Next(1, 15);
            int secondNum = startNum.Next(1, 5);

            int tempDivision = firstNum * secondNum;

            questOne.Text = (tempDivision + "");
            questTwo.Text = (secondNum + "");
        }

        private void level4ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            bAdd = false;
            bSub = false;
            bMult = false;
            bDiv = true;

            label1.Text = " /";
            assign.Text = "D4";
            correctBt.Text = "0";
            wrongBt.Text = "0";

            Random startNum = new Random();

            int firstNum = startNum.Next(1, 20);
            int secondNum = startNum.Next(1, 10);

            int tempDivision = firstNum * secondNum;

            questOne.Text = (tempDivision + "");
            questTwo.Text = (secondNum + "");
        }
        #endregion

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

        public void AdditionSolver()
        {
            int additionAnswer;
            int a, b, c;
            int correctNum, wrongNum;

            int ranMax, ranMin;

            #region Level Assign

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

            #endregion

            if (answerBox.Text != "")
            {
                a = Convert.ToUInt16(questOne.Text);
                b = Convert.ToUInt16(questTwo.Text);
                c = Convert.ToUInt16(answerBox.Text);

                correctNum = Convert.ToUInt16(correctBt.Text);
                wrongNum = Convert.ToUInt16(wrongBt.Text);


                #region Addition Solver

                additionAnswer = a + b;

                if (additionAnswer == c)
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
                #endregion
            }
        }

        public void SubtractionSolver()
        {
            int subtractionAnswer;
            int a, b, c;
            int correctNum, wrongNum, tempNum;

            #region Sub Levels

            if (assign.Text == "S1")
            {
                ranMax = 10;
                ranMid = 0;
                ranMin = 0;
            }
            else if (assign.Text == "S2")
            {
                ranMax = 20;
                ranMid = 10;
                ranMin = 1;
            }
            else if (assign.Text == "S3")
            {
                ranMax = 40;
                ranMid = 15;
                ranMin = 2;
            }
            else if (assign.Text == "S4")
            {
                ranMax = 100;
                ranMid = 25;
                ranMin = 2;
            }
            #endregion

            if (answerBox.Text != "")
            {
                a = Convert.ToUInt16(questOne.Text);
                b = Convert.ToUInt16(questTwo.Text);
                c = Convert.ToUInt16(answerBox.Text);

                correctNum = Convert.ToUInt16(correctBt.Text);
                wrongNum = Convert.ToUInt16(wrongBt.Text);

                #region Subtraction Solver

                subtractionAnswer = a - b;

                if (assign.Text == "S1")
                {
                    if (subtractionAnswer == c)
                    {

                        Random startNum = new Random();

                        int firstNum = startNum.Next(ranMin, ranMax);
                        int secondNum = startNum.Next(ranMin, ranMax);

                        if (firstNum >= secondNum)
                        {
                            questOne.Text = (firstNum + "");
                            questTwo.Text = (secondNum + "");
                        }
                        else if (secondNum > firstNum)
                        {
                            tempNum = secondNum;
                            secondNum = firstNum;
                            firstNum = tempNum;

                            questOne.Text = (firstNum + "");
                            questTwo.Text = (secondNum + "");
                        }

                        answerBox.Text = ("");
                        msgBt.Text = "";

                        correctNum += 1;
                        correctBt.Text = Convert.ToString(correctNum);
                        SystemSounds.Asterisk.Play();
                    }
                    else if (subtractionAnswer != c)
                    {
                        wrongAswBox.Text = (questOne.Text + " - " + questTwo.Text + " = " + subtractionAnswer);

                        Random startNum = new Random();

                        int firstNum = startNum.Next(ranMin, ranMax);
                        int secondNum = startNum.Next(ranMin, ranMax);

                        if (firstNum >= secondNum)
                        {
                            questOne.Text = (firstNum + "");
                            questTwo.Text = (secondNum + "");
                        }
                        else if (secondNum > firstNum)
                        {
                            tempNum = secondNum;
                            secondNum = firstNum;
                            firstNum = tempNum;

                            questOne.Text = (firstNum + "");
                            questTwo.Text = (secondNum + "");
                        }

                        answerBox.Text = ("");

                        wrongNum += 1;
                        wrongBt.Text = Convert.ToString(wrongNum);
                        SystemSounds.Hand.Play();
                    }
                }
                else   // if it is not the first level for subtraction
                {
                    if (subtractionAnswer == c)
                    {
                        Random startNum = new Random();

                        int firstNum = startNum.Next(ranMin, ranMax);
                        int secondNum = startNum.Next(ranMin, ranMid);

                        if (firstNum >= secondNum)
                        {
                            questOne.Text = (firstNum + "");
                            questTwo.Text = (secondNum + "");
                        }
                        else if (secondNum > firstNum)
                        {
                            tempNum = secondNum;
                            secondNum = firstNum;
                            firstNum = tempNum;

                            questOne.Text = (firstNum + "");
                            questTwo.Text = (secondNum + "");
                        }

                        answerBox.Text = ("");
                        msgBt.Text = "";

                        correctNum += 1;
                        correctBt.Text = Convert.ToString(correctNum);
                        SystemSounds.Asterisk.Play();
                    }
                    else if (subtractionAnswer != c)
                    {
                        wrongAswBox.Text = (questOne.Text + " - " + questTwo.Text + " = " + subtractionAnswer);

                        Random startNum = new Random();

                        int firstNum = startNum.Next(ranMin, ranMax);
                        int secondNum = startNum.Next(ranMin, ranMax);

                        if (firstNum >= secondNum)
                        {
                            questOne.Text = (firstNum + "");
                            questTwo.Text = (secondNum + "");
                        }
                        else if (secondNum > firstNum)
                        {
                            tempNum = secondNum;
                            secondNum = firstNum;
                            firstNum = tempNum;

                            questOne.Text = (firstNum + "");
                            questTwo.Text = (secondNum + "");
                        }

                        answerBox.Text = ("");

                        wrongNum += 1;
                        wrongBt.Text = Convert.ToString(wrongNum);
                        SystemSounds.Hand.Play();
                    }
                }

                #endregion
            }
        }

        public void MultiplicationSolver()
        {
            int multiplicationAnswer;
            int a, b, c;
            int correctNum, wrongNum;

            #region Multi Levels
            if (assign.Text == "M1")
            {
                ranMax = 5;
                ranMid = 0;
                ranMin = 0;
            }
            if (assign.Text == "M2")
            {
                ranMax = 10;
                ranMid = 10;
                ranMin = 0;
            }
            if (assign.Text == "M3")
            {
                ranMax = 15;
                ranMid = 5;
                ranMin = 0;
            }
            if (assign.Text == "M4")
            {
                ranMax = 20;
                ranMid = 10;
                ranMin = 0;
            }

            #endregion

            if (answerBox.Text != "")
            {
                a = Convert.ToUInt16(questOne.Text);
                b = Convert.ToUInt16(questTwo.Text);
                c = Convert.ToUInt16(answerBox.Text);

                correctNum = Convert.ToUInt16(correctBt.Text);
                wrongNum = Convert.ToUInt16(wrongBt.Text);

                #region Multiplication Solver
                multiplicationAnswer = (a * b);

                if (multiplicationAnswer == c)
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
                else if (multiplicationAnswer != c)
                {
                    wrongAswBox.Text = (questOne.Text + " * " + questTwo.Text + " = " + multiplicationAnswer);

                    Random startNum = new Random();

                    int firstNum = startNum.Next(ranMin, ranMax);
                    int secondNum = startNum.Next(ranMin, ranMax);

                    questOne.Text = (firstNum + "");
                    questTwo.Text = (secondNum + "");

                    answerBox.Text = ("");

                    wrongNum += 1;
                    wrongBt.Text = Convert.ToString(wrongNum);
                    SystemSounds.Hand.Play();
                }
                #endregion

            }

        }

        public void DivisionSolver()
        {
            int divisionAnswer;
            int a, b, c;
            int correctNum, wrongNum;

            #region Div Levels
            if (assign.Text == "D1")
            {
                ranMax = 5;
                ranMid = 5;
                ranMin = 1;
            }
            if (assign.Text == "D2")
            {
                ranMax = 10;
                ranMid = 10;
                ranMin = 1;
            }
            if (assign.Text == "D3")
            {
                ranMax = 15;
                ranMid = 5;
                ranMin = 1;
            }
            if (assign.Text == "D4")
            {
                ranMax = 20;
                ranMid = 10;
                ranMin = 1;
            }
            #endregion

            if (answerBox.Text != "")
            {
                a = Convert.ToUInt16(questOne.Text);
                b = Convert.ToUInt16(questTwo.Text);
                c = Convert.ToUInt16(answerBox.Text);

                correctNum = Convert.ToUInt16(correctBt.Text);
                wrongNum = Convert.ToUInt16(wrongBt.Text);

                #region Miltiplication Solver

                divisionAnswer = (a / b);

                if (divisionAnswer == c)
                {
                    Random startNum = new Random();

                    int firstNum = startNum.Next(ranMin, ranMax);
                    int secondNum = startNum.Next(ranMin, ranMid);

                    int tempDivision = firstNum * secondNum;

                    questOne.Text = (tempDivision + "");
                    questTwo.Text = (secondNum + "");

                    answerBox.Text = ("");
                    msgBt.Text = "";

                    correctNum += 1;
                    correctBt.Text = Convert.ToString(correctNum);
                    SystemSounds.Asterisk.Play();
                }
                else if (divisionAnswer != c)
                {
                    wrongAswBox.Text = (questOne.Text + " / " + questTwo.Text + " = " + divisionAnswer);

                    Random startNum = new Random();

                    int firstNum = startNum.Next(ranMin, ranMax);
                    int secondNum = startNum.Next(ranMin, ranMax);

                    int tempDivision = firstNum * secondNum;

                    questOne.Text = (tempDivision + "");
                    questTwo.Text = (secondNum + "");

                    answerBox.Text = ("");

                    wrongNum += 1;
                    wrongBt.Text = Convert.ToString(wrongNum);
                    SystemSounds.Hand.Play();
                }
                #endregion
            }
        }
        
    }
}
