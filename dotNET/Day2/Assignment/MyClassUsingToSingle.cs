//Q2. Accept a float value and print square of that number
//using ToSingle()

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{

    class MyClassUsingToSingle
    {
        public static float getSqr(float x)
        {
            return x*x;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number : ");
            string snum1 = Console.ReadLine();
            float f = Convert.ToSingle(snum1);
            Console.WriteLine(getSqr(f));
        }

    }
}
