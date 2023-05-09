public class Car {
    // instances
    public string brand = "";
    public int miles = ""; 
    public string color = "";


    //constructor
    public Car(){
        
    }
    //Methods (Funcitons)
    public void move_Forward(){
        Console.Write("is running");
    }
    public void displayInfo(){
        Console.Writeline($"brand = {brand}, miles = {miles}, color = {color}");
    }
}