using System;

class Program
{


    static void Main(string[] args)
    {

        Console.WriteLine("\nWelcome to Foundation 3");

        //Address list
        Address address1 = new Address("644 Chestnut st.", "Everett", "Washington", "usa\n");
        Address address2 = new Address("220 East Cedar Ave.", "Burlington", "Wyoming", "UsA\n");
        Address address3 = new Address("5420 Cherry st", "Vancouver", "--", "Canada\n");

        //Lectures
        Lecture lecture1 = new Lecture("Lecture", "Restoration", "How the gospel was restored", "7/24/2023", "6:00 PM", address1, "Elder Jeffery R. Holland", 2000);


        //Reception
        Reception reception1 = new Reception("Reception", "Wedding", "Congratulations of a marriwage", "7/15/2023", "7:30 pm", address2, "Bobthebuilder@gmail.com");



        //Outdoor Gathering
        Outdoor outdoor1 = new Outdoor("Outdoor", "Mountain Biking", "New bike trails", "8/23/2028", "5:00 am", address3, "unknown");
    
        
        Console.WriteLine("--------------------------");
        Console.WriteLine("Short description" + lecture1.ShortDescription() + "\n");
        Console.WriteLine("Standard details" + lecture1.sharedinformation() + "\n");
        Console.WriteLine("Full details" + lecture1.FullDetails()); 
        Console.WriteLine("--------------------------\n");

        Console.WriteLine("--------------------------");
        Console.WriteLine("Short description" + reception1.ShortDescription() + "\n");
        Console.WriteLine("Standard details" + reception1.sharedinformation() + "\n");
        Console.WriteLine("Full details" + reception1.FullDetails()); 
        Console.WriteLine("--------------------------\n");

        Console.WriteLine("--------------------------");
        Console.WriteLine("Short description" + outdoor1.ShortDescription() + "\n");
        Console.WriteLine("Standard details" + outdoor1.sharedinformation() + "\n");
        Console.WriteLine("Full details" + outdoor1.FullDetails()); 
        Console.WriteLine("--------------------------");
    }

}