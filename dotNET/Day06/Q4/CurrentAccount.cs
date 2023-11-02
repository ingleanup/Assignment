using ConsoleApp2;

namespace ConsoleApp3
{
    internal class CurrentAccount : Account
    {
        string typeofaccount;
        public CurrentAccount(string name, double balance, string typeofaccount) : base(name, balance)
        {
            this.typeofaccount = typeofaccount;
        }
        public void WithDraw(double amt)
        {
            Balance-=amt;
        }

    }
}
