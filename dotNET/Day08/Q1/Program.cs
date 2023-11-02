/*
Task:
Create two static methd
 a.  Public static int add(int a,int b) ==return sum of two number
b. .  Public static int product(int a,int b)==return a*b;
Declare delegate which can point to this method.
Using reference of delegate call this method and print result
 */

namespace ConsoleAppDelegate
{
    delegate int Iamdelegate(int a, int b);
    internal class Program
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static int product(int a, int b)
        {
            return (a * b);
        }
        static void Main(string[] args)
        {
            Iamdelegate del1 = new Iamdelegate(Add);
            int a = del1(2, 2);

            del1 = new Iamdelegate(product);
            int b = del1(3, 3);
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
