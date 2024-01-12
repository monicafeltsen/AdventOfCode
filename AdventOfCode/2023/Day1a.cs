using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    public class Day1a
    {

        private static Dictionary<string, int> numbersDictionary = new Dictionary<string, int>()
        {
            { "0", 0 },
            { "1", 1 },
            { "2", 2 },
            { "3", 3 },
            { "4", 4 },
            { "5", 5 },
            { "6", 6 },
            { "7", 7 },
            { "8", 8 },
            { "9", 9 }
        };

        public static void Run()
        {
            var lines = File.ReadAllLines(@"2023\2023-01.txt");
            var sum = 0;
            foreach (var line in lines)
            {
                var numbers = GetNumbers(line);
                var ctrl = int.Parse($"{numbers.First()}{numbers.Last()}");
                sum += ctrl;
            }

            Console.WriteLine(sum);
        }

        static List<int> GetNumbers(string line)
        {
            var result = new List<int>();
            int i = 0;

            while (i < line.Length)
            {
                foreach (var number in numbersDictionary.Keys)
                {
                    if (line.Substring(i).StartsWith(number))
                    {
                        result.Add(numbersDictionary[number]);
                        break;
                    }
                }

                i++;
            }

            return result;
        }
    }
}



