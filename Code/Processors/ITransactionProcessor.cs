using System;


public interface ITransactionProcessor
{
    public void Process(Transaction transaction);
}