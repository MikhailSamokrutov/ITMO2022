using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.BankAccount
{
    
public enum AccountType { Checking, Deposit }
    internal class Program
    {
        static void Main(string[] args)

        {
            AccountType goldAccount;

            AccountType platinumAccount;

            goldAccount = AccountType.Checking;
            platinumAccount = AccountType.Deposit;

            Console.WriteLine("The Customer Account Type is {0}", goldAccount);
            Console.WriteLine("The Customer Account Type is {0}", platinumAccount);

        }
    }
}
