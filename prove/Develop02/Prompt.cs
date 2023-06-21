

public class Prompts
{
    public string _prompt;
    public int _variable;

    public List<string> _promptlist = new List<string>(){"What was a moment that brightened your day?", "How do you show that you care?", "Who is your role model?", "If you could go and vacation where would you go and what would you do?", "Who has been the most influential person in your life?",
    "If you could meet someone for the first time again who would it be?","How would you describe yourself to another person?"};
    
    
    public void generate_random_number()
    {
        Random random = new Random();

         _variable = random.Next(0, _promptlist.Count);

        Console.WriteLine(_promptlist[_variable]);

    }

 
}