using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<int> numbers;
        numbers = new List<int>();
        
        int start = -1;
        while (start != 0)
        {
            Console.Write("Add a number to the list (enter 0 to exit). ");
            
            string userInput = Console.ReadLine();
            start = int.Parse(userInput);

            if (start != 0)
            {
                numbers.Add(start);
            }
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number; 
            }

            Console.WriteLine($"The sum is: {sum}");

            float average = ((float)sum) / numbers.Count;
            Console.WriteLine($"The average is: {average}");
        }
    }
}