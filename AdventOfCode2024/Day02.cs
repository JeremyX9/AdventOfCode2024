namespace AdventOfCode2024;

public class Day02(string filePath) : AdvenfOfCodeDay(filePath)
{
    public override void Part1()
    {
        var safeReports = 0;
        foreach (var line in this.Input.Split('\n'))
        {
            var reports = new List<int>();
            foreach (var report in line.Replace("\r", "").Split(" "))
            {
                reports.Add(Int32.Parse(report));
            }
            if (IsSafeReport(reports)) safeReports++;
        }
        Console.WriteLine(safeReports);
    }

    public override void Part2()
    {
        var safeReports = 0;
        foreach (var line in this.Input.Split('\n'))
        {
            var reports = new List<int>();
            foreach (var report in line.Replace("\r", "").Split(" "))
            {
                reports.Add(Int32.Parse(report));
            }

            if (IsSafeReport(reports))
            {
                safeReports++;
                continue;
            }

            bool madeSafeByRemoval = false;
            for (int i = 0; i < reports.Count; i++)
            {
                var modified = new List<int>(reports);
                modified.RemoveAt(i);

                if (IsSafeReport(modified))
                {
                    madeSafeByRemoval = true;
                    break;
                }
            }

            if (madeSafeByRemoval) safeReports++;
        }

        Console.WriteLine(safeReports);
    }
    
    private bool IsSafeReport(List<int> reports)
    {

        bool isUp;
        if (reports[0] < reports[1]) isUp = true;
        else if (reports[0] > reports[1]) isUp = false;
        else return false;

        for (int i = 1; i < reports.Count; i++)
        {
            int diff = reports[i] - reports[i - 1];
            if (diff == 0 || Math.Abs(diff) > 3) return false;
            if (isUp && reports[i] <= reports[i - 1]) return false;
            if (!isUp && reports[i] >= reports[i - 1]) return false;
        }

        return true;
    }
}