using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob2Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Sean";
            int numb = 10;

            Console.WriteLine("Name before method call: {0}", name);
            Console.WriteLine("Number before method call: {0}", numb);
            Console.WriteLine();

            myMethod(numb, name);
            Console.ReadLine();

            Console.WriteLine("Name after method call: {0}", name);
            Console.WriteLine("Number after method call: {0}", numb);
            Console.WriteLine();

            myMethod(name);

            Console.WriteLine("Name after method call: {0}", name);
            Console.WriteLine("Number after method call: {0}", numb);
            Console.WriteLine();

        }

        static void myMethod(int arg1, string arg2)
        {
            arg1 = 100;
            arg2 = "Bob";
        }

        static void myMethod(string arg2)
        {
            arg2 = "jack";
        }

    }

}
