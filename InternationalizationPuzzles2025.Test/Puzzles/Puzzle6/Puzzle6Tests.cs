using Shouldly;

namespace InternationalizationPuzzles2025.Test.Puzzles.Puzzle6;

public class Puzzle6Tests
{
    [Fact]
    public void Test()
    {
        var puzzle = new InternationalizationPuzzles2025.Puzzles.Puzzle6.Puzzle6();
    
        var input = new[]
        {
            "geléet",
            "träffs",
            "religiÃ«n",
            "tancées",
            "kÃ¼rst",
            "roekoeÃ«n",
            "skälen",
            "böige",
            "fÃ¤gnar",
            "dardÃ©es",
            "amènent",
            "orquestrÃ¡",
            "imputarão",
            "molières",
            "pugilarÃÂ£o",
            "azeitámos",
            "dagcrème",
            "zÃ¶ger",
            "ondulât",
            "blÃ¶kt",
            "",
            "   ...d...",
            "    ..e.....",
            "     .l...",
            "  ....f.",
            "......t.."
        };
        puzzle.SetInput(input);

        var solution = puzzle.Execute();

        solution.ShouldBe("50");
    }
}