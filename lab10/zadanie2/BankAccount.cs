using System;
using System.Collections;
using System.IO;

namespace Banking
{
    public sealed class BankAccount : IDisposable
    {
        private long accNo;
        private decimal accBal;
        private AccountType accType;
        private static long nextAccNo;
        private Queue tranQueue = new Queue();
        private bool disposed = false;
        
        internal BankAccount()
        {
            accNo = NextNumber();
            accType = AccountType.Checking;
            accBal = 0;
        }
        
        internal BankAccount(AccountType aType)
        {
            accNo = NextNumber();
            accType = aType;
            accBal = 0;
        }

        internal BankAccount(decimal aBal)
        {
            accNo = NextNumber();
            accType = AccountType.Checking;
            accBal = aBal;
        }


        internal BankAccount(AccountType aType, decimal aBal)
        {
            accNo = NextNumber();
            accType = aType;
            accBal = aBal;
        }

        public long Number()
        {
            return accNo;
        }
        
        public decimal Balance()
        {
            return accBal;
        }
        
        public String Type()
        {
            return accType.ToString();
        }

        private static long NextNumber()
        {
            return nextAccNo++;
        }
        
        public decimal Deposit(decimal amount)
        {
            if (amount >= 0)
            {
                accBal += amount;
                BankTransaction tran = new BankTransaction(amount);
                tranQueue.Enqueue(tran);
                return accBal;
            }
            else
            {
                return 0;
            }
        }

        public bool Withdraw(decimal amount)
        {
            bool sufficientFunds = accBal >= amount;
            if (sufficientFunds) {
                accBal -= amount;
                BankTransaction tran = new BankTransaction(-amount);
                tranQueue.Enqueue(tran);
            }
            return sufficientFunds;
        }

        public void TransferFrom(BankAccount accFrom, decimal amount)
        {
            if (accFrom.Withdraw(amount))
                this.Deposit(amount);
        }
        
        public Queue Transactions()
        {
            return tranQueue;
        }
        
        public void Dispose()
        {
            if (!disposed)
            {
                StreamWriter swFile = File.AppendText("Transactions.Dat");
                swFile.WriteLine("Account number is {0}", accNo);
                swFile.WriteLine("Account balance is {0}", accBal);
                swFile.WriteLine("Account type is {0}", accType);
                swFile.WriteLine("Transactions:");
                foreach(BankTransaction tran in tranQueue)
                {
                    swFile.WriteLine("Date/Time: {0}\tAmount:{1}", tran.When( ), tran.Amount( ));
                }
                swFile.Close( );
                disposed = true;
                GC.SuppressFinalize(this);
            }
        }
        
        ~BankAccount()
        {
            Dispose();
        }
    }
}