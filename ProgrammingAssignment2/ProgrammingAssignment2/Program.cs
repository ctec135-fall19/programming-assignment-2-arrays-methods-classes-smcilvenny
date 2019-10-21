using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingAssignment2
{
    class Program
    {
        static void Main(string[] args)
        {

            //Array problem 1

            string[] numbers;
            numbers = new string[] { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten" };

            foreach (string number in numbers)
            {
                Console.WriteLine(number);
            }

            //Array problem 2

            int[] integers;
            integers = new int[10];
            int i;
            for (i = 0; i < integers.Length; i++)
            {
                integers[i] = (i * 10);
                Console.WriteLine(integers[i]);
            }

            //Array problem 3 - multiplication table
            int myInt = 12;

            int[,] multiplicationTable = new int[myInt, myInt];

            for (int j = 1; j <= myInt; j++)
            {
                for (int k = 1; k <= myInt; k++)
                {
                    Console.Write(j * k + "-----");
                }
                Console.WriteLine();
            }




        }
    }
}
