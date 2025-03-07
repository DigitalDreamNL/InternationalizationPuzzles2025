using Shouldly;

namespace InternationalizationPuzzles2025.Test.Puzzles.Puzzle1;

public class Puzzle1Tests
{
    [Fact]
    public void GivenValidAndInvalidSmsAndTweetMessages_ExpectedCostsCalculatedCorrectly()
    {
        ExpectCostsForMessages([Messages.InvalidSmsAndTweetMessage], "0");
        ExpectCostsForMessages([Messages.ValidSmsMessage], "11");
        ExpectCostsForMessages([Messages.ValidTweetMessage], "7");
        ExpectCostsForMessages([Messages.ValidSmsAndTweetMessage], "13");
        ExpectCostsForMessages([
            Messages.InvalidSmsAndTweetMessage,
            Messages.ValidSmsMessage,
            Messages.ValidTweetMessage,
            Messages.ValidSmsAndTweetMessage], "31");
    }

    private static void ExpectCostsForMessages(string[] messages, string costs)
    {
        var puzzle = new InternationalizationPuzzles2025.Puzzles.Puzzle1.Puzzle1();
        puzzle.SetInput(messages);

        var solution = puzzle.Execute();

        solution.ShouldBe(costs);
    }
}