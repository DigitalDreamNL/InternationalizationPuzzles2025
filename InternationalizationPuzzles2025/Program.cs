using InternationalizationPuzzles2025.Puzzles;
using InternationalizationPuzzles2025.Puzzles.Puzzle1;
using InternationalizationPuzzles2025.Puzzles.Puzzle2;
using InternationalizationPuzzles2025.Puzzles.Puzzle3;
using InternationalizationPuzzles2025.Puzzles.Puzzle4;
using InternationalizationPuzzles2025.Puzzles.Puzzle5;
using InternationalizationPuzzles2025.Puzzles.Puzzle6;
using Spectre.Console;

Console.WriteLine("Internationalization Puzzles 2025");

var puzzles = new Dictionary<string, Type>
{
    { nameof(Puzzle1), typeof(Puzzle1) },
    { nameof(Puzzle2), typeof(Puzzle2) },
    { nameof(Puzzle3), typeof(Puzzle3) },
    { nameof(Puzzle4), typeof(Puzzle4) },
    { nameof(Puzzle5), typeof(Puzzle5) },
    { nameof(Puzzle6), typeof(Puzzle6) },
};

var selectedPuzzleName = AnsiConsole.Prompt(
    new SelectionPrompt<string>()
        .Title("Which puzzle would you like to solve?")
        .AddChoices(puzzles.Keys));

var puzzle = (Puzzle) Activator.CreateInstance(puzzles[selectedPuzzleName])!;

var solution = puzzle.Execute();

Console.WriteLine("Solution for {0}: {1}", selectedPuzzleName, solution);