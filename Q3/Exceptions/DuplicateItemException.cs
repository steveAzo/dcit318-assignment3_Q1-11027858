public class DuplicateItemException : Exception
{
    public string? message;

    public DuplicateItemException(string? message)
    {
        this.message = message;
    }
}