using AdventOfCode.Exos;

// Exo 1 Trebuchet
try
{
    string fileContent = File.ReadAllText("2023\\Exo 1\\Input.txt");

    int result = Trebuchet.Calibration(fileContent);
    Console.WriteLine($"Exo 1 Trebuchet = {result}" );
}
catch (IOException ex)
{
    Console.WriteLine($"An error occurred while reading the file: {ex.Message}");
}
