using AdventOfCode._2023.Day_1;
using AdventOfCode._2023.Day_2;
using AdventOfCode._2023.Day_3;
using AdventOfCode._2023.Day_4;
using System.Diagnostics;

Stopwatch stopwatch = new();

//// Day 1.1 Trebuchet
//try
//{
//    string fileContent = File.ReadAllText("2023\\Day-1\\Input.txt");
//    stopwatch.Restart();
//    int result = Trebuchet.Calibration(fileContent, false);
//    stopwatch.Stop();
//    Console.WriteLine($"Day 1.1 Trebuchet = {result} in {stopwatch.ElapsedMilliseconds}ms");
//}
//catch (IOException ex)
//{
//    Console.WriteLine($"An error occurred while reading the file: {ex.Message}");
//}
//// Day 1.2 Trebuchet
//try
//{
//    string fileContent = File.ReadAllText("2023\\Day-1\\Input.txt");
//    stopwatch.Restart();
//    int result = Trebuchet.Calibration(fileContent, true);
//    stopwatch.Stop();
//    Console.WriteLine($"Day 1.2 Trebuchet = {result} in {stopwatch.ElapsedMilliseconds}ms");
//}
//catch (IOException ex)
//{
//    Console.WriteLine($"An error occurred while reading the file: {ex.Message}");
//}
//// Day 2.1 CubeConundrum
//try
//{
//    string fileContent = File.ReadAllText("2023\\Day-2\\Input.txt");
//    stopwatch.Restart();
//    int result = CubeConundrum.GamePossibility(12, 13, 14, fileContent);
//    stopwatch.Stop();
//    Console.WriteLine($"Day 2.1 CubeConundrum = {result} in {stopwatch.ElapsedMilliseconds}ms");
//}
//catch (IOException ex)
//{
//    Console.WriteLine($"An error occurred while reading the file: {ex.Message}");
//}
//// Day 2.2 CubeConundrum
//try
//{
//    string fileContent = File.ReadAllText("2023\\Day-2\\Input.txt");
//    stopwatch.Restart();
//    int result = CubeConundrum.CubePower(fileContent);
//    stopwatch.Stop();
//    Console.WriteLine($"Day 2.2 CubeConundrum = {result} in {stopwatch.ElapsedMilliseconds}ms");
//}
//catch (IOException ex)
//{
//    Console.WriteLine($"An error occurred while reading the file: {ex.Message}");
//}
////Day 3.1 Gear Ratios
//try
//{
//    string fileContent = File.ReadAllText("2023\\Day-3\\Input.txt");
//    stopwatch.Restart();
//    int result = GearRatios.SchematicSum(fileContent);
//    stopwatch.Stop();
//    Console.WriteLine($"Day 3.1 Gear Ratios = {result} in {stopwatch.ElapsedMilliseconds}ms");
//}
//catch (IOException ex)
//{
//    Console.WriteLine($"An error occurred while reading the file: {ex.Message}");
//}
//// Day 3.2 Gear Ratios
//try
//{
//    string fileContent = File.ReadAllText("2023\\Day-3\\Input.txt");
//    stopwatch.Restart();
//    int result = GearRatios.SchematicMultiply(fileContent);
//    stopwatch.Stop();
//    Console.WriteLine($"Day 3.2 Gear Ratios = {result} in {stopwatch.ElapsedMilliseconds}ms");
//}
//catch (IOException ex)
//{
//    Console.WriteLine($"An error occurred while reading the file: {ex.Message}");
//}
//// Day 4.1 Scratchcards
//try
//{
//    string fileContent = File.ReadAllText("2023\\Day-4\\Input.txt");
//    stopwatch.Restart();
//    int result = Scratchcards.CalculatePoints(fileContent);
//    stopwatch.Stop();
//    Console.WriteLine($"Day 4.1 Scratchcards  = {result} in {stopwatch.ElapsedMilliseconds}ms");
//}
//catch (IOException ex)
//{
//    Console.WriteLine($"An error occurred while reading the file: {ex.Message}");
//}
// Day 4.2 Scratchcards
try
{
    string fileContent = File.ReadAllText("2023\\Day-4\\Input.txt");
    stopwatch.Restart();
    //int result = Scratchcards.TotalScratchcards(fileContent);
    int result = Scratchcards.TotalScratchcards("Card 1: 41 48 83 86 17 | 83 86  6 31 17  9 48 53\r\nCard 2: 13 32 20 16 61 | 61 30 68 82 17 32 24 19\r\nCard 3:  1 21 53 59 44 | 69 82 63 72 16 21 14  1\r\nCard 4: 41 92 73 84 69 | 59 84 76 51 58  5 54 83\r\nCard 5: 87 83 26 28 32 | 88 30 70 12 93 22 82 36\r\nCard 6: 31 18 13 56 72 | 74 77 10 23 35 67 36 11");
    stopwatch.Stop();
    Console.WriteLine($"Day 4.2 Scratchcards  = {result} in {stopwatch.ElapsedMilliseconds}ms");
}
catch (IOException ex)
{
    Console.WriteLine($"An error occurred while reading the file: {ex.Message}");
}