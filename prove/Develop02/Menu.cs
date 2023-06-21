using System.IO;

public class Menu
{
    private Journal _journal;
    

    public List<string> _EntryList = new List<string>();


    public void ShowJournal()
    {
        string response = "";
        while(response != "Q") {
            Console.WriteLine("Select from the following options:");
            Console.WriteLine("* [W]rite a new entry");
            Console.WriteLine("* [D]isplay all entries");
            Console.WriteLine("* [S]ave the journal");
            Console.WriteLine("* [L]oad a journal from the file");
            response = Console.ReadLine().ToUpper();
            
            // string[] options = ("Q","W", "D", "S", "L");
            switch (response)
            {
                case "Q":  // Allows the user to quit the program
                    Console.WriteLine("Quitting.");
                    break;
                case "W":     // Write a new entry with the given prompt.
                    Prompts prompt = new Prompts();
                    prompt.generate_random_number();
                    Console.WriteLine("Record your thoughts.");
                    string Thoughts = Console.ReadLine();
                    Console.WriteLine("What is your location?");
                    string Place = Console.ReadLine();
                    Entry entry = new Entry(Place, Thoughts);
                    string entry1 = entry.getentry();
                    _EntryList.Add(entry1);
                    break;
                case "D":       //Display the journal entry that was written 
                    foreach(string element in _EntryList)
                    {
                    System.Console.WriteLine(element);
                    }
                    break;
                case "S":       //Save the journal
                        string filename = "Journal_Record.txt";

                        using (StreamWriter outputFile = new StreamWriter(filename))
                    {
                        foreach(string element in _EntryList)
                    {
                        outputFile.WriteLine(element);
    
                    }
                        // You can add text to the file with the WriteLine method

                        // outputFile.WriteLine("This will be the first line in the file.");
    
                        // // You can use the $ and include variables just like with Console.WriteLine
                        // string color = "Blue";
                        // outputFile.WriteLine($"My favorite color is {color}");
                    }
                    break;
                    
                case "L":       //Load a journal from a file
                        filename = "Journal_Record.txt";
                        string[] lines = System.IO.File.ReadAllLines(filename);

                        foreach (string line in lines)
                    {
                            _EntryList.Add(line);
                    //     string[] parts = line.Split(",");

                    //     string firstName = parts[0];
                    //     string lastName = parts[1];
                    }
                    break;
                    
                default:
                    Console.WriteLine("No option for this input");
                break;                    
            }
        }   
    }
}