/*
 * 
Write a method which will accept two number and return all even number between it as array and also give count in out variable.
Int count=
Int [] result=Dojob(5,30)
 */

using System;

namespace ConsoleApp2
{
    internal class ReferenceExample2
    {
        static int[] Check(int start, int end, out int count)
        {
            count=0;
            int j = 0;
            int[] arr = new int[20];
            for (int i = start; i < end; i++)
            {
                if (i%2==0)
                {
                    arr[j++] = i;
                    count++;
                }
            }
            return arr;

        }
        static void Main(string[] args)
        {
            Console.Write("Enter the starting number : ");
            int k1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the Ending number : ");
            int k2 = int.Parse(Console.ReadLine());
            int c;
            int[] arr;
            arr =Check(k1, k2, out c);
            for (int i = 0; i<c; i++)
            {
                Console.Write(arr[i]+" ");
            }
            Console.WriteLine();
            Console.WriteLine("Count of Even number is : "+c);
        }
    }
}
