using System;

public class Test
{
    public static void Main()
    {
        BankAccount b1 = new BankAccount();
        b1.Populate(100);

        BankAccount b2 = new BankAccount();
        b2.Populate(100);

        Console.WriteLine("Before transfer");
        Console.WriteLine("{0} {1} {2}", b1.Type(), b1.Number(), b1.Balance());
        Console.WriteLine("{0} {1} {2}", b2.Type(), b2.Number(), b2.Balance());

        b1.TransferFrom(b2, 10);

        Console.WriteLine("After transfer");
        Console.WriteLine("{0} {1} {2}", b1.Type(), b1.Number(), b1.Balance());
        Console.WriteLine("{0} {1} {2}", b2.Type(), b2.Number(), b2.Balance());

    }
}
