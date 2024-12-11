using System.Text.RegularExpressions;

namespace AdventOfCode2024;

public class Day03(string filePath) : AdvenfOfCodeDay(filePath)
{

    public override void Part1()
    {
        var pattern = @"mul\(\d{1,3},\d{1,3}\)";
        var matches = Regex.Matches(this.Input, pattern);
        var total = 0;
        foreach (Match match in matches)
        {
            var values = match.Value.Replace("mul(", "").Replace(")", "").Split(",");
            total += int.Parse(values[0]) * int.Parse(values[1]);
        }
        Console.WriteLine($"Total part 1: {total}");
    }

    public override void Part2()
    {
        var pattern = @"do\(\)|don't\(\)|mul\(\d{1,3},\d{1,3}\)";
        
        var matches = Regex.Matches(this.Input, pattern);
        
        var total = 0;

        var isDo = true;
        foreach (Match match in matches)
        {
            if (match.Value == "do()")
            {
                isDo = true;
                continue;
            } else 
            if (match.Value == "don't()")
            {
                isDo = false;
                continue;
            }

            if (isDo)
            {
                var values = match.Value.Replace("mul(", "").Replace(")", "").Split(",");
                total += int.Parse(values[0]) * int.Parse(values[1]);   
            }
        }
        
        Console.WriteLine($"Total part 2: {total}");
    }
}