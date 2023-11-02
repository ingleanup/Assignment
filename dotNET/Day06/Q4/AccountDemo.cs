/*
 * 
Create class Account having member variable id, name, balance
Id is autoincrement it has getter property
Name and balance need getter setter property
//Ensure when you open account amt should not be <1
Declare static double intrate=0.07;
It has deposit method who’s job is to increase balance.
Create two child class Savingaccount, Currentaccount
It has fields typeofaccount.
In Savingaccount,  child class it has withdraw method who’s job is to reduce balance. It is a rule to maintain minimum balance of rs1000 so declare
const int minbal=1000
 In Currentaccount,  child class it has withdraw method who’s job is to reduce balance here –ve balance is allowed.
Create object of two child class and do the transaction
In Account class write public override string ToString(){} which will display id name balance.

 */


using ConsoleApp3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class AccountDemo
    {
        static void Main(string[] args)
        {
            CurrentAccount p1 = new CurrentAccount("Raj", 30_000, "Current");
            SavingAccount p2 = new SavingAccount("omkar", 40_000, "saving");
            p1.WithDraw(3000);

            Console.WriteLine(p1.ToString());
            p1.Deposit(1000);
            Console.WriteLine(p1.ToString());
            p1.WithDraw(30_000);
            Console.WriteLine(p1.ToString());
            p2.WithDraw(4000);
            Console.WriteLine(p2.ToString());
        }
    }
}
