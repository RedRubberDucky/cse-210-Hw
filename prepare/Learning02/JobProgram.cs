using System;

class Program
{
    static void Main(string[] args)
    {
        Jobs person1 = new Jobs("Microsoft", "Software Engineer", "December", 2012, "December", 2018); 
        Jobs person2 = new Jobs("Amazon", "Package sorter", "March", 2020, "June", 2023);

        Resume jobapplication = new Resume();
        jobapplication._name = "Bob Ross";

        jobapplication._jobs.Add(person1);
        jobapplication._jobs.Add(person2);

        jobapplication.displayparts();
        // Console.WriteLine(person2.display());
        // Console.WriteLine(person1.display());
        



    }
}