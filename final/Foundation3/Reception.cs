

public  class Reception : Event
{
    
    private string _contact;

    public Reception(string type, string title, string description, string date, string time, Address address, string contact) : base( type, title, description, date, time, address) 
    {
        _contact  = contact;
    }

    public string ContactInformation()
    {
        return ($"{_contact}");
    }

 public override string FullDetails()
    {
        return($"{base.sharedinformation()}{ContactInformation()}");
    }

}