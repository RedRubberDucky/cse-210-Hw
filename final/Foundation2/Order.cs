
public class Order
{
    //list of products and customers
    //return the packing label and shipping label
    //packing label, (Name of product, Product id, product order)
    //shipping label, (Name, address, customer)
    // return the total price
    // USA 5$, Outside USA 35$
    
    // list of products
    
    public List <Product> _cart  = new List<Product>();
    Customer _customer; 
    private double _orderTotal;
    private Product _packingLabel;
    private string _shippingLabel;    

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public Order (Customer customer, List<Product> products)
    {
        _customer = customer;
        _cart = new List<Product>();
        _cart = products; 
    }



    
    
    public void AddtoCart(Product product)
    {
        _cart.Add(product);
    }

// packing label, (Name, Product id, product order)    
    public void packinglabel()
    {
        //return($"Product ID:{_packingLabel.ProductInformation()}");
        Console.WriteLine(_packingLabel.ProductInformation());
    }
    
    //shipping label, (Name, address)
    public void shippinglabel()
    {
        //return($"Name: {_customer.CustomerName()}, Address:{_customer.getaddress().printaddress()}"); // call address information from address class
        Console.WriteLine($"{_customer.CustomerName()}Address:{_customer.getaddress().printaddress()}");
    }

    public void printLabels()
    {
        Console.WriteLine("--------------------------");
        //packinglabel();
        shippinglabel();
        foreach (Product p in _cart)
        {
            Console.WriteLine($"{p.ProductInformation()}");
        }
        Console.WriteLine($"\nOrder Total: ${GetTotal()}\n");
        //GetTotal();
        Console.WriteLine($"Shipping Cost: ${_customer.costShipping()}\n");
        Console.WriteLine($"Balance Due: ${_customer.costShipping() + GetTotal()}\n");
        Console.WriteLine("--------------------------");
    }

    public double GetTotal()
    {
        double _total = 0;
        foreach (Product p in _cart)
        {
            _total += p.TotalCost();
        }
        return (_total);
            
    }



}