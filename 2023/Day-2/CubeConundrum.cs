using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AdventOfCode._2023.Day_2;

public static class CubeConundrum
{
    public static int GamePossibility(int red, int green, int blue, string input)
    {
        string[] GameArray = input.Split(Environment.NewLine);
        int possibleGameCount = 0;

        foreach (var game in GameArray)
        {
            bool isPossible = true;
            string[] GameInfo = game.Split(":");
            if (!int.TryParse(Regex.Replace(GameInfo[0], "[^0-9]", ""), out int id))
            {
                Console.WriteLine("Unable to parse the number.");
                continue;
            }

            foreach (var rounde in GameInfo[^1].Split(";"))
            {
                foreach (var result in rounde.Split(","))
                {
                    if (!int.TryParse(result.Trim().Split(" ")[0], out int count))
                    {
                        Console.WriteLine("Unable to parse the number.");
                        continue;
                    }

                    switch (result.Trim().Split(" ")[^1])
                    {
                        case "red" when count > red:
                        case "blue" when count > blue:
                        case "green" when count > green:
                            isPossible = false;
                            break;
                    }

                    if (!isPossible) break;
                }
                if (!isPossible) break;
            }
            if (isPossible) possibleGameCount += id;
        }

        return possibleGameCount;
    }

    public static int CubePower(string input)
    {
        string[] GameArray = input.Split(Environment.NewLine);
        int cubesPowerCount = 0;

        foreach (var game in GameArray)
        {
            string[] GameInfo = game.Split(":");
            int highestRed = 0;
            int highestGreen = 0;
            int highestBlue = 0;

            foreach (var rounde in GameInfo[^1].Split(";"))
            {
                foreach (var result in rounde.Split(","))
                {
                    if (!int.TryParse(result.Trim().Split(" ")[0], out int count))
                    {
                        Console.WriteLine("Unable to parse the number.");
                        continue;
                    }

                    switch (result.Trim().Split(" ")[^1])
                    {
                        case "red" when count > highestRed:
                            highestRed = count;
                            break;

                        case "blue" when count > highestBlue:
                            highestBlue = count;
                            break;

                        case "green" when count > highestGreen:
                            highestGreen = count;
                            break;
                    }
                }
            }
            cubesPowerCount += (highestRed * highestGreen * highestBlue);
        }

        return cubesPowerCount;
    }
}