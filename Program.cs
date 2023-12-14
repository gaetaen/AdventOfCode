using AdventOfCode._2023.Exo_2;
using AdventOfCode.Exos;
using System.Diagnostics;

Stopwatch stopwatch = new();

// Exo 1.1 Trebuchet
try
{
    string fileContent = File.ReadAllText("2023\\Exo 1\\Input.txt");
    stopwatch.Restart();
    int result = Trebuchet.Calibration(fileContent, false);
    stopwatch.Stop();
    Console.WriteLine($"Exo 1.1 Trebuchet = {result} in {stopwatch.ElapsedMilliseconds}ms");
}
catch (IOException ex)
{
    Console.WriteLine($"An error occurred while reading the file: {ex.Message}");
}
// Exo 1.2 Trebuchet
try
{
    string fileContent = File.ReadAllText("2023\\Exo 1\\Input.txt");
    stopwatch.Restart();
    int result = Trebuchet.Calibration(fileContent, true);
    stopwatch.Stop();
    Console.WriteLine($"Exo 1.2 Trebuchet = {result} in {stopwatch.ElapsedMilliseconds}ms");
}
catch (IOException ex)
{
    Console.WriteLine($"An error occurred while reading the file: {ex.Message}");
}
// Exo 2.1 CubeConundrum
try
{
    string fileContent = File.ReadAllText("2023\\Exo 2\\Input.txt");
    stopwatch.Restart();
    int result = CubeConundrum.GamePossibility(12, 13, 14, fileContent);
    stopwatch.Stop();
    Console.WriteLine($"Exo 2.1 CubeConundrum = {result} in {stopwatch.ElapsedMilliseconds}ms");
}
catch (IOException ex)
{
    Console.WriteLine($"An error occurred while reading the file: {ex.Message}");
}
// Exo 2.2 CubeConundrum
try
{
    string fileContent = File.ReadAllText("2023\\Exo 2\\Input.txt");
    stopwatch.Restart();
    int result = CubeConundrum.CubePower(fileContent);
    stopwatch.Stop();
    Console.WriteLine($"Exo 2.2 CubeConundrum = {result} in {stopwatch.ElapsedMilliseconds}ms");
}
catch (IOException ex)
{
    Console.WriteLine($"An error occurred while reading the file: {ex.Message}");
}