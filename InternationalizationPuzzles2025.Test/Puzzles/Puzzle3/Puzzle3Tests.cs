using Shouldly;

namespace InternationalizationPuzzles2025.Test.Puzzles.Puzzle3;

public class Puzzle3Tests
{
    [Fact]
    public void Test()
    {
        ExpectNumberOfValidPasswords([Passwords.ValidExample], "1");
        ExpectNumberOfValidPasswords([Passwords.AnotherValidExample], "1");
        ExpectNumberOfValidPasswords([Passwords.TooShort], "0");
        ExpectNumberOfValidPasswords([Passwords.TooLong], "0");
        ExpectNumberOfValidPasswords([Passwords.NoUppercase], "0");
        ExpectNumberOfValidPasswords([Passwords.NoLowercase], "0");
        ExpectNumberOfValidPasswords([Passwords.NoDigit], "0");
        ExpectNumberOfValidPasswords([Passwords.NoUnusualCharacter], "0");
        ExpectNumberOfValidPasswords([
        Passwords.ValidExample,
        Passwords.AnotherValidExample,
        Passwords.TooShort,
        Passwords.TooLong,
        Passwords.NoUppercase,
        Passwords.NoLowercase,
        Passwords.NoDigit,
        Passwords.NoUnusualCharacter,
        ], "2");
    }

    private static void ExpectNumberOfValidPasswords(string[] passwords, string numberOfValidPasswords)
    {
        var puzzle = new InternationalizationPuzzles2025.Puzzles.Puzzle3.Puzzle3();
        puzzle.SetInput(passwords);

        var solution = puzzle.Execute();

        solution.ShouldBe(numberOfValidPasswords);
    }
}