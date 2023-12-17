using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.AccessControl;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AdventOfCode._2023.Exo_3
{
    public static class GearRatios
    {
        public static int SchematicSum(string input)
        {
            string[] lineArray = input.Split("\r\n");
            char[][] schematic = new char[lineArray.Length][];
            int result = 0;
            List<char> numberList = new();
            bool isAdjacentSymbol = false;

            for (int i = 0; i < lineArray.Length; i++)
            {
                schematic[i] = new char[lineArray[i].Length];

                for (int j = 0; j < lineArray[i].Length; j++)
                {
                    schematic[i][j] = lineArray[i][j];
                }
            }

            for (int i = 0; i < schematic.Length; i++)
            {
                for (int j = 0; j < schematic[i].Length; j++)
                {
                    if (char.IsDigit(schematic[i][j]))
                    {
                        // Horizontal and Vertical Checks:

                        // Check above the current element
                        if (i > 0 && !char.IsDigit(schematic[i - 1][j]) && schematic[i - 1][j] != '.')
                            isAdjacentSymbol = true;

                        // Check below the current element
                        if (i < schematic.Length - 1 && !char.IsDigit(schematic[i + 1][j]) && schematic[i + 1][j] != '.')
                            isAdjacentSymbol = true;

                        // Check to the left of the current element
                        if (j > 0 && !char.IsDigit(schematic[i][j - 1]) && schematic[i][j - 1] != '.')
                            isAdjacentSymbol = true;

                        // Check to the right of the current element
                        if (j < schematic[i].Length - 1 && !char.IsDigit(schematic[i][j + 1]) && schematic[i][j + 1] != '.')
                            isAdjacentSymbol = true;

                        // Diagonal Checks:

                        // Check top-left diagonal
                        if (i > 0 && j > 0 && !char.IsDigit(schematic[i - 1][j - 1]) && schematic[i - 1][j - 1] != '.')
                            isAdjacentSymbol = true;

                        // Check bottom-right diagonal
                        if (i < schematic.Length - 1 && j < schematic[i].Length - 1 && !char.IsDigit(schematic[i + 1][j + 1]) && schematic[i + 1][j + 1] != '.')
                            isAdjacentSymbol = true;

                        // Check top-right diagonal
                        if (i > 0 && j < schematic[i].Length - 1 && !char.IsDigit(schematic[i - 1][j + 1]) && schematic[i - 1][j + 1] != '.')
                            isAdjacentSymbol = true;

                        // Check bottom-left diagonal
                        if (i < schematic.Length - 1 && j > 0 && !char.IsDigit(schematic[i + 1][j - 1]) && schematic[i + 1][j - 1] != '.')
                            isAdjacentSymbol = true;

                        numberList.Add(schematic[i][j]);
                    }
                    else if (isAdjacentSymbol && numberList.Any() && int.TryParse(string.Concat(numberList), out int number))
                    {
                        result += number;
                        isAdjacentSymbol = false;
                        numberList.Clear();
                    }
                    else
                    {
                        numberList.Clear();
                    }
                }
            }

            return result;
        }

        public static int SchematicMultiply(string input)
        {
            string[] lineArray = input.Split("\r\n");
            char[][] schematic = new char[lineArray.Length][];
            int result = 0;
            List<char> numberList = new();
            bool isAsteriskAdjacent = false;
            Dictionary<string, int> asteriskDictionary = new();

            List<string> aaaaa = new();
            for (int i = 0; i < lineArray.Length; i++)
            {
                schematic[i] = new char[lineArray[i].Length];

                for (int j = 0; j < lineArray[i].Length; j++)
                {
                    if ((i == 0 && lineArray[i][j] == '*') || (i == schematic.Length - 1 && lineArray[i][j] == '*') || (j == 0 && lineArray[i][j] == '*') || (j == schematic[i].Length - 1 && lineArray[i][j] == '*'))
                    {
                        schematic[i][j] = '.';
                    }
                    else
                    {
                        schematic[i][j] = lineArray[i][j];
                    }
                }
            }

            for (int i = 0; i < schematic.Length; i++)
            {
                string positionKey = "";

                for (int j = 0; j <= schematic[i].Length; j++)
                {
                    if (j < schematic[i].Length && char.IsDigit(schematic[i][j]))
                    {
                        // Horizontal and Vertical Checks:

                        // Check above the current element
                        if (i > 0 && schematic[i - 1][j] == '*')
                        {
                            isAsteriskAdjacent = true;
                            positionKey = $"i{i - 1}j{j}";
                        }

                        // Check below the current element ***
                        if (i < schematic.Length - 1 && schematic[i + 1][j] == '*')
                        {
                            isAsteriskAdjacent = true;
                            positionKey = $"i{i + 1}j{j}";
                        }

                        // Check to the left of the current element ***
                        if (j > 0 && schematic[i][j - 1] == '*')
                        {
                            isAsteriskAdjacent = true;
                            positionKey = $"i{i}j{j - 1}";
                        }

                        // Check to the right of the current element ***
                        if (j < schematic[i].Length - 1 && schematic[i][j + 1] == '*')
                        {
                            isAsteriskAdjacent = true;
                            positionKey = $"i{i}j{j + 1}";
                        }

                        // Diagonal Checks:

                        // Check top-left diagonal ***
                        if (i > 0 && j > 0 && schematic[i - 1][j - 1] == '*')
                        {
                            isAsteriskAdjacent = true;
                            positionKey = $"i{i - 1}j{j - 1}";
                        }

                        // Check bottom-right diagonal ***
                        if (i < schematic.Length - 1 && j < schematic[i].Length - 1 && schematic[i + 1][j + 1] == '*')
                        {
                            isAsteriskAdjacent = true;
                            positionKey = $"i{i + 1}j{j + 1}";
                        }

                        // Check top-right diagonal ***
                        if (i > 0 && j < schematic[i].Length - 1 && schematic[i - 1][j + 1] == '*')
                        {
                            isAsteriskAdjacent = true;
                            positionKey = $"i{i - 1}j{j + 1}";
                        }

                        // Check bottom-left diagonal ***
                        if (i < schematic.Length - 1 && j > 0 && schematic[i + 1][j - 1] == '*')
                        {
                            isAsteriskAdjacent = true;
                            positionKey = $"i{i + 1}j{j - 1}";
                        }

                        numberList.Add(schematic[i][j]);
                    }
                    else if (isAsteriskAdjacent && numberList.Any() && int.TryParse(string.Concat(numberList), out int number))
                    {
                        if (asteriskDictionary.ContainsKey(positionKey))
                        {
                            asteriskDictionary.TryGetValue(positionKey, out int firstNumber);
                            aaaaa.Add((firstNumber * number).ToString());
                            result += (firstNumber * number);
                        }
                        else
                        {
                            asteriskDictionary.Add(positionKey, number);
                        }
                        isAsteriskAdjacent = false;

                        numberList.Clear();
                    }
                    else
                    {
                        numberList.Clear();
                    }
                }
            }
            return result;
        }
    }
}