/*
Grading ID: W9957
Lab#: 2
Due Date: 2/04/2018 11:59.00
Course Section: 199-01

Description:
A form that calculates several tips (15%, 18%, 20%, 22%, and one user defined) for a user defined dollar amount. 
It is activated by hitting the "Calculate Tip" button at the bottom.

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

namespace Lab_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Custom Tip restrictions (WAS NOT REQUIRED...nor was the custom tip) - P.S. withen the [Design] of the form I restricted it to 2 characters
        private void labelTip5_KeyPress(object sender, KeyPressEventArgs e) //This block from line 20-27 is to restrict input for the custom tip box. I was just fiddling with it (NONE OF THIS WAS REQUIRED). 
        {
            if (!char.IsNumber(e.KeyChar))  //borrowed code, but it asks whether the character being typed is a number
            {
                e.Handled = true;           //if it is, then it can be typed
            }

        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            double subTotal;        //the price of the "food" that you want to calculate the tip for
            double tip1, tip1P;     // 15% tip, tip1P used when converting to a % for calculating
            double tip2, tip2P;     // 18% tip, tip2P used when converting to a % ""
            double tip3, tip3P;     // 20% tip, tip3P used when converting to a % ""
            double tip4, tip4P;     // 22% tip, tip4P used when converting to a % ""
            double tip5, tip5P;     // CUSTOM tip, CUSTOM tip percentage 
            string tip5_STRING;     // a string that is converted for the CUSTOM tip (an attempt at restricting input)


            //converts all the Labels and Text Box (for custom tip) to usable numbers
            //just found step 5 with form load silly because why not just hard code it in with =.15 or something. 
            //Found this to be cleaner, and you can edit it straight from the [Design] window (try it)
            subTotal = double.Parse(priceInput.Text);
            tip1P = double.Parse(labelTip1.Text);
            tip2P = double.Parse(labelTip2.Text);
            tip3P = double.Parse(labelTip3.Text);
            tip4P = double.Parse(labelTip4.Text);

            tip5_STRING = Convert.ToString($".{labelTip5.Text}");//conversion garuntees there was a decimal
            tip5P = double.Parse(tip5_STRING);  //same conversion used on tips 1-4


            //calculation of subtotal * tip % that were converted above (41-48)
            tip1 = subTotal * tip1P;
            tip2 = subTotal * tip2P;
            tip3 = subTotal * tip3P;
            tip4 = subTotal * tip4P;
            tip5 = subTotal * tip5P;


            //displaying the dollar amounts in the labels
            displayTip1.Text = $"{tip1:C}";
            displayTip2.Text = $"{tip2:C}";
            displayTip3.Text = $"{tip3:C}";
            displayTip4.Text = $"{tip4:C}";
            displayTip5.Text = $"{tip5:C}";
        }

        private void priceInput_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void labelTip5_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
