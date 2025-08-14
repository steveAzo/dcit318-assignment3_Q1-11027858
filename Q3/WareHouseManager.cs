public class WareHouseManager
{
    InventoryRepository<ElectronicItem> _electronics = new();
    InventoryRepository<GroceryItem> _groceries = new();

    public void SeedData()
    {
        // adding items for groceries
        GroceryItem groceryItem1 = new GroceryItem(1, "Suasage Role", 5, DateTime.Parse("2025-12-12"));
        _groceries.AddItem(groceryItem1);
        GroceryItem groceryItem2 = new GroceryItem(2, "Tissue", 10, DateTime.Parse("2022-07-13"));
        _groceries.AddItem(groceryItem2);
        GroceryItem groceryItem3 = new GroceryItem(3, "Tooth Paste", 15, DateTime.Parse("2027-12-12"));
        _groceries.AddItem(groceryItem3);
        GroceryItem groceryItem4 = new GroceryItem(4, "Kivo Gari", 20, DateTime.Parse("2029-02-14"));
        _groceries.AddItem(groceryItem4);

        // adding items for electronics
        ElectronicItem electronicItem1 = new ElectronicItem(1, 5, "BIG B", 7);
        _electronics.AddItem(electronicItem1);
        ElectronicItem electronicItem2 = new ElectronicItem(2, 5, "EEV", 2);
        _electronics.AddItem(electronicItem2);
        ElectronicItem electronicItem3 = new ElectronicItem(3, 7, "J Electronics", 6);
        _electronics.AddItem(electronicItem3);
        ElectronicItem electronicItem4 = new ElectronicItem(4, 3, "Big But Electronics", 4);
        _electronics.AddItem(electronicItem4);

    }

    // A function that prints everything
    public void PrintAllItems<T>(InventoryRepository<T> repo) where T : IInventory
    {
        foreach (var item in repo.GetAllItems())
        {
            Console.WriteLine(item);
        }
    }

    public void IncreaseStock<T>(InventoryRepository<T> repo, int id, int quantity) where T : IInventory
    {
        if (quantity <= 0)
        {
            throw new InvalidQuantityException("Quantity must be greater than zero");
        }

        var item = repo.GetItemById(id);
        item.Quantity += quantity;
    }

    public void RemoveItemById<T>(InventoryRepository<T> repo, int id) where T : IInventory
    {
        repo.RemoveItem(id);
    }
    
    public InventoryRepository<GroceryItem> GetGroceriesRepo()
    {
        return _groceries;
    }

    public InventoryRepository<ElectronicItem> GetElectronicsRepo()
    {
        return _electronics;
    }


}