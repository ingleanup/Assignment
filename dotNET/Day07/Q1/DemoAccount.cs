/*
 * Create class Account having member id, name , balance.
Id autoincrement write read only property
Write getter setter for name and balance.
Balance can be modified only by child class.
This has virtual withdraw method which will 0.
It has deposit method.
Create two child class current and saving and override withdraw method. 
Create reference of Account class and point to saving account
and  current account. Using parent’s reference call withdraw method and deposit method.
Use ToString method to display status of the object [id name balance]
 */


using Microsoft.VisualBasic;
using System.Security.Principal;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account a1 = new Savings("Omkar", 80254);
            Console.WriteLine("Initial balance: " + a1);
            a1.deposit(20000);
            Console.WriteLine("On Deposit: " + a1);
            a1.withdraw(50000);
            Console.WriteLine("On Withdraw: " + a1);

            Account a2 = new Current("Vedant", 921569);
            Console.WriteLine("Initial balance: " + a2);
            a2.deposit(1);
            Console.WriteLine("On Deposit: "+a2);
            a2.withdraw(1000000);
            Console.WriteLine("On Withdraw: "+a2);

        }
    }
}
