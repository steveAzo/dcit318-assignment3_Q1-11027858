using System;

public class Account
{
    public string? AccountNumber;
    public decimal Balance;

    public Account(string AccountNumber, decimal initialBalance)
    {
        this.AccountNumber = AccountNumber;
        this.Balance = initialBalance;
    }


    public virtual void ApplyTransaction(Transaction transaction)
    {
        Balance -= transaction.Amount;
    }

}