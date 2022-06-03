using System.Collections;

namespace Lab10
{
    class Bank
    {
        private static Hashtable accounts = new Hashtable();
        
        private static BankAccount account;

        private Bank()
        {
        }

        public static BankAccount GetAccount(long accNo)
        {
            return (BankAccount)accounts[accNo];
        }

        public static long CreateAccount()
        {
            account = new BankAccount();
            long accNum = account.Number();
            accounts[accNum] = account;
            return accNum;
        }

        public static bool CloseAccount(long accNo)
        {
            BankAccount closing = (BankAccount)accounts[accNo];
            if (closing != null)
            {
                accounts.Remove(accNo);
                closing.Dispose();
                return true;
            }
            else
            {
                return false;
            }
        }

        public BankAccount CreateAccount(AccountType aType)
        {
            account = new BankAccount(aType);
            return account;
        }
        
        public BankAccount CreateAccount(decimal aBal)
        {
            account = new BankAccount(aBal);
            return account;
        }
        
        public BankAccount CreateAccount(AccountType aType, decimal aBal)
        {
            account = new BankAccount(aType, aBal);
            return account;
        }
    }
}
