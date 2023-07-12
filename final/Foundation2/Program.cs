
class Program
{

    static void Main(string[] args)
    {
        Console.WriteLine("\nWelcome to Foundation 2");

        Address address1 = new Address("644 Chestnut st.", "Everett", "Washington", "usa\n");
        Address address2 = new Address("220 East Cedar Ave.", "Burlington", "Wyoming", "UsA\n");
        Address address3 = new Address("5420 Cherry st", "Vancouver", "--", "Canada\n");

        Customer customer1 = new Customer("Matthew Martin\n", address1);
        Customer customer2 = new Customer("Alfred Banner\n", address2);
        Customer customer3 = new Customer("Cameron Jones\n", address3);

        Product product1 = new Product("Shark Vaccum", 0246, 120, 2);
        Product product2 = new Product("Cat", 666, 35, 4);
        Product product3 = new Product("Table", 5876, 49.99, 1);
        Product product4 = new Product("Chocolate", 4556, 5.48, 2);




        Order order1 = new Order(customer1);
        order1.AddtoCart(product1);
        order1.AddtoCart(product2);

        Order order2 = new Order(customer2);
        order2.AddtoCart(product1);
        order2.AddtoCart(product2);
        order2.AddtoCart(product4);

        Order order3 = new Order(customer3);
        order3.AddtoCart(product3);
        order3.AddtoCart(product1);
        order3.AddtoCart(product4);
        order3.AddtoCart(product2);
        

       // List<Product> orderlist1 = new List<Product>();
       // orderlist1.Add(product1);

        //Order order2 = new Order(customer1, orderlist1);

        order1.printLabels();
        order2.printLabels();
        order3.printLabels();
    
    
    
    }

}