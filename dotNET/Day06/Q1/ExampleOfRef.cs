/*
 Write a method which will return sum of digit and using out variable let it send count of digit also.
Eg. input 123  return(6) in out variable (3)

 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class ExampleOfRef
    {
         public int Sum(int num,out int count)
        {
            count=0;
            int sum=0;
           while(num!=0)
            {
                int rem=num%10;
                sum+=rem;
                num/=10;
                count++;
            }
           return sum;
        }
        static void Main(string[] args)
        {
            ExampleOfRef ex = new ExampleOfRef(); 
            int c;
            int sum;
            int ip;
            Console.Write("Enter the Digit : ");
            bool flag = int.TryParse(Console.ReadLine(), out ip);
            sum = ex.Sum(ip,out c);
            Console.WriteLine("Sum of digit is : "+sum);
            Console.WriteLine("Count of Digit is : "+c);
        }
    }
}
