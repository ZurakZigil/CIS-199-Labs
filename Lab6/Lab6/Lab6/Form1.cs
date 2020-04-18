/*
Grading ID: W9957
Lab#: 6
Due Date: 3/25/2018 11:59.00
Course Section: 199-01

Description:
Takes in a word per minute count submitted by the user and returns a grade. 

*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttCalc_Click(object sender, EventArgs e)//on button click
        {
            int[] wordsPerMinute = { 0, 15, 30, 50, 75 };   //array fpr the word per minute count seperators (minimums)
            string[] grade = { "F", "D", "C","B", "A" };    //the accompanying letter grades

            double usersGrade; //the label for the grade interpretted from the text box

            if ((!double.TryParse(tBoxWordsPerMinute.Text, out usersGrade)) || usersGrade <= 0)//determines whether we can parse the text box to a usable double
            {
                MessageBox.Show("The Words Per Minute You have submitted is not valid");
            }
            else
            {
                int i = ((wordsPerMinute.Length)-1); //sets i to 75
                if (usersGrade > wordsPerMinute[i]) //tests whther it is an a by being above 75
                {
                    displayGrade.Text = grade[4];
                } 
                else //else it is tested for the letter grades F-B
                {
                    while (usersGrade <= wordsPerMinute[i]) //checking if the user grade is less than or equal thr array's grading scale
                    {
                        displayGrade.Text = grade[i - 1]; i--;
                    }
                }
                
                }
            }
        }
    }
