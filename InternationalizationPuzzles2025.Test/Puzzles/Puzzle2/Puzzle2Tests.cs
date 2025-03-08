using Shouldly;

namespace InternationalizationPuzzles2025.Test.Puzzles.Puzzle2;

public class Puzzle2Tests
{
    [Fact]
    public void Test()
    {
        var times = new[]
        {
            "2019-06-05T08:15:00-04:00",
            "2019-06-05T14:15:00+02:00",
            "2019-06-05T17:45:00+05:30",
            "2019-06-05T05:15:00-07:00",
            "2011-02-01T09:15:00-03:00",
            "2011-02-01T09:15:00-05:00"
        };

        var puzzle = new InternationalizationPuzzles2025.Puzzles.Puzzle2.Puzzle2();
        puzzle.SetInput(times);

        var solution = puzzle.Execute();

        solution.ShouldBe("2019-06-05T12:15:00+00:00");
    }
}