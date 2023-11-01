/*
 * Create class Account having member variable id,name, balance.
Write getter/setter for id, name and balance
create method deposit which will increase balance
Create two child class currentaccount and SavingAccount
It has member type,
In both the class create withdraw method who’ s job is to reduce balance.
In currentaccount negative balance allowed
In savingaccount –ve balance not allowed.
When you load application it should print name of bank.
New Savingaccount(1,”Raj”,50000,” “saving”)
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
