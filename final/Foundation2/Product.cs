public class Product
{
    private string _name;
    private string _productId;
    private double _price;
    private int _quantity;
    private void ComputePrice()
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