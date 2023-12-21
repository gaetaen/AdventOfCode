using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode._2023.Day_4;

public static class Scratchcards
{
    public static int CalculatePoints(string input)
    {
        string[] games = input.Split(Environment.NewLine);
        List<Card> cardList = new();

        foreach (string game in games)
        {
            string[] gameInfo = game.Split(":");
            string[] cardNumbers = gameInfo[1].Split("|");
            string[] gameNumbers = cardNumbers[0].Split(" ").Where(num => !string.IsNullOrEmpty(num)).ToArray();
            string[] winningNumbers = cardNumbers[1].Split(" ").Where(num => !string.IsNullOrEmpty(num)).ToArray();
            int value = 0;

            foreach (var number in gameNumbers)
            {
                if (winningNumbers.Contains(number))
                {
                    value = (value == 0) ? 1 : value * 2;
                }
            }

            var card = new Card()
            {
                Name = gameInfo[0],
                GameNumbers = gameNumbers,
                WinningNumbers = winningNumbers,
                Value = value
            };

            cardList.Add(card);
        }
        return cardList.Sum(x => x.Value);
    }

    public static int TotalScratchcards(string input)
    {
        string[] games = input.Split(Environment.NewLine);
        Card[] cardArray = new Card[games.Length];

        for (int j = 0; j < games.Length; j++)
        {
            string game = games[j];
            string[] gameInfo = game.Split(":");
            string[] cardNumbers = gameInfo[1].Split("|");
            string[] gameNumbers = cardNumbers[0].Split(" ").Where(num => !string.IsNullOrEmpty(num)).ToArray();
            string[] winningNumbers = cardNumbers[1].Split(" ").Where(num => !string.IsNullOrEmpty(num)).ToArray();
            int value = 0;

            for (int i = 0; i < gameNumbers.Length; i++)
            {
                string? number = gameNumbers[i];
                if (winningNumbers.Contains(number))
                {
                    value++;
                }
            }
            cardArray[j] = new Card()
            {
                Name = gameInfo[0],
                GameNumbers = gameNumbers,
                WinningNumbers = winningNumbers,
                Value = value,
                Multiplication = 1
            };
        }

        for (int x = 0; x < cardArray.Length - 1; x++)
        {
            Card card = cardArray[x];
            for (int i = 0; i < card.Multiplication; i++)
            {
                for (int j = 0; j < cardArray[x].Value; j++)
                {
                    cardArray[x + j + 1].Multiplication++;
                }
            }
        }
        return cardArray.Sum(x => x.Multiplication);
    }

    public class Card
    {
        public string Name { get; init; }
        public string[] WinningNumbers { get; init; }
        public string[] GameNumbers { get; init; }
        public int Value { get; set; }
        public int Multiplication { get; set; }
    }
}