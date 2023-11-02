namespace ConsoleApp2
{
    internal class Account
    {
        int id;
        string name;
        double balance;
        static int sid;
        static double intrate = 0.07;

        static Account()
        {
            Console.WriteLine("Welcome to State Bank of India \n");
        }
        public Account(string name, double balance)
        {
            this.id = ++sid;
            this.name = name;
            this.balance = balance;
        }
        public int ID
        {
            get { return id; }
        }
        public string Name
        {
            get { return name; }
            set { name=value; }
        }
        public double Balance
        {
            get { return balance; }
            protected set { balance = value; }
        }
        public void Deposit(double d)
        {
            Console.WriteLine("***Moneey deposited sucessfully***");
            Balance += d;
        }
        public override string ToString()
        {
            return string.Format($"{ID} {Name} {Balance} ");
        }
    }
}
