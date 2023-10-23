using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Assignment
    {
        public static int getSum(int x,int y)
        {
            return x + y;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number 1: ");
            string snum1 = Console.ReadLine();
            Console.WriteLine("Enter the number 2: ");
            string snum2 = Console.ReadLine();
            int.TryParse(snum1, out int b);
            int.TryParse(snum2, out int c);
            Console.WriteLine("Output is: "+getSum(b, c));
        }
    }
}
