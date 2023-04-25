using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What was the grade you got on your assignment? ");
        string percentage = Console.ReadLine();
        int grade = int.Parse(percentage);

        string total = "";

        if (grade >= 90)
        {
            total = "A";
        }
        else if (grade < 90 || grade >= 80)
        {
            total = "B";   
        }        
        else if (grade < 80 || grade >= 70)
        {
           total = "C"; 
        }
        else if (grade < 70 || grade >= 60)
        {
            total = "D";
        }
        else 
        {
           total = "F"; 
        }
        Console.WriteLine($"Your final grade is: {total}");
        
        if (grade >= 70)
        {
            Console.WriteLine("Congratualtions you passed the class!");
        } 
        else
        {
            Console.WriteLine("Try again");
        }   
    }
}