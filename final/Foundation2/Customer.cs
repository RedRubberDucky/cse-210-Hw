
public class Customer
{
    private string _name;
    private Address _address;
    private int _shippingCost = 5;

    public Customer (string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public int costShipping()
    {
        if(_address.getcountry() != "USA" & _address.getcountry() != "UNITED STATES")
        {
            _shippingCost = 35;
            return _shippingCost;
        }
        else 
        {
            return _shippingCost;
        }

    }

    public string CustomerName()
    {
        return ($"Name:{_name}");
    }
    public Address getaddress()
    {
        return _address;
    }


}
