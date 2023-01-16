using System;
using System.Collections;
using System.IO;

namespace Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = @"
A Y
B X
C Z
";
            //var lines = input.Split(new[] { '\r', '\n'}, StringSplitOptions.RemoveEmptyEntries);

            var lines = File.ReadAllLines(@"C:\Users\Black\Documents\GitHub\aoc22\inputday2.txt");
            int totalScore = 0;
            foreach(string line in lines)
            {
                var parts = line.Split(' ');
                totalScore += GetRoundScoreNew(parts[0], parts[1]);
            }

            Console.WriteLine(totalScore);
          
        }
        //A X = rock //B Y = paper // C Z = scissors

        static int GetRoundScoreNew(string opponent, string player)
        {
            if(player == "Z")
            {
                return GetRoundScore(opponent, GetWinningValue(opponent));
            }
            if(player == "X")
            {
                return GetRoundScore(opponent, GetLosingValue(opponent));
            }
            if(player == "Y")
            {
                return GetRoundScore(opponent, GetDrawValue(opponent));
            }
            return 0;
        }

        static string GetLosingValue(string s)
        {
            switch (s)
            {
                case "A":
                    return "Z";
                case "B":
                    return "X";
                case "C":
                    return "Y";
                default:
                    return "";
            }
        }

        static string GetDrawValue(string s)
        {
            switch (s)
            {
                case "A":
                    return "X";
                case "B":
                    return "Y";
                case "C":
                    return "Z";
                default:
                    return "";
            }
        }
        static string GetWinningValue(string s)
        {
            switch(s)
            {
                case "A":
                    return "Y";
                case "B":
                    return "Z";
                case "C":
                    return "X";
                default:
                    return "";
            }
        }
        static int GetRoundScore(string opponent, string player)
        {
            if(AreSame(opponent, player))
            {
                return 3 + GetShapeScore(player);
            }
            else if(opponent == "A")
            {
                if(player == "Z")
                {
                    return 0 + GetShapeScore(player);
                }
                else
                {
                    return 6 + GetShapeScore(player);
                }
            }
            else if(opponent == "B")
            {
                if(player == "X")
                {
                    return 0 + GetShapeScore(player);
                }
                else
                {
                    return 6 + GetShapeScore(player);
                }
            }
            else if(opponent == "C")
            {
                if(player == "Y")
                {
                    return 0 + GetShapeScore(player);
                }
                else
                {
                    return 6 + GetShapeScore(player);
                }
            }
            return 0;
        }

        static bool AreSame(string opponent, string player)
        {
            return (opponent == "A" && player == "X") || (opponent == "B" && player == "Y") || (opponent == "C" && player == "Z");
        }

        static int GetShapeScore(string s)
        {
            switch (s)
            {
                case "C":
                case "Z":
                    return 3;
                case "B":
                case "Y":
                    return 2;
                case "A":
                case "X":
                    return 1;
                default:
                    return 0;
            }
        }
    }
}


//A X Rock
//B Y Paper
//C Z Scissors


















//for (int i = 0; i < text.Length; i++)
//{
//    if (Int32.TryParse(text[i], out number))
//    {
//        tempNumber += number;
//        if (tempNumber > largestCurrentValue)
//        {
//            largestCurrentValue = tempNumber;
//        }
//    }
//}