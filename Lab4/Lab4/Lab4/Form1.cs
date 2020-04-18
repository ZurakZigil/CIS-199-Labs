/*
Grading ID: W9957
Lab#: 4
Due Date: 2/18/2018 11:59.00
Course Section: 199-01

Description:
A form that allows the user to submit a test score and a GPA and then goes through boolean tests to figure out whether that 
student passed. It also counts the number of submitted "accepts" and "rejects."

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

namespace Lab4
{
    public partial class Form1 : Form
    {
        //put variables here so they do not get reset (specifically with numRejects and numAccepts) 
        int numRejects = 0;                 //used for the reject counter 
        int numAccepts = 0;                 //used for the reject counter 
        float GPA;                          //float representing the GPA entered into the text box
        uint testScore;                     //uint (non-negative int) representing the the students test score entered into the text box
        const double boolTestGPA = 3.0;     //constant for the GPA test
        const uint boolTScoreLow = 60;      //constant for the test score for 60%
        const uint boolTScoreHigh = 80;     //constant for the test score for 80%

        public Form1()//start the form
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)//accident
        {

        }

        private void buttTest_Click(object sender, EventArgs e)
        {
            float.TryParse(textBoxGPA.Text, out GPA);           //sets GPA by reading the 1st text box
            uint.TryParse(textBoxTScore.Text, out testScore);   //sets test score by reading the 2nd text box

            if ((GPA<= boolTestGPA && testScore>=boolTScoreHigh) || (GPA >= boolTestGPA && testScore >= boolTScoreLow))//if statement testing testing with the criteria of passing
            {
                displayResults.Text = ("Accept");//display accept
                numAccepts++;//adds to counter
                displayCounterAccepts.Text = Convert.ToString(numAccepts);//display counter
            }
            //then failing in an else
            else
            {
                displayResults.Text = ("Rejects");//display reject
                numRejects++;//adds to counter
                displayCounterRejects.Text = Convert.ToString(numRejects);//display counter
            }
        }
    }
}
