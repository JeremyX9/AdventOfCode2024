namespace AdventOfCode2024;

public class Day01(string filePath) : AdvenfOfCodeDay(filePath)
{
    public override void Part1()
    {
        var leftSide = new List<int>();
        var rightSide = new List<int>();

        foreach (var line in this.Input.Split('\n'))
        {
            var numbers = line.Split("   ");
            leftSide.Add(int.Parse(numbers[0]));
            rightSide.Add(int.Parse(numbers[1]));
        }
        leftSide.Sort();
        rightSide.Sort();
        
        var distance = 0;
        
        for (int i = 0; i < leftSide.Count; i++)
        {
            distance += Math.Abs(leftSide[i] - rightSide[i]);
        }
        
        Console.WriteLine($"The distance is: {distance}");
    }

    public override void Part2()
    {
        var leftSide = new List<int>();
        var rightSide = new List<int>();

        foreach (var line in this.Input.Split('\n'))
        {
            var numbers = line.Split("   ");
            leftSide.Add(int.Parse(numbers[0]));
            rightSide.Add(int.Parse(numbers[1]));
        }
        
        var similarity = 0;
        for (int i = 0; i < leftSide.Count; i++)
        {
            var countRight = rightSide.Count(x => x == leftSide[i]);
            similarity += countRight * leftSide[i];
        }
        Console.WriteLine($"The similarity is: {similarity}");
    }
}