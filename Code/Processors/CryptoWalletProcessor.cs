public class CryptoWalletProcessor : ITransactionProcessor
{
    public CryptoWalletProcessor()
    {

    }
    public void Process(Transaction transaction)
    {
        Console.WriteLine("The CryptoWallet Transaction amount is "
        + transaction.Amount + " and the Category of the transaction is "
        + transaction.Category);
    }
}