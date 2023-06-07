public class Math : Assignment
{
    public int _chapter;
    public int _homeProblemsStart;
    public int _homeProblemsEnd;
    public int _section;
    

    public Math (string studentName, string topic, int chapter, int section, int homeProblemsStart, int homeProblemsEnd): base (studentName, topic)
    {
        _chapter = chapter;
        _homeProblemsStart = homeProblemsStart; 
        _homeProblemsEnd = homeProblemsEnd;
        _section = section; 
    }
public string displayparts()
{
    return $"Chapter:{_chapter}, Section:{_section}, Problem set start:{_homeProblemsStart}, Problem set end:{_homeProblemsEnd}";
}

}