public class MissingFieldException : Exception
{
    public string? message;

    public MissingFieldException(string? message)
    {
        this.message = message;
    }
}