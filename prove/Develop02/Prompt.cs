

public class Prompts
{
    public string _prompt;
    public int _variable;

    public List<string> _promptlist = new List<string>(){"Prompt1", "Prompt2", "Prompt3", "Prompt4"};
    
    
    public void generate_random_number()
    {
        Random random = new Random();

         _variable = random.Next(0, _promptlist.Count);

        Console.WriteLine(_promptlist[_variable]);

    }

 
}