
public class Order
{
    //list of products and customers
    //return the packing label and shipping label
    //packing label, (Name, Product id, product order)
    //shipping label, (Name, address, customer)
    // return the total price
    // USA 5$, Outside USA 35$
    
    public string _name;
    public string _address;
    public int _productID;
    public string _customer;
    public int _ordernumber; 
    public string _contents;

    public Order(string name, string address, int product_ID, string customer, int order_number, string contents)
    {
        _name = name;
        _address = address;
        _productID = product_ID;
        _customer = customer;
        _ordernumber = order_number;
        _contents = contents;
    }

    // packing label, (Name, Product id, product order)
    
    public string packinglabel()
    {
        return($"Name:{_name}, Product ID:{_productID} Contents:{_contents}");
    }
    
    //shipping label, (Name, address, customer)
    public string shippinglabel()
    {
        return($"Name: {_name}, Address:{_address}, Customer: {_customer}"); // call address information from address class
    }
    


}