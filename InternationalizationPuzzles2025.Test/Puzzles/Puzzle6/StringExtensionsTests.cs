using InternationalizationPuzzles2025.Puzzles.Puzzle6;
using Shouldly;

namespace InternationalizationPuzzles2025.Test.Puzzles.Puzzle6;

public class StringExtensionsTests
{
    [Theory]
    [InlineData(1, "word", "word")]
    [InlineData(3, "religiÃ«n", "religiën")]
    [InlineData(5, "kÃ¼rst", "kürst")]
    [InlineData(15, "pugilarÃÂ£o", "pugilarão")]
    public void TestFixEncoding(int lineNumber, string value, string expected)
    {
        value.FixEncoding(lineNumber).ShouldBe(expected);
    }
}