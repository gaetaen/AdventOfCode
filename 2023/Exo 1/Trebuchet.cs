using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AdventOfCode.Exos;

public static class Trebuchet
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

    private static List<char> ExtractDigits(string input, bool WithWordToNumber)
    {
        if (WithWordToNumber)
        {
            foreach (var mapping in wordToNumber)
            {
                input = input.Replace(mapping.Key, mapping.Key[0] + mapping.Value + mapping.Key[^1]);
            }
        }

        return Regex.Replace(input, "[^1-9]", "").ToList();
    }

    public static int Calibration(string input, bool WithWordToNumber)
    {
        string[] lineArray = input.Split(Environment.NewLine);
        int result = 0;

        foreach (string line in lineArray)
        {
            List<char> onlyDigits = ExtractDigits(line, WithWordToNumber);
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