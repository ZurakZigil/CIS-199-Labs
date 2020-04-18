/*
Grading ID: W9957
Lab#: 1
Due Date: 1/28/2018 11:59.00
Course Section: 199-01

Description:
Allows 2 user inputed variables to be floats, 
that are then processsed through several calcualtions (+,-,*,/,mean) 
and displayed to the user with 3 points of accuracy. 
I have added the ability to loop.

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            float num1;//the first user submitted number(float)
            float num2;//the second user submitted number(float)
            bool x = true;//I wanted the program to loop (I don't like when calculators just kick you out).

            while (x==true) {
                Console.Write("What numbers would you like to calculate?");
                Console.Write("\nFirst Variable:");
                num1 = float.Parse(Console.ReadLine());//declares first float
                Console.Write("Second Variable:");
                num2 = float.Parse(Console.ReadLine());//declares second float

                //Console.WriteLine($"{num1:F3}");--test
                //Console.WriteLine(num2);--test

                //Calculations 
                Console.WriteLine($"\nSum:           {num1:F3} + {num2:F3} = {num1 + num2:F3}");
                Console.WriteLine($"Difference:    {num1:F3} - {num2:F3} = {num1 - num2:F3}");
                Console.WriteLine($"Product:       {num1:F3} * {num2:F3} = {num1 * num2:F3}");
                Console.WriteLine($"Quotient:      {num1:F3} / {num2:F3} = {num1 / num2:F3}");
                Console.WriteLine($"Mean:          {num1:F3} & {num2:F3} = {(num1 + num2) / 2:F3}\n");


            }
        }
    }
}

