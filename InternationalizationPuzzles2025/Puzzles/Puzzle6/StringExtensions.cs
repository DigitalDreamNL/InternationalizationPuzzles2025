using System.Text;

namespace InternationalizationPuzzles2025.Puzzles.Puzzle6;

public static class StringExtensions
{
    public static string FixEncoding(this string word, int lineNumber)
    {
        var fixedWord = word;

        if (lineNumber % 3 == 0)
            fixedWord = LatinToUtf(fixedWord);

        if (lineNumber % 5 == 0)
            fixedWord = LatinToUtf(fixedWord);

        return fixedWord;
    }

    private static string LatinToUtf(string word)
    {
        var bytes = Encoding.Latin1.GetBytes(word);
        var chars = Encoding.UTF8.GetChars(bytes);
        return new string(chars);
    }
}