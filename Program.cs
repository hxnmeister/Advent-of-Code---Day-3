using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace Advent_of_Code___Day_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string REGEX_FIND_MULT = @"mul\(\d+,\d+\)";
            const string INPUT_PATH = @"G:\Visual Studio Projects\Advent of Code - Day 3\input.txt";

            int sum = 0;
            Regex multRegex = new Regex(REGEX_FIND_MULT);
            string fileData = File.ReadAllText(INPUT_PATH);

            foreach (Match match in multRegex.Matches(fileData))
            {
                string[] operands = match.Value.Split([ '(', ',', ')' ], StringSplitOptions.RemoveEmptyEntries);

                sum += Int32.Parse(operands[1]) * Int32.Parse(operands[2]);
            }

            Console.WriteLine(sum);
        }
    }
}
