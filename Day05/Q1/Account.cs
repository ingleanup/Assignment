using System;
using System.CodeDom;

namespace ConsoleApp2
{
    class Account
    {
        int id;
        string firstnm;
        string middlenm;
        string lastnm;
        double balance;
        static int roi = 7;
        static int idcount=1;
        static Account()
        {
            Console.WriteLine("Welcome to StateBank Of India\n");
        }

        public Account(string firstnm,string middlenm,string lastnm,double balance)
        {
            this.id = ++idcount;
            this.balance = balance;
            this.middlenm = middlenm;
            this.lastnm = lastnm;
            if (firstnm.Length>3)
            {
                this.firstnm = firstnm;
            }
            else
            {
                throw new Exception("Can't Create object: Name must be Greater than 3 char");
            }             
        }
        public void Deposit(double amt) 
        {
            balance+=amt;
        }
        public void Withdraw(double amt) 
        {
           if(amt<balance)
                balance -= amt;
        }
       public static double Payint(Account obj)
        {
            return obj.balance= obj.balance+((obj.balance*roi)/100);
        }
        public void Disp()
        {
            Console.WriteLine($"name of account holder is  : {firstnm} {middlenm} {lastnm}\nBalcance is :{balance}");
        }
    }
}
