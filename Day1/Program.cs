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
1000
2000
3000

4000

5000
6000

7000
8000
9000

10000
";


            // check to see if this is a blank line or not
            bool IsBlankLine(string line) => string.IsNullOrWhiteSpace(line);

            //var lines = input.Split(new[] { '\r'}, StringSplitOptions.RemoveEmptyEntries);

            var lines = File.ReadAllLines(@"C:\Users\Black\Documents\GitHub\aoc22\input.txt");

            var largestLine = 0;
            var largestTemp = 0;
            var topthree = new int[3];

            foreach (var line in lines)
            {
                if (IsBlankLine(line))
                {
                    if (largestTemp > topthree[0])
                    {
                        topthree[2] = topthree[1];
                        topthree[1] = topthree[0];
                        topthree[0] = largestTemp;
                    }
                    else if (largestTemp > topthree[1])
                    {
                        topthree[2] = topthree[1];
                        topthree[1] = largestTemp;
                    }
                    else if (largestTemp > topthree[2])
                    {
                        topthree[2] = largestTemp;
                    }

                    largestTemp = 0;
                    continue;
                }

                largestTemp += int.Parse(line);
            }

            foreach (var line in topthree)
            {
                largestLine += line;
                Console.WriteLine(line);
            }

            Console.WriteLine(largestLine);





        }
    }
}





















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