using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int guess = -1;
        

        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (magicNumber > guess)
            {
                Console.WriteLine("Your guess is to low. ");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Your guess was to high. ");
            }
            else 
            {
                Console.WriteLine("You got the right number! ");
            }
        }


        
    

    }
}