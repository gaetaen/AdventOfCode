using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
namespace AdventOfCode.Exos;

public static class Exo1
{
    private static readonly Dictionary<string, string> wordToNumber = new()
    {
        {"one", "1"},
        {"two", "2"},
        {"three", "3"},
        {"four", "4"},
        {"five", "5"},
        {"six", "6"},
        {"seven", "7"},
        {"eight", "8"},
        {"nine", "9"}
    };

    private static List<char> ExtractDigits(string input)
    {
        foreach (var mapping in wordToNumber)
        {
            input = input.Replace(mapping.Key, mapping.Key[0] + mapping.Value + mapping.Key[mapping.Key.Count() - 1]);
        }

        return Regex.Replace(input, "[^0-9]", "").ToList();
    }

    public static int Calibration(string input)
    {
        string[] lineArray = input.Split("\r\n");
        int result = 0;

        foreach (string line in lineArray)
        {
            List<char> onlyDigits = ExtractDigits(line);
            string number = string.Concat(onlyDigits[0], onlyDigits[^1]);

            if (!int.TryParse(number, out int num))
            {
                Console.WriteLine("Unable to parse the number.");
                continue;
            }

            result += num;
        }
        return result;
    }
}

