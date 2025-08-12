
public class FinanceApp
{
    readonly List<Transaction> _transactions = new List<Transaction>();
    BankTransferProcessor bankTransferProcessor = new BankTransferProcessor();
    CryptoWalletProcessor cryptoWalletProcessor = new CryptoWalletProcessor();
    MobileMoneyProcessor mobileMoneyProcessor = new MobileMoneyProcessor();

    public void Run()
    {
        SavingsAccount savingsAccount = new SavingsAccount("11027858", 3000.45m);

        Transaction transaction1 = new Transaction
        {
            Id = 1,
            Date = DateTime.Parse("12-24-2024"),
            Amount = 1001.75m,
            Category = "Groceries",
        };

        // Apply transaction to SavingsAccount's ApplyTransaction method
        savingsAccount.ApplyTransaction(transaction1);
        bankTransferProcessor.Process(transaction1);
        Console.WriteLine();

        Transaction transaction2 = new Transaction
        {
            Id = 2,
            Date = DateTime.Parse("08-11-2025"),
            Amount = 5000,
            Category = "Utilities",
        };
        savingsAccount.ApplyTransaction(transaction2);
        cryptoWalletProcessor.Process(transaction2);
        Console.WriteLine();

        Transaction transaction3 = new Transaction
        {
            Id = 3,
            Date = DateTime.Parse("02-19-2003"),
            Amount = 45,
            Category = "Entertainment"
        };
        savingsAccount.ApplyTransaction(transaction3);
        mobileMoneyProcessor.Process(transaction3);
        Console.WriteLine();

        // Add each transaction to _transactions array of transactions
        _transactions.Add(transaction1);
        _transactions.Add(transaction2);
        _transactions.Add(transaction3);

        foreach (var t in _transactions)
        {
            Console.WriteLine($"{t.Id} | {t.Date:d} | {t.Amount} | {t.Category}");
        }

    }
}