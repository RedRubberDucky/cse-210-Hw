using System;

class Program
{
    //Functions
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();

        int favoriteNumber = PromptFavoriteNumber();
        string personsName = PromptPersonsName();

        int squaredNumber = SquareNumber(favoriteNumber); 

        DisplayResult(personsName, squaredNumber);
    }

    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptPersonsName()
    {
        Console.Write("Enter your first name: ");
        string name = Console.ReadLine();
        return name;
    }
    static int PromptFavoriteNumber()
    {
        Console.Write("Enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }
    static int SquareNumber(int number)
    {
        int square = number * number;
        return square; 
    }
    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}