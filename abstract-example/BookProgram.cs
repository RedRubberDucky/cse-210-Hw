// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


Book mistborn = new Book("Mistborn", "Brandon Sanderson"); 
Book MazeRunner = new Book("Maze Runner", "James Dashner");

mistborn.Display();
MazeRunner.Display();

Console.WriteLine(mistborn.IsAvailable()); 