using AdventOfCode._2023.Day_1;
using AdventOfCode._2023.Day_2;
using AdventOfCode._2023.Day_3;
using AdventOfCode._2023.Day_4;
using System.Diagnostics;

Stopwatch stopwatch = new();

try
{
    string day1Input = File.ReadAllText("2023\\Day-1\\Input.txt");
    string day2Input = File.ReadAllText("2023\\Day-2\\Input.txt");
    string day3Input = File.ReadAllText("2023\\Day-3\\Input.txt");
    string day4Input = File.ReadAllText("2023\\Day-4\\Input.txt");

    // Day 1
    RunDailyChallenge("Day 1.1 Trebuchet", () => Trebuchet.Calibration(day1Input, false));
    RunDailyChallenge("Day 1.2 Trebuchet", () => Trebuchet.Calibration(day1Input, true));

    // Day 2
    RunDailyChallenge("Day 2.1 CubeConundrum", () => CubeConundrum.GamePossibility(12, 13, 14, day2Input));
    RunDailyChallenge("Day 2.2 CubeConundrum", () => CubeConundrum.CubePower(day2Input));

    // Day 3
    RunDailyChallenge("Day 3.1 Gear Ratios", () => GearRatios.SchematicSum(day3Input));
    RunDailyChallenge("Day 3.2 Gear Ratios", () => GearRatios.SchematicMultiply(day3Input));

    // Day 4
    RunDailyChallenge("Day 4.1 Scratchcards", () => Scratchcards.CalculatePoints(day4Input));
    RunDailyChallenge("Day 4.2 Scratchcards", () => Scratchcards.TotalScratchcards(day4Input));
}
catch (IOException ex)
{
    Console.WriteLine($"An error occurred while reading the file: {ex.Message}");
}

void RunDailyChallenge(string challengeName, Func<int> challenge)
{
    stopwatch.Restart();
    int result = challenge();
    stopwatch.Stop();
    Console.WriteLine($"{challengeName} = {result} in {stopwatch.ElapsedMilliseconds}ms");
}