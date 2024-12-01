namespace AdventOfCode2024;

public abstract class AdvenfOfCodeDay
{
    protected string Input { get; set; }
    
    public abstract void Part1();
    public abstract void Part2();
    
    public AdvenfOfCodeDay(string filePath)
    {
        Input = File.ReadAllText(filePath);
    }
    public void Run()
    {
        Part1();
        Part2();
    }
    
}