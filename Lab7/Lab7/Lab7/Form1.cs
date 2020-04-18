/*
Grading ID: W9957
Lab#: 7
Due Date: 4/1/2018 11:59.00
Course Section: 199-01

Description:
Application that applies the Net Present Value formula from Finance to calculate how much money you need to invest today to earn a certain amount in the future. 

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

namespace Lab7
{
    public partial class FormmMain : Form
    {
        public FormmMain() //initializes form
        {
            InitializeComponent();
        }

        private void buttCalc_Click(object sender, EventArgs e) //on button click
        {
            double futureValue, annualRate; // the variables for F, r (used in NetPresentValue)
            int years;                      // variable for n (used in NetPresentValue)

            if (!double.TryParse(tBoxFutureValue.Text, out futureValue) || futureValue < 0) { MessageBox.Show("Invalid Future Value"); } //error message if can't parse or less than 0
            else if (!double.TryParse(tBoxAnnualRate.Text, out annualRate) || annualRate < 0) { MessageBox.Show("Invalid Annual Interest Rate"); } //error message if can't parse or less than 0
            else if (!int.TryParse(tBoxNoYears.Text, out years) || years < 0) { MessageBox.Show("Invalid Number of Year(s)"); } //error message if can't parse or less than 0
            else
            {
                displayPresentValue.Text = ($"{NetPresentValue(futureValue, annualRate, years):C}"); //uses the NetPresentValue method to display dollar amount (converts to string)
            }
        }

        public static double NetPresentValue(double futureValue, double annualRate, int years) //Pre-Condition: all values should match value types requested (double, double, int)
        {
            double presentValue = (futureValue) / (Math.Pow((1 + annualRate), years)); //applies the Net Present Value formula from Finance to calculate how much money you need to invest today to earn a certain amount in the future

            return presentValue; //Post-Condition: returns double
        }
    }
}
