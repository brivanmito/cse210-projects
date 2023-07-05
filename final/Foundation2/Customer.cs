public class Customer
{
    private string _name;
    private Address _address;
    public bool GetIsUsa()
    {
        return _address.IsUSA();
    }

}