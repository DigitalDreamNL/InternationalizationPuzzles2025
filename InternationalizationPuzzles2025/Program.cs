using InternationalizationPuzzles2025.Puzzles;
using InternationalizationPuzzles2025.Puzzles.Puzzle1;
using InternationalizationPuzzles2025.Puzzles.Puzzle2;
using Spectre.Console;

Console.WriteLine("Internationalization Puzzles 2025");

var puzzles = new Dictionary<string, Type>
{
    { nameof(Puzzle1), typeof(Puzzle1) },
    { nameof(Puzzle2), typeof(Puzzle2) },
};

var selectedPuzzleName = AnsiConsole.Prompt(
    new SelectionPrompt<string>()
        .Title("Which puzzle would you like to solve?")
        .AddChoices(puzzles.Keys));

var puzzle = (Puzzle) Activator.CreateInstance(puzzles[selectedPuzzleName])!;

var solution = puzzle.Execute();

Console.WriteLine("Solution for {0}: {1}", selectedPuzzleName, solution);