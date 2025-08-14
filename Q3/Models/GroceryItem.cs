public class GroceryItem : IInventory
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public int Quantity { get; set; }
    public DateTime ExpiryDate { get; set; }

    public GroceryItem(int Id, string Name, int Quantity, DateTime ExpiryDate)
    {
        this.Id = Id;
        this.Name = Name;
        this.Quantity = Quantity;
        this.ExpiryDate = ExpiryDate;
    }

    public override string ToString()
    {
        return $"Name: {Name}, Quantity: {Quantity}, Quantity: {Quantity}";
    }
}