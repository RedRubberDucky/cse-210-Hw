using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment test = new Assignment("Isaac Stanworth", "Math");
        Assignment test1 = new Assignment("Isaac Stanworth", "Writing");
        Math math1 = new Math("Isaac Stanworth", "Math", 6, 1, 1, 10);
        Writing writing1 = new Writing("Isaac Stanworth","Writing","May Flower","United States History");
        
        


        Console.WriteLine(test.display());
        Console.WriteLine(math1.displayparts());
        Console.WriteLine(writing1.displaypieces());
    }
    
}