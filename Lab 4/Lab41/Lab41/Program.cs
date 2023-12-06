using System;
namespace Lab41
{
    class BankAccount
    {
        private double balance;
        public double Balance
        {
            get { return balance; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Balance can not be negative");
                }
                else
                balance = value;
            }
        }
        public BankAccount(double initialBalance)
        {
            Balance = initialBalance;
        }
        public void deposit(double amount)
        {
            Balance += amount;
        }
        public void withdraw(double amount)
        {
            Balance -= amount;
        }
        public static void Main(string[] args)
        {
            BankAccount ac = new BankAccount(10000);
            Console.WriteLine("Current balance : " + ac.Balance);
            try
            {
                ac.withdraw(12000);
            }
            catch (ArgumentException ex) {
                Console.WriteLine("Error : "+ex.Message);
            }
            ac.deposit(100);
            Console.WriteLine("Current balance : " + ac.Balance);
        }
    }
}
