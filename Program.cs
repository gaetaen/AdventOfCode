using AdventOfCode._2023.Exo_2;
using AdventOfCode.Exos;

//// Exo 1 Trebuchet
//try
//{
//    string fileContent = File.ReadAllText("2023\\Exo 1\\Input.txt");

//    int result = Trebuchet.Calibration(fileContent);
//    Console.WriteLine($"Exo 1 Trebuchet = {result}" );
//}
//catch (IOException ex)
//{
//    Console.WriteLine($"An error occurred while reading the file: {ex.Message}");
//}
var result = CubeConundrum.Game(12, 13, 14, "Game 1: 5 blue, 4 red; 1 red, 2 green, 6 blue; 2 green\r\nGame 2: 1 blue, 2 green; 3 green, 4 blue, 1 red; 1 green, 1 blue\r\nGame 3: 8 green, 6 blue, 20 red; 5 blue, 4 red, 13 green; 5 green, 1 red\r\nGame 4: 1 green, 3 red, 6 blue; 3 green, 6 red; 3 green, 15 blue, 14 red\r\nGame 5: 6 red, 1 blue, 3 green; 2 blue, 1 red, 2 green");
foreach (var item in result) Console.WriteLine(item);