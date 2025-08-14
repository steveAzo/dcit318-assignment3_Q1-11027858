public class InventoryApp
{
    private InventoryLogger<InventoryItem> _logger = new();

    public void SeedSampleData()
    {
        _logger.Add(new InventoryItem(1, "Laptop", 5, DateTime.Now));
        _logger.Add(new InventoryItem(2, "Mouse", 10, DateTime.Now));
        _logger.Add(new InventoryItem(3, "Keyboard", 7, DateTime.Now));
    }

    public void SaveData(string filePath) => _logger.SaveToFile(filePath);

    public void LoadData(string filePath)
    {
        _logger.LoadFromFile(filePath, (id, name, qty, date) => new InventoryItem(id, name, qty, date));
    }

    public void PrintAllItems()
    {
        foreach (var item in _logger.GetAll())
        {
            Console.WriteLine($"{item.Id} | {item.Name} | {item.Quantity} | {item.DateAdded}");
        }
    }
}
