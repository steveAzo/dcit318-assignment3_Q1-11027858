public class MobileMoneyProcessor : ITransactionProcessor
{
    public MobileMoneyProcessor ()
    {

    }
    public void Process(Transaction transaction)
    {
        Console.WriteLine("The MobileMoney Transaction amount is "
        + transaction.Amount + " and the Category of the transaction is "
        + transaction.Category);
    }
}