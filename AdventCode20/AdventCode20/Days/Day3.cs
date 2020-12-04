using System;
using System.Collections.Generic;
using System.Text;

namespace AdventCode20.Days
{
    class Day3 : Day
    {
        public override void SolvePart1()
        {
            /*
            var data = new List<string>() { "..##.......",
                                            "#...#...#..",
                                            ".#....#..#.",
                                            "..#.#...#.#",
                                            ".#...##..#.",
                                            "..#.##.....",
                                            ".#.#.#....#",
                                            ".#........#",
                                            "#.##...#...",
                                            "#...##....#",
                                            ".#..#...#.#"};
            */
            var data = InputData;

            int intersect = 0;
            
            intersect = ParseTree(data, 0, 0, 3, 1);

            Console.WriteLine($"Final Count of Trees: {intersect}");
        }

        private int ParseTree(List<string> data, int curx, int cury, int modx, int mody)
        {
            int intersect = 0;
            int length = data[0].Length; //get length of row for modulo
            //check intersect at current position
            if (data[cury].ToCharArray()[curx%length] == '#')
            {
                intersect++;
            }

            //check if done, otherwise recurse
            int nextx = (curx + modx)%length;
            int nexty = cury + mody;
            if(nexty < data.Count)
            {
                intersect += ParseTree(data, nextx, nexty, modx, mody);
            }

            return intersect;
        }

        public override void SolvePart2()
        {
            /*
            var data = new List<string>() { "..##.......",
                                "#...#...#..",
                                ".#....#..#.",
                                "..#.#...#.#",
                                ".#...##..#.",
                                "..#.##.....",
                                ".#.#.#....#",
                                ".#........#",
                                "#.##...#...",
                                "#...##....#",
                                ".#..#...#.#"};
            */
            var data = InputData;

            var results = new List<int>();
            results.Add(ParseTree(data, 0, 0, 1, 1));
            results.Add(ParseTree(data, 0, 0, 3, 1));
            results.Add(ParseTree(data, 0, 0, 5, 1));
            results.Add(ParseTree(data, 0, 0, 7, 1));
            results.Add(ParseTree(data, 0, 0, 1, 2));

            double intersect = 1;
            foreach(int i in results)
            {
                intersect = intersect *i;
            }

            Console.WriteLine($"Final Count of Trees: {intersect}");
        }
    }
}
