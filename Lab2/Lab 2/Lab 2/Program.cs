/*
Grading ID: W9957
Lab#: 2
Due Date: 2/4/2018 11:59.00
Course Section: 199-01

Description:
A application that displays a form that allows for the user 
to calculate verious provided tip amounts. 

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

        }
    }
}
