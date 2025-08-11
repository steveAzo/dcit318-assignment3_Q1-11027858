public class SavingsAccount : Account
{
    public SavingsAccount(string AccountNumber, decimal initialBalance)
        : base(AccountNumber, initialBalance)
    {
        this.AccountNumber = AccountNumber;
        this.Balance = initialBalance;
    }
    public override void ApplyTransaction(Transaction transaction)
    {

        if (transaction.Amount > Balance)
        {
            Console.WriteLine("Insufficient funds");
            return;
        }
        base.ApplyTransaction(transaction);
        Console.WriteLine($"Transaction applied. Updated balance: {Balance}");
    }
}