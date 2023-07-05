public class Address
{
    private string _streetAddress;
    private string _city;
    private string _province;
    private string _country;
    public bool IsUSA()
    {
        if(_country == "USA" || _country == "United States")
        {
            return true;
        }
        return false;
    }

}