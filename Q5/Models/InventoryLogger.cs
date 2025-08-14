public class InventoryLogger<T> where T : IInventoryEntity
{
    private List<T> _log = new();
    private string? _filePath;

    public void Add(T item) => _log.Add(item);

    public List<T> GetAll() => _log;

    public void SaveToFile(string filePath)
    {
        try
        {
            using var writer = new StreamWriter(filePath);
            foreach (var log in _log)
            {
                writer.WriteLine($"{log.Id}|{GetName(log)}|{GetQuantity(log)}|{GetDateAdded(log)}");
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine($"File error: {ex.Message}");
        }
    }

    public void LoadFromFile(string filePath, Func<int, string, int, DateTime, T> factory)
    {
        try
        {
            using var reader = new StreamReader(filePath);
            string? line;
            while ((line = reader.ReadLine()) != null)
            {
                var parts = line.Split('|');
                if (parts.Length != 4) continue; // skip bad lines

                int id = int.Parse(parts[0]);
                string name = parts[1];
                int quantity = int.Parse(parts[2]);
                DateTime dateAdded = DateTime.Parse(parts[3]);

                _log.Add(factory(id, name, quantity, dateAdded));
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine($"File error: {ex.Message}");
        }
    }

    private static string GetName(T item) => (string)item!.GetType().GetProperty("Name")!.GetValue(item)!;
    private static int GetQuantity(T item) => (int)item!.GetType().GetProperty("Quantity")!.GetValue(item)!;
    private static DateTime GetDateAdded(T item) => (DateTime)item!.GetType().GetProperty("DateAdded")!.GetValue(item)!;
}
