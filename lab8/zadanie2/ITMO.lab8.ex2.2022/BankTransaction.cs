


using System;

internal class BankTransaction
    {
    private readonly decimal amount;
    private readonly DateTime when;

    public decimal Amount()
    {
        return amount;
    }

    public DateTime When()
    {
        return when;
    }
    public BankTransaction(decimal tranAmount)
    {
        amount = tranAmount;
        when = DateTime.Now;
    }

}

