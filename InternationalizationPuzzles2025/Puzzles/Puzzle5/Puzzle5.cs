namespace InternationalizationPuzzles2025.Puzzles.Puzzle5;

public class Puzzle5 : Puzzle
{
    protected override string FileName => "puzzle5.txt";

    private int Width => _width ??= Input[0].Length;
    private int? _width;

    private int _xPosition;
    private int _numberOfPoos;

    public override string Execute()
    {
        foreach (var line in Input)
            HandleLine(line);

        return _numberOfPoos.ToString();
    }

    private void HandleLine(string line)
    {
        if (line[_xPosition] == '\ud83d') // 💩
            _numberOfPoos++;

        _xPosition = CalculateNextXPosition(_xPosition);
    }

    public int CalculateNextXPosition(int x) => (x + 2) % Width;
}