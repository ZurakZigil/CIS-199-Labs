/*
Grading ID: W9957
Lab#: 5
Due Date: 2/11/2018 11:59.00
Course Section: 199-01

Description:
This just creates some predefined star formations.

*/

using System;

namespace Lab_5
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MAX_ROWS = 10; // constant set to create a max size for the row
            const int MIN_ROWS = 1; // constant set to create a min size for the row

            //Pattern A -------------------------------------------------------------------
            Console.WriteLine("Pattern A \n");
            for (int row=MIN_ROWS;row<=MAX_ROWS; row++)
            {
                for (int star = MIN_ROWS; star <= row; star++) // adds stars by counting up
                    Console.Write("*");
                Console.WriteLine();
            }
            Console.WriteLine();


            //Pattern B -------------------------------------------------------------------
            Console.WriteLine("Pattern B \n");
            for (int row = MIN_ROWS; row <= MAX_ROWS; row++)
            {
                for (int star = MAX_ROWS; star >= row; star--) //adds stars by counting down
                    Console.Write("*");
                Console.WriteLine();
            }
            Console.WriteLine();


            //Pattern C -------------------------------------------------------------------
            Console.WriteLine("Pattern C \n");
            for (int row = MIN_ROWS; row <= MAX_ROWS; row++)
            {
                for (int space = MIN_ROWS; space < row; space++)//adds spaces by counting up
                    Console.Write(" ");
                for (int star = MAX_ROWS; star >= row; star--)//adds stars by counting down
                    Console.Write("*");
                Console.WriteLine();
            }
            Console.WriteLine();


            //Pattern D -------------------------------------------------------------------
            Console.WriteLine("Pattern D \n");
            for (int row = MIN_ROWS; row <= MAX_ROWS; row++)
            {
                for (int space = MAX_ROWS; space > row; space--)//adds spaces by counting down 
                    Console.Write(" ");
                for (int star = MIN_ROWS; star <= row; star++)//adds stars by counting up
                    Console.Write("*");
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
