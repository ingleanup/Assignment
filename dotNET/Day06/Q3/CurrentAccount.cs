using ConsoleApp2;

namespace ConsoleApp3
{
    internal class CurrentAccount : Account
    {
        string type;
        public CurrentAccount(string name, double balance,string type) : base(name, balance)
        {
            this.type = type;
        }
        public void WithDraw(double amt)
        {
            Balance-=amt;
        }
         public override string ToString()
        {
            return string.Format($"{ID} {Name} {Balance} ");
        }
    }
}
