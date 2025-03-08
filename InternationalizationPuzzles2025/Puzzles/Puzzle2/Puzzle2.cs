using System.Globalization;

namespace InternationalizationPuzzles2025.Puzzles.Puzzle2;

public class Puzzle2 : Puzzle
{
    protected override string FileName => "puzzle2.txt";
    public override string Execute()
    {
        var recordings = new Dictionary<string, int>();

        foreach (var recording in Input)
        {
            var formattedTime = DateTime.Parse(recording).ToUniversalTime().ToString("s", CultureInfo.InvariantCulture);
            recordings.TryAdd(formattedTime, 0);
            recordings[formattedTime]++;
        }

        var eventTime = recordings.Single(time => time.Value >= 4);

        return $"{eventTime.Key}+00:00";
    }
}