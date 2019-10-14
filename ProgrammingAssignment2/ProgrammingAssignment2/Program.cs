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

            int[,] multiplicationTable = new int[12, 12];

            for (int j = 0; j <=12; j++)
            {
                for (int k = 0; k <=12; k++)
                {
                    multiplicationTable[j, k] = j * k;
                }
            }




        }
    }
}
