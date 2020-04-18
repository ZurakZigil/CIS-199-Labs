/*
Grading ID: W9957
Lab#: 3
Due Date: 2/11/2018 11:59.00
Course Section: 199-01

Description:
A form meant to calculate diamete, surface area, and volume of a user inputed radius. 
Displays to pictures along side the calculations.

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

namespace Lab_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttCalc_Click(object sender, EventArgs e)//when we press the calculate button
        {
            double radi;            //represent the value for the radius, taken from the text box
            double diam;            //represent the value for the radius, calculated 
            double surfaceA;        //represent the value for the surface area, calculated 
            double vol;             //represent the value for the volume, calculated 
            double pi = Math.PI;    //converts Math.PI to a shorter name for ease of use 

            //record the radius
            if (string.IsNullOrWhiteSpace(textBoxRad.Text)) //testing whether the user has inputed any data. was crashing 
            {
                radi = 0;
            }
            else
            {
                radi = double.Parse(textBoxRad.Text);
            }

            diam = 2*(radi);                            //calculates diameter
            surfaceA = 4 * pi * (radi * radi);          //calculates surface area
            vol = (4 * pi * (radi * radi * radi)) / 3;  //calculates volume

            displayDiam.Text = $"{diam:F2}";            //displays diameter
            displaySurfaceA.Text = $"{surfaceA:F2}";    //displays surface area
            displayVol.Text = $"{vol:F2}";              //displays volume
        }
    }
}
