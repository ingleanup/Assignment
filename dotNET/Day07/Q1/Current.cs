namespace ConsoleApp1
{
    internal class Current : Account
    {
        public Current(string name, double balance)
        {
            Name = name;
            Balance = balance;
        }
        public override void withdraw(double amount)
        {
            Balance -= amount;
        }
    }
}
