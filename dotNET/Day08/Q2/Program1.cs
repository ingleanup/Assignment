/*
Task
Solve above program by making above method as instance method.


Task:
Create class mymath having instance member a,b
Create two instance method
 a.  Public int add() ==return sum of two number
b. .  Public int product()==return a*b;
 */

namespace ConsoleAppDelegate
{
    delegate int Iamdelegate(int a, int b);
    internal class Program
    {
        public  int Add(int a, int b)
        {
            return a + b;
        }
        public  int product(int a, int b)
        {
            return (a * b);
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            Iamdelegate del1 = new Iamdelegate(p.Add);
            int a = del1(2, 2);

            del1 = new Iamdelegate(p.product);
            int b = del1(3, 3);
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
