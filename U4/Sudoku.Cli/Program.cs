using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Sudoku.Cli
{
    static class Program
    {
        static void Main(string[] args)
        {
            var unsolved = JsonConvert.DeserializeObject<List<List<int>>>(Sample.exampleJson);
            //var unsolved = JsonConvert.DeserializeObject<List<List<int>>>(Sample.testExampleJson);
            var solved = JsonConvert.DeserializeObject<List<List<int>>>(Sample.solutionJson);

            var errorCount = 0; //Variable zum Zählen der Fehler
            do
            {
                Console.Clear();
                Console.WriteLine(unsolved.ToFormattedSudoku());
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Enter your next change using the following format: <row>,<column>:<number>");
                var input = Console.ReadLine();

                if (TryGetInputValues(input, out var row, out var column, out var number)) //Format des Inputs überprüfen
                {
                    if (unsolved[row][column] != 0) //damit bereits richtige Felder ignoriert werden
                    {
                        Console.WriteLine("This field already has the correct number.");
                    }
                    else if (solved[row][column] == number) //wenn eingegebenes Feld in Lösung gleichen Wert hat, wird Wert ins Sudoku übernommen
                    {
                        unsolved[row][column] = number;
                        Console.WriteLine("Correct!");
                    }
                    else 
                    {
                        Console.WriteLine("Wrong!");
                        errorCount++;
                    }
                }
                else 
                {
                    Console.WriteLine("Error: Input did not match required format.");
                }

                Task.Factory.StartNew(() => Console.ReadKey()).Wait(TimeSpan.FromSeconds(2)); //wartet 2s oder bis Taste edrückt wird
            }
            while (!unsolved.IsSolved(solved)); //Schleife iteriert bis Sudoku und Lösung gleich sind

            Console.WriteLine($"Congratulations: You solved the Sudoku. ({errorCount} wrong guesses)");
            Console.ReadLine();
        }

        /// <summary>
        /// Methode um User Input auf gültiges Format zu prüfen und ggf. Werte aus input zu parsen
        /// </summary>
        /// <param name="input"></param>
        /// <param name="row"></param>
        /// <param name="column"></param>
        /// <param name="number"></param>
        /// <returns>true wenn Input gültiges Format hat, false wenn nicht</returns>
        static bool TryGetInputValues(string input, out int row, out int column, out int number) 
        {
            input.Trim();

            row = 0;
            column = 0;
            number = 0;

            var isFormatValid = input.Length == 5
                && input[1] == ','
                && input[3] == ':'
                && char.IsDigit(input[0])
                && char.IsDigit(input[2])
                && char.IsDigit(input[4])
                && input[0] != '0'
                && input[2] != '0'
                && input[4] != '0';
            
            if (isFormatValid) 
            {
                row = int.Parse(input.Substring(0, 1)) - 1;
                column = int.Parse(input.Substring(2,1)) - 1;
                number = int.Parse(input.Substring(4,1));
            }
            return isFormatValid;
        }

        /// <summary>
        /// formatiert 2D-Liste zu Sudoku
        /// </summary>
        /// <param name="sudoku"></param>
        /// <returns></returns>
        static string ToFormattedSudoku(this List<List<int>> sudoku) 
        {
            var output = new StringBuilder().AppendLine("    1  2  3   4  5  6   7  8  9").AppendLine();
            var rowGroups = sudoku.ChunkBy(3);
            var lastRowGroup = rowGroups.Last();
            var i = 1;
            foreach (var rowGroup in rowGroups) 
            { 
                foreach(var row in rowGroup) 
                {
                    var numGroups = row.ChunkBy(3);
                    output.AppendLine($"{i}   {string.Join(" | ", numGroups.Select(q => string.Join("  ", q.Select(n => n == 0 ? "_" : $"{n}"))))}");
                    i++;
                }

                if (rowGroup != lastRowGroup)
                    output.AppendLine("    ---------------------------");
            }
            return output.ToString();
        }

        /// <summary>
        /// teilt Liste in mehrere Teile mit bestimmter Größe
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <param name="chunkSize"></param>
        /// <returns></returns>
        static List<List<T>> ChunkBy<T>(this List<T> source, int chunkSize) => source
                .Select((x, i) => new { Index = i, Value = x })
                .GroupBy(x => x.Index / chunkSize)
                .Select(x => x.Select(v => v.Value).ToList())
                .ToList();

        /// <summary>
        /// vergleicht alle Felder des Sudokus mit der Lösung
        /// </summary>
        /// <param name="sudoku"></param>
        /// <param name="solution"></param>
        /// <returns></returns>
        static bool IsSolved(this List<List<int>> sudoku, List<List<int>> solution) 
        { 
            for (var i = 0; i < 9; i++) 
            {
                var sudokuRow = sudoku[i];
                var solutionRow = solution[i];
                if (!sudokuRow.SequenceEqual(solutionRow))
                    return false;
            }
            return true;
        }
    }
}