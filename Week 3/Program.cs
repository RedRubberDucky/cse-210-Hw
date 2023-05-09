using System;

class Program{

static void Main(string[] args)
{
    Consol.WriteLine("Hello World!");

    Car bmw_m3 = new Car();
    
    bmw_m3.brand = "BMW";
    bmw_m3.miles - 1000;
    bmw_m3.color = "purple"; 

    bmw_m3.displayInfo();
    bmw_m3.move_forward();
    
}
}