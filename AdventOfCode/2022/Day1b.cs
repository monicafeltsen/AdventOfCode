using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode.Year2022
{
    internal class Day1b
    {
        public static void Run()
        {
            var data = File.ReadAllLines(@"2022\2022-01.txt");
            var sum = 0;
            var topsum = 0;
            var sums = new List<int>();


            foreach (var x in data)
            {
                if (string.IsNullOrEmpty(x))
                {
                    if (sum > topsum)
                    {
                        topsum = sum;

                    }
                    sums.Add(sum);
                    sum = 0;
                }

                else
                {
                    sum += int.Parse(x);
                }
            }
           

            Console.WriteLine($"this is score of 1b 2022 {sums.OrderByDescending(x => x).Take(3).Sum()}");
        }
    }
}
