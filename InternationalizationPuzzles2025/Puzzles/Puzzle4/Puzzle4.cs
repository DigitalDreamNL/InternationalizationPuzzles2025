using System.Globalization;

namespace InternationalizationPuzzles2025.Puzzles.Puzzle4;

public class Puzzle4 : Puzzle
{
    protected override string FileName => "puzzle4.txt";

    private const string DateTimeFormat = "MMM dd, yyyy, HH:mm";
    private DateTime _lastDepartureTime;
    private double _travelTime;


    public override string Execute()
    {
        foreach (var line in Input)
            ParseLine(line);

        return Convert.ToInt32(Math.Round(_travelTime)).ToString();
    }

    private void ParseLine(string line)
    {
        if (line.Length == 0) // Ignore empty lines
            return;

        if (line[..1] == "D") // "Departure ..."
            _lastDepartureTime = GetUtcDateTime(line);
        else if (line[..1] == "A") // "Arrival ..."
            _travelTime += GetUtcDateTime(line).Subtract(_lastDepartureTime).TotalMinutes;
    }

    public static DateTime GetUtcDateTime(string line)
    {
        var timeZone = DetermineTimezone(line);
        var localDateTime = ExtractLocalDateTime(line);
        return TimeZoneInfo.ConvertTimeToUtc(localDateTime, timeZone);
    }

    private static TimeZoneInfo DetermineTimezone(string line)
    {
        var location = line.Substring(11, 30).TrimEnd();
        TimeZoneInfo.TryConvertIanaIdToWindowsId(location, out var timeZoneId);
        return TimeZoneInfo.FindSystemTimeZoneById(timeZoneId);
    }

    private static DateTime ExtractLocalDateTime(string line)
    {
        var dateTimeString = line.Substring(42, 19).TrimEnd();
        return DateTime.ParseExact(dateTimeString, DateTimeFormat, CultureInfo.InvariantCulture);
    }
}