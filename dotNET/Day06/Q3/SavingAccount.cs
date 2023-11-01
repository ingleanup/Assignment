using ConsoleApp2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class SavingAccount:Account
    {
        string type;
        public SavingAccount(string name, double balance,string type) : base(name, balance)
        {
            this.type = type;
        }
        public void WithDraw(double amt)
        {
            if (Balance > 0&&amt<Balance)
            {
                Balance-=amt;
            }
            else
                Console.WriteLine("Insufficent Balance");
        }
         public override string ToString()
        {
            return string.Format($"{ID} {Name} {Balance} ");
        }
    }
}
