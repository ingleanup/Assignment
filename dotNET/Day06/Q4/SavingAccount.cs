using ConsoleApp2;

namespace ConsoleApp3
{
    internal class SavingAccount : Account
    {
        string typeofaccount;
        const int minbal = 1000;
        public SavingAccount(string name, double balance, string typeofaccount) : base(name, balance)
        {
            this.typeofaccount = typeofaccount;
        }
        public void WithDraw(double amt)
        {
            if (Balance > minbal&&amt<Balance)
            {
                Balance-=amt;
            }
            else
                Console.WriteLine("Insufficent Balance");
        }
    }
}
