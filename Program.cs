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
//// Day 4.2 Scratchcards
//try
//{
//    string fileContent = File.ReadAllText("2023\\Day-4\\Input.txt");
//    stopwatch.Restart();
//    int result = Scratchcards.TotalScratchcards(fileContent);
//    stopwatch.Stop();
//    Console.WriteLine($"Day 4.2 Scratchcards  = {result} in {stopwatch.ElapsedMilliseconds}ms");
//}
//catch (IOException ex)
//{
//    Console.WriteLine($"An error occurred while reading the file: {ex.Message}");
//}