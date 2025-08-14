// public record InventoryItem : IInventoryEntity
// {
//     public int Id { get; set; }
//     public string? Name { get; set; }
//     public int Quantity { get; set; }
//     public DateTime DateAdded { get; set; }



// }
public record InventoryItem(int Id, string Name, int Quantity, DateTime DateAdded) : IInventoryEntity;
