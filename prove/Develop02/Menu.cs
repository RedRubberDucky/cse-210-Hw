public class Menu
{
    private Journal _journal;

    public Menu(Journal journal)
    {
        _journal = journal;
    }

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
                    Console.Write("Write a new Entry:");
                    break;
                case "D":       //Display the journal entry that was written
                    break;
                case "S":       //Save the journal
                    break;
                case "L":       //Load a journal from a file

                default:
                    Console.WriteLine("No option for this input");
                    break;
            }
        }   
    }
}