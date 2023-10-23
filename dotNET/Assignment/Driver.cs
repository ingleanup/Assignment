/*
 * Create a class calculator and write 3 instance method square, cube, round[if in put 22.5 o/p 22]
Which will return square .cube and rounded number.
Create object and call method and print the result.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{

    class Calculator
    {
        public float Square(float x)
        {
            return x*x;
        }
        public float Cube(float x)
        {
            return x*x*x;
        } 
        public int Round(float x)
        {
            return (int)(x);
        }
    }

    class Driver
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            Console.WriteLine("Enter the Number : ");
            string str = Console.ReadLine();
            float num;
            bool flag = float.TryParse(str, out num);
            Console.WriteLine("Square of the number is  : {0}", calculator.Square(num));
            Console.WriteLine("Cube of the number is  : {0}", calculator.Cube(num));
            Console.WriteLine("Round of the number is  : {0}", calculator.Round(num));
        }
    }

}
