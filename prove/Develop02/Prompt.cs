public class Prompts
{
    public string _prompt;

    public Prompts (string prompt)
    {
        _prompt = prompt;
    }

    public string displaypieces()
    {
        return $"Prompt:{_prompt}";
    }
}