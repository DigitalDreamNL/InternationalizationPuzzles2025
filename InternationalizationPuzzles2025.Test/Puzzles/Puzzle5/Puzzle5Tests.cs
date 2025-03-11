using Shouldly;

namespace InternationalizationPuzzles2025.Test.Puzzles.Puzzle5;

public class Puzzle5Tests
{
    private readonly string[] _testInput =
    [
        " ⚘   ⚘ ",
        "  ⸫   ⸫",
        "🌲   💩  ",
        "     ⸫⸫",
        " 🐇    💩",
        "⸫    ⸫ ",
        "⚘🌲 ⸫  🌲",
        "⸫    🐕 ",
        "  ⚘  ⸫ ",
        "⚘⸫⸫   ⸫",
        "  ⚘⸫   ",
        " 💩  ⸫  ",
        "     ⸫⸫"
    ];

    [Fact]
    public void Test()
    {
        var puzzle = CreatePuzzleWithDefaultTestInput();
        puzzle.Execute().ShouldBe("2");
    }

    [Fact]
    public void CalculateNextPosition()
    {
        var puzzle = CreatePuzzleWithDefaultTestInput();
        puzzle.CalculateNextXPosition(0).ShouldBe(2);
        puzzle.CalculateNextXPosition(3).ShouldBe(5);
        puzzle.CalculateNextXPosition(6).ShouldBe(1);
    }

    private InternationalizationPuzzles2025.Puzzles.Puzzle5.Puzzle5 CreatePuzzleWithDefaultTestInput()
    {
        var puzzle = new InternationalizationPuzzles2025.Puzzles.Puzzle5.Puzzle5();
        puzzle.SetInput(_testInput);
        return puzzle;
    }
}