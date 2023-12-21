using AdventOfCode._2023.Day_1;
using AdventOfCode._2023.Day_2;
using AdventOfCode._2023.Day_3;
using AdventOfCode._2023.Day_4;
using System.Diagnostics;

Stopwatch stopwatch = new();

try
{
    string day1Content = File.ReadAllText("2023\\Day-1\\Input.txt");
    string day2Content = File.ReadAllText("2023\\Day-2\\Input.txt");
    string day3Content = File.ReadAllText("2023\\Day-3\\Input.txt");
    string day4Content = File.ReadAllText("2023\\Day-4\\Input.txt");

    // Day 1
    RunDayChallenge("Day 1.1 Trebuchet", () => Trebuchet.Calibration(day1Content, false));
    RunDayChallenge("Day 1.2 Trebuchet", () => Trebuchet.Calibration(day1Content, true));

    // Day 2
    RunDayChallenge("Day 2.1 CubeConundrum", () => CubeConundrum.GamePossibility(12, 13, 14, day2Content));
    RunDayChallenge("Day 2.2 CubeConundrum", () => CubeConundrum.CubePower(day2Content));

    // Day 3
    RunDayChallenge("Day 3.1 Gear Ratios", () => GearRatios.SchematicSum(day3Content));
    RunDayChallenge("Day 3.2 Gear Ratios", () => GearRatios.SchematicMultiply(day3Content));

    // Day 4
    RunDayChallenge("Day 4.1 Scratchcards", () => Scratchcards.CalculatePoints(day4Content));
    RunDayChallenge("Day 4.2 Scratchcards", () => Scratchcards.TotalScratchcards(day4Content));
}
catch (IOException ex)
{
    Console.WriteLine($"An error occurred while reading the file: {ex.Message}");
}

void RunDayChallenge(string challengeName, Func<int> challenge)
{
    stopwatch.Restart();
    int result = challenge();
    stopwatch.Stop();
    Console.WriteLine($"{challengeName} = {result} in {stopwatch.ElapsedMilliseconds}ms");
}