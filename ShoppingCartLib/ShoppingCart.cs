namespace ShoppingCartLib;

public class ShoppingCart : IShoppingCart
{
    private readonly List<string> _items = [];

    public List<string> Get()
    {
        return _items;
    }

    public void Add(string product)
    {
        _items.Add(product);
    }

    public void Remove(string product)
    {
        _items.Remove(product);
    }

    public bool Contains(string product)
    {
        return _items.Contains(product);
    }

    public void Clear()
    {
        _items.Clear();
    }

    public int Count()
    {
        return _items.Count;
    }
}