public class ItemNotFoundException : Exception
{
    public string? message;

    public ItemNotFoundException(string? message)
    {
        this.message = message;
    }
}