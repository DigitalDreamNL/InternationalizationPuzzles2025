namespace InternationalizationPuzzles2025.Puzzles.Puzzle6;

public class Puzzle6 : Puzzle
{
    protected override string FileName => "puzzle6.txt";
    
    private bool _currentLineIsDictionary = true;
    private readonly Dictionary<int, string> _words = new();

    private int _solution;

    public override string Execute()
    {
        for (var i = 0; i < Input.Length; i++)
            ParseLine(i, Input[i]);

        return _solution.ToString();
    }

    private void ParseLine(int i, string line)
    {
        if (line == "")
        {
            _currentLineIsDictionary = false;
            return;
        }

        if (_currentLineIsDictionary)
            ParseLineAsDictionary(i, line);
        else
            ParseLineAsPuzzle(line);
            
    }

    private void ParseLineAsDictionary(int lineNumber, string line)
    {
        _words[lineNumber + 1] = line.FixEncoding(lineNumber + 1);
    }

    private void ParseLineAsPuzzle(string line)
    {
        var wordLength = 0;
        var characterPosition = 0;
        var character = ' ';

        foreach (var c in line)
        {
            if (c == ' ') // Ignore leading spaces
                continue;

            wordLength++;

            if (c == '.')
                continue;

            characterPosition = wordLength - 1;
            character = c;
        }

        var word = _words.Single(w =>
            w.Value.Length == wordLength &&
            w.Value[characterPosition] == character);

        _solution += word.Key;
    }
}