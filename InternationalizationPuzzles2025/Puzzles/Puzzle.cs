namespace InternationalizationPuzzles2025.Puzzles;

public abstract class Puzzle
{
    protected abstract string FileName { get; }

    private string[]? _input;

    protected string[] Input => _input ??= File.ReadAllLines(Path.Combine("Inputs", FileName));

    public void SetInput(string[] input) => _input = input;

    public abstract string Execute();
}