using static System.Console;

namespace Command
{
    public class BankAccount
    {
        private const int OverdraftLimit = -500;
        private int balance;

        public void Deposit(int amount)
        {
            balance += amount;
            WriteLine($"Deposited ${amount}, balance is now {balance}");
        }

        public bool Withdraw(int amount)
        {
            if (balance - amount < OverdraftLimit) return false;
            balance -= amount;
            WriteLine($"Withdrew ${amount}, balance is now {balance}");
            return true;
        }

        public override string ToString()
        {
            return $"{nameof(balance)}: {balance}";
        }
    }
}