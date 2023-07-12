


public class Product
{
    private int _productID; 
    private string _productName;
    private double _price;
    private int _quantity = 1;


    public Product (string name, int identification, double price, int quantity)
    {
        _productName = name;
        _productID = identification;
        _price = price;
        _quantity = quantity;
    }

    public string ProductInformation()
    {
        return ($"{_productName}, ID#:{_productID}, ${_price} * Number of items:({_quantity})");
    }

    public void QuantityAmount(int quantity)
    {
        _quantity = quantity;
    }

    public double TotalCost()
    {
        double subtotal = _price *_quantity;

        return subtotal;
    }


}