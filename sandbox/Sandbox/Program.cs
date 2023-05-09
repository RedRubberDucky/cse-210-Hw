using System;

// reminders
class Program
{
    static void Main(string[] args)
    {
      // Declaring a Variable
      int x;
      x = 5;
      Console.WriteLine(x);

      int y = 5;
      Console.WriteLine(y); 

      //int - Numbers
      //string - a sequence of characters
      //float - numbers with decimals
      //double - a bigger float number
      //bool - Boolean variable, (true or false)

      //Input Output
        // write a line
        Console.WriteLine("Hello World!");
        //Read an input
        Console.Write("What is your favorite color? ");
        string color = Console.ReadLine();

    //If else statements
        if (x > y)
        {
            Console.WriteLine("greater");
        }

    //inputing a string
        string school = "BYU-Idaho"
        Console.WriteLine($"I am studying at {school}.");
    //Operators
        // == equal
        // != not equal
        // >= greater or equal
        // <= less or equal
        // && and
        // || or
        // ! not

    //Converting types
        //Convert from and int to a string
        string valueInText = "42";
        int number = int.Parse(valueInText);

        Console.Write("What is your favorite number? ");
        string userInput = Console.ReadLine();
        int number = int.Parse(userInput);

        // Number to String
        int number = 42;
        string textVersion = number.ToString();

    //While loops
    string response = "yes";
    while (response == "yes")
    {
        Console.Write("Do you want to continue? ");
        response = Console.ReadLine();
    }
    //Lists
        // Add at the top if needed [using System.Collections.Generic;]
        List<int> numbers;
        numbers = new List<int>();

        List<string> words;
        words = new List<string>();
    //Add to a list
    List<int> number;
    number =  List<int>();

    int.add ("12");

    //Function structure
    returnType FunctionName(dataType parameter1, dataType parameter2) 
    {
        // function_body
    }
    }
}