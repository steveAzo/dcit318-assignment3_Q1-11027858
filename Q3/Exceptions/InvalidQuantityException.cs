public class InvalidQuantityException : Exception
{
    public string? message;

    public InvalidQuantityException(string? message)
    {
        this.message = message;
    }
}