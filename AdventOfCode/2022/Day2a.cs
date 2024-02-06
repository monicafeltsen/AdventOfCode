using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode.Year2022
{
    public class Day2a
    {
        public static void Run()
        {
            var data = File.ReadAllLines(@"2022\2022-02.txt");
            var sum = 0;

            var lettertonumber = new Dictionary<char, int>()
            {//Opponent
                {'A', 1 },//Rock
                {'B', 2 },//Paper
                {'C', 3 }, //Scissors
                //ME
                {'X', 1 }, //Rock
                {'Y', 2 }, //Paper
                {'Z', 3 },//Scissors
            // 0 - lost
            // 3 - draw
            // 6 - winning

             
            };

            foreach (var x in data)
            {
                var line = x;
                var opponentchar = line[0];
                var mechar = line[2];

                sum += Somemethod(lettertonumber[opponentchar], lettertonumber[mechar]);

            }
            Console.WriteLine($"this is score of 2a 2022 {sum}");

            int Somemethod(int opponent, int result)
            {
                var score = 0;

                switch (opponent)
                {
                    case 1:
                        switch (result)
                        {
                            case 1: //A+X
                                score += 4;
                                break;
                            case 2: // A +Y
                                score += 8;
                                break;
                            case 3: //A + Z
                                score += 3;
                                break;
                        }
                        break;
                    case 2:
                        switch (result)
                        {
                            case 1: // B + X 
                                score += 1;
                                break;
                            case 2: //B + Y 
                                score += 5;
                                break;
                            case 3: // B + Z
                                score += 9;
                                break;
                        }
                        break;
                    case 3:
                        switch (result)
                        {
                            case 1: //C + X
                                score += 7;
                                break;
                            case 2: //C + Y
                                score += 2;
                                break;
                            case 3: //C + Z 
                                score += 6;
                                break;
                        }
                        break;

                }


                return score;
            }



        }

    }
}
