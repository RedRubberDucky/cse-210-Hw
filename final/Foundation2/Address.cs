

public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public Address(string street, string city, string state, string country)
    {

        _street = street;
        _city = city;
        _state = state;
        _country = country.ToUpper();
    }

    public string printaddress()
    {
        return($"\n{_street}\n{_city}\n{_state}\n{_country}");
    }     
    
   public string getcountry()
   {
        return (_country);
   }
}