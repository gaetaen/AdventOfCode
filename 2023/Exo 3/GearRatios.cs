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

            for (int row = 0; row < lineArray.Length; row++)
            {
                schematic[row] = new char[lineArray[row].Length];

                for (int col = 0; col < lineArray[row].Length; col++)
                {
                    schematic[row][col] = lineArray[row][col];
                }
            }

            for (int row = 0; row < schematic.Length; row++)
            {
                for (int col = 0; col < schematic[row].Length; col++)
                {
                    if (char.IsDigit(schematic[row][col]))
                    {
                        // Horizontal and Vertical Checks:

                        // Check above the current element
                        if (row > 0 && !char.IsDigit(schematic[row - 1][col]) && schematic[row - 1][col] != '.')
                            isAdjacentSymbol = true;

                        // Check below the current element
                        if (row < schematic.Length - 1 && !char.IsDigit(schematic[row + 1][col]) && schematic[row + 1][col] != '.')
                            isAdjacentSymbol = true;

                        // Check to the left of the current element
                        if (col > 0 && !char.IsDigit(schematic[row][col - 1]) && schematic[row][col - 1] != '.')
                            isAdjacentSymbol = true;

                        // Check to the right of the current element
                        if (col < schematic[row].Length - 1 && !char.IsDigit(schematic[row][col + 1]) && schematic[row][col + 1] != '.')
                            isAdjacentSymbol = true;

                        // Diagonal Checks:

                        // Check top-left diagonal
                        if (row > 0 && col > 0 && !char.IsDigit(schematic[row - 1][col - 1]) && schematic[row - 1][col - 1] != '.')
                            isAdjacentSymbol = true;

                        // Check bottom-right diagonal
                        if (row < schematic.Length - 1 && col < schematic[row].Length - 1 && !char.IsDigit(schematic[row + 1][col + 1]) && schematic[row + 1][col + 1] != '.')
                            isAdjacentSymbol = true;

                        // Check top-right diagonal
                        if (row > 0 && col < schematic[row].Length - 1 && !char.IsDigit(schematic[row - 1][col + 1]) && schematic[row - 1][col + 1] != '.')
                            isAdjacentSymbol = true;

                        // Check bottom-left diagonal
                        if (row < schematic.Length - 1 && col > 0 && !char.IsDigit(schematic[row + 1][col - 1]) && schematic[row + 1][col - 1] != '.')
                            isAdjacentSymbol = true;

                        numberList.Add(schematic[row][col]);
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
            string[] lineArray = input.Split(Environment.NewLine);
            char[][] schematic = new char[lineArray.Length][];
            int result = 0;
            List<char> numberList = new();
            Dictionary<string, int> asteriskDictionary = new();

            for (int row = 0; row < lineArray.Length; row++)
            {
                schematic[row] = new char[lineArray[row].Length];

                for (int col = 0; col < lineArray[row].Length; col++)
                {
                    if ((row == 0 && lineArray[row][col] == '*') || (row == schematic.Length - 1 && lineArray[row][col] == '*') || (col == 0 && lineArray[row][col] == '*') || (col == schematic[row].Length - 1 && lineArray[row][col] == '*'))
                    {
                        schematic[row][col] = '.';
                    }
                    else
                    {
                        schematic[row][col] = lineArray[row][col];
                    }
                }
            }

            for (int row = 0; row < schematic.Length; row++)
            {
                string positionKey = "";
                bool isAsteriskAdjacent = false;

                for (int col = 0; col <= schematic[row].Length; col++)
                {
                    if (col < schematic[row].Length && char.IsDigit(schematic[row][col]))
                    {
                        // Horizontal and Vertical Checks:

                        // Check above the current element ***
                        if (row > 0 && schematic[row - 1][col] == '*')
                        {
                            isAsteriskAdjacent = true;
                            positionKey = $"row{row - 1},col{col}";
                        }

                        // Check below the current element ***
                        if (row < schematic.Length - 1 && schematic[row + 1][col] == '*')
                        {
                            isAsteriskAdjacent = true;
                            positionKey = $"row{row + 1},col{col}";
                        }

                        // Check to the left of the current element ***
                        if (col > 0 && schematic[row][col - 1] == '*')
                        {
                            isAsteriskAdjacent = true;
                            positionKey = $"row{row},col{col - 1}";
                        }

                        // Check to the right of the current element ***
                        if (col < schematic[row].Length - 1 && schematic[row][col + 1] == '*')
                        {
                            isAsteriskAdjacent = true;
                            positionKey = $"row{row},col{col + 1}";
                        }

                        // Diagonal Checks:

                        // Check top-left diagonal ***
                        if (row > 0 && col > 0 && schematic[row - 1][col - 1] == '*')
                        {
                            isAsteriskAdjacent = true;
                            positionKey = $"row{row - 1},col{col - 1}";
                        }

                        // Check bottom-right diagonal ***
                        if (row < schematic.Length - 1 && col < schematic[row].Length - 1 && schematic[row + 1][col + 1] == '*')
                        {
                            isAsteriskAdjacent = true;
                            positionKey = $"row{row + 1},col{col + 1}";
                        }

                        // Check top-right diagonal ***
                        if (row > 0 && col < schematic[row].Length - 1 && schematic[row - 1][col + 1] == '*')
                        {
                            isAsteriskAdjacent = true;
                            positionKey = $"row{row - 1},col{col + 1}";
                        }

                        // Check bottom-left diagonal ***
                        if (row < schematic.Length - 1 && col > 0 && schematic[row + 1][col - 1] == '*')
                        {
                            isAsteriskAdjacent = true;
                            positionKey = $"row{row + 1},col{col - 1}";
                        }

                        numberList.Add(schematic[row][col]);
                    }
                    else if (isAsteriskAdjacent && numberList.Any() && int.TryParse(string.Concat(numberList), out int number))
                    {
                        if (asteriskDictionary.ContainsKey(positionKey))
                        {
                            asteriskDictionary.TryGetValue(positionKey, out int firstNumber);
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