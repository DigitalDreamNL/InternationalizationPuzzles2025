using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace InternationalizationPuzzles2025.Puzzles.Puzzle3;

public partial class Puzzle3 : Puzzle
{
    protected override string FileName => "puzzle3.txt";
    public override string Execute()
    {
        return Input.Count(password =>
            PasswordIsCorrectLength(password) &&
            PasswordContainsUppercase(password) &&
            PasswordContainsLowercase(password) &&
            PasswordContainsDigit(password) &&
            PasswordContainsUnusualCharacter(password))
            .ToString();
    }

    private static bool PasswordIsCorrectLength(string password) =>
        password.Length is >= 4 and <= 12;

    private static bool PasswordContainsUppercase(string password) =>
        AtLeastOneUppercaseRegex().IsMatch(password);

    // Regex Unicode Categories: https://www.regular-expressions.info/unicode.html
    [GeneratedRegex("(\\p{Lu})")]
    private static partial Regex AtLeastOneUppercaseRegex();

    private static bool PasswordContainsLowercase(string password) =>
        AtLeastOneLowercaseRegex().IsMatch(password);

    [GeneratedRegex("(\\p{Ll})")]
    private static partial Regex AtLeastOneLowercaseRegex();

    private static bool PasswordContainsDigit(string password) =>
        AtLeastOneDigit().IsMatch(password);

    [GeneratedRegex("(\\d)")]
    private static partial Regex AtLeastOneDigit();

    private static bool PasswordContainsUnusualCharacter(string password) =>
        !string.Equals(RemoveDiacritics(password), password);


    // Based on https://stackoverflow.com/a/249126
    private static string RemoveDiacritics(string text) 
    {
        var normalizedString = text.Normalize(NormalizationForm.FormD);
        var stringBuilder = new StringBuilder(capacity: normalizedString.Length);

        foreach (var c in normalizedString)
        {
            var unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(c);
            if (unicodeCategory != UnicodeCategory.NonSpacingMark)
            {
                stringBuilder.Append(c);
            }
        }

        return stringBuilder
            .ToString()
            .Normalize(NormalizationForm.FormC);
    }
}