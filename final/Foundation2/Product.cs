public class Product
{
    private string _name;
    private string _productId;
    private double _price;
    private int _quantity;
    public Product(string name, string productId, double price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }
    public void ComputePricePerQuantity()
    {
        _price = _price * _quantity;
    }
    public double GetPrice()
    {
        return _price;
    }
    public string GetName()
    {
        return _name;
    }
    public string GetProductId()
    {
        return _productId;
    }
}