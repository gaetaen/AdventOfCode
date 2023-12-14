using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AdventOfCode._2023.Exo_2;

public static class CubeConundrum
{
    public static List<int> Game(int red, int green, int blue, string input)
    {
        string[] GameArray = input.Split("\r\n");
        List<int> possibleGameId = new();

        foreach (var game in GameArray)
        {
            bool isPossible = true;
            string[] GameInfo = game.Split(":");
            if (!int.TryParse(Regex.Replace(GameInfo[0], "[^1-9]", ""), out int id))
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

                    switch (result.Trim().Split(" ")[1])
                    {
                        case "red" when count > red:
                            isPossible = false;
                            break;

                        case "blue" when count > blue:
                            isPossible = false;
                            break;

                        case "green" when count > green:
                            isPossible = false;
                            break;
                    }
                    if (!isPossible) break;
                }
                if (!isPossible) break;
            }
            if (isPossible) possibleGameId.Add(id);
        }

        return possibleGameId;
    }
}