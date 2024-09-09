using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2A_2425_OOPCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Multiplication(21,13));
            //Console.WriteLine(Multiplication(16, 19));

            //Console.WriteLine(Division(17,26));
            //Console.WriteLine(Division(33, 11));
            //Console.WriteLine(Division(50, 5));


            int a = 19;
            int b = 5;

            Console.WriteLine($"The result of dividing {a} and {b} is {Division(a,b)}r{Modulo(a,b)}");


            Console.ReadKey();
        }

        static int Addition(int a, int b)
        {
            return a + b;
        }

        static int Subtraction(int a, int b)
        {
            return a - b;
        }

        static int Multiplication(int a, int b)
        {
            int prod = a;
            b--;

            for(int x = 0; x < b; x++)
                prod = Addition(prod, a);

            return prod;
        }

        static int Division(int a, int b)
        {
            int quo = 0;

            while(a >= b)
            {
                a = Subtraction(a, b);
                quo++;
            }

            return quo;
        }

        static int Modulo(int a, int b)
        {
            while (a >= b)
                a = Subtraction(a, b);

            return a;
        }
    }
}
