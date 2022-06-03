using System;

namespace Lab10
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Sid's Account");
            long sidsAccNo = Bank.CreateAccount( );
            BankAccount sids = Bank.GetAccount(sidsAccNo);
            TestDeposit(sids);
            TestWithdraw(sids);
            Write(sids);
            if (Bank.CloseAccount(sidsAccNo))
                Console.WriteLine("Account closed");
            else
                Console.WriteLine("Something went wrong closing the account");
        }

        static void Write(BankAccount account)
        {
            Console.WriteLine("Account number is {0}", account.Number());
            Console.WriteLine("Account balance is {0}", account.Balance());
            Console.WriteLine("Account type is {0}", account.Type());
            Console.WriteLine("Transactions:");
            foreach (BankTransaction tran in account.Transactions())
            {
                Console.WriteLine("Date/Time: {0}\tAmount: {1}", tran.When(), tran.Amount());
            }
            Console.WriteLine();
        }
        
        public static void TestDeposit(BankAccount acc)
        {
            Console.Write("Enter amount to deposit: ");
            decimal amount = decimal.Parse(Console.ReadLine());
            acc.Deposit(amount);
        }
        
        public static void TestWithdraw(BankAccount acc)
        {
            Console.Write("Enter amount to withdraw: ");
            decimal amount = decimal.Parse(Console.ReadLine());
            if (!acc.Withdraw(amount)) {
                Console.WriteLine("Insufficient funds.");
            }
        }
    }
}