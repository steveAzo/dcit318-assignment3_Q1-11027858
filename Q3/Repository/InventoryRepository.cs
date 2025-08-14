public class InventoryRepository<T> where T : IInventory
{
    Dictionary<int, T> _items = new Dictionary<int, T>();

    public void AddItem(T item)
    {
        if (_items.ContainsKey(item.Id))
        {
            throw new DuplicateItemException("This item already exists");
        }
        // else add the item to the dictionary
        _items.Add(item.Id, item);

    }

    public T GetItemById(int id)
    {
        if (!_items.ContainsKey(id))
        {
            throw new ItemNotFoundException("Item not found");
        }
        _items.TryGetValue(id, out var item);
        return item!;
    }

    public void RemoveItem(int id)
    {
        if (!_items.ContainsKey(id))
        {
            throw new ItemNotFoundException("This item does not exist");
        }
        _items.Remove(id);
    }

    public List<T> GetAllItems()
    {
        return _items.Values.ToList();
    }

    public void UpdateQuantity(int id, int newQuantity)
    {
        if (newQuantity < 0) throw new InvalidQuantityException("Quantity should not be negative");
        if (!_items.ContainsKey(id)) throw new ItemNotFoundException("This item does not exist in the dictionary");

        _items.TryGetValue(id, out var item);
        item!.Quantity = newQuantity;
    }
}