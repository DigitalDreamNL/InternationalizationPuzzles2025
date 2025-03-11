using System.Globalization;
using Shouldly;

namespace InternationalizationPuzzles2025.Test.Puzzles.Puzzle4;

public class Puzzle4Tests
{
    [Fact]
    public void Test()
    {
        var puzzle = new InternationalizationPuzzles2025.Puzzles.Puzzle4.Puzzle4();

        var itinerary = new[]
        {
            "Departure: Europe/London                  Mar 04, 2020, 10:00",
            "Arrival:   Europe/Paris                   Mar 04, 2020, 11:59",
            "",
            "Departure: Europe/Paris                   Mar 05, 2020, 10:42",
            "Arrival:   Australia/Adelaide             Mar 06, 2020, 16:09",
            "",
            "Departure: Australia/Adelaide             Mar 06, 2020, 19:54",
            "Arrival:   America/Argentina/Buenos_Aires Mar 06, 2020, 19:10",
            "",
            "Departure: America/Argentina/Buenos_Aires Mar 07, 2020, 06:06",
            "Arrival:   America/Toronto                Mar 07, 2020, 14:43",
            "",
            "Departure: America/Toronto                Mar 08, 2020, 04:48",
            "Arrival:   Europe/London                  Mar 08, 2020, 16:52"
        };
        puzzle.SetInput(itinerary);

        var solution = puzzle.Execute();

        solution.ShouldBe("3143");
    }

    [Fact]
    public void GivenDifferentLocalDateTimes_CorrectUtcDateTimeIsReturned()
    {
        InternationalizationPuzzles2025.Puzzles.Puzzle4.Puzzle4
            .GetUtcDateTime("Departure: Europe/London                  Mar 04, 2020, 10:00")
            .ShouldBe(DateTime.Parse("2020-03-04T10:00+01:00", CultureInfo.InvariantCulture));

        InternationalizationPuzzles2025.Puzzles.Puzzle4.Puzzle4
            .GetUtcDateTime("Departure: Europe/Paris                   Mar 04, 2020, 10:00")
            .ShouldBe(DateTime.Parse("2020-03-04T09:00+01:00", CultureInfo.InvariantCulture));
    }
}