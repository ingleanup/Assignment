using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFact
{

    class MyClass
    {
        public static float getSqr(float x)
        {
            return x*x;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number : ");
            string snum1 = Console.ReadLine();
            bool f = float.TryParse(snum1, out float b);
            Console.WriteLine("Output is : "+getSqr(b));
            Console.ReadLine();
        }

    }
}





using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFact
{

    class MyClass
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
            Console.ReadLine();
        }

    }
}
