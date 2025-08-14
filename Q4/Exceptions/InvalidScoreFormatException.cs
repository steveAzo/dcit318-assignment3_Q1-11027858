public class InvalidScoreFormat : Exception
{
    public string? message;
    public InvalidScoreFormat(string? message)
    {
        this.message = message;
    }
}