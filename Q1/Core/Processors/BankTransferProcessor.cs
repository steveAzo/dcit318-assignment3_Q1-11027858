public class BankTransferProcessor : ITransactionProcessor
{
    public BankTransferProcessor()
    {

    }
    public void Process(Transaction transaction)
    {
        Console.WriteLine("The Bank Transaction amount is "
        + transaction.Amount + " and the Category of the transaction is "
        + transaction.Category);
    }
}