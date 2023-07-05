public class Order
{
    private List<Product> _listOfProducts;
    private Customer _customer;
    private double _shipCost;
    private double _totalCost;
    private string _packingLabel;
    private string _shippingLabel;

    private void ComputeTotalPrice()
    {
        foreach(Product product in _listOfProducts)
        {
            _totalCost += product.GetPrice();
        }
    }
    private void AddShipCost()
    {
        bool inUsa = _customer.GetIsUsa();
        if(inUsa)
        {
            _shipCost = 5;
        }
        else
        {
            _shipCost = 35;
        }
    }
    private string CreatePackingLabel()
    {
        foreach(Product product in _listOfProducts)
        {
            _packingLabel = $"{product.GetName()} - {product.GetProductId()}\n";
        }
        return _packingLabel;
    }
    private string CreateShippingLabel()
    {
        return "a";
    }
}