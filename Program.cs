using AdventOfCode._2023.Exo_2;
using AdventOfCode.Exos;

// Exo 1.1 Trebuchet
try
{
    string fileContent = File.ReadAllText("2023\\Exo 1\\Input.txt");

    int result = Trebuchet.Calibration(fileContent, false);
    Console.WriteLine($"Exo 1.1 Trebuchet = {result}");
}
catch (IOException ex)
{
    Console.WriteLine($"An error occurred while reading the file: {ex.Message}");
}
// Exo 1.2 Trebuchet
try
{
    string fileContent = File.ReadAllText("2023\\Exo 1\\Input.txt");

    int result = Trebuchet.Calibration(fileContent, true);
    Console.WriteLine($"Exo 1.2 Trebuchet = {result}");
}
catch (IOException ex)
{
    Console.WriteLine($"An error occurred while reading the file: {ex.Message}");
}
// Exo 2.1 CubeConundrum
try
{
    string fileContent = File.ReadAllText("2023\\Exo 2\\Input.txt");
    int result = CubeConundrum.GamePossibility(12, 13, 14, fileContent);
    Console.WriteLine($"Exo 2.1 CubeConundrum = {result}");
}
catch (IOException ex)
{
    Console.WriteLine($"An error occurred while reading the file: {ex.Message}");
}
// Exo 2.2 CubeConundrum
try
{
    string fileContent = File.ReadAllText("2023\\Exo 2\\Input.txt");
    int result = CubeConundrum.CubePower(fileContent);
    Console.WriteLine($"Exo 2.1 CubeConundrum = {result}");
}
catch (IOException ex)
{
    Console.WriteLine($"An error occurred while reading the file: {ex.Message}");
}