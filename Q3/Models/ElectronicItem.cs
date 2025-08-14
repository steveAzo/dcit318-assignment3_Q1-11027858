public class ElectronicItem : IInventory
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public int Quantity { get; set; }
    public string? Brand { get; set; }
    public int WarrantyMonths { get; set; }

    public ElectronicItem(int Id, int Quantity, string Brand, int WarrantyMonths)
    {
        this.Id = Id;
        this.Quantity = Quantity;
        this.Brand = Brand;
        this.WarrantyMonths = WarrantyMonths;
    }

    public override string ToString()
    {
        return $" ID: {Id}, Quantity: {Quantity}, Brand: {Brand}, Warranty: {WarrantyMonths} months";
    }

}

