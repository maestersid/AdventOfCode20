using System;
using System.Collections.Generic;
using System.Text;

namespace AdventCode20.Days
{
    class Day2 : Day
    {
        public override void SolvePart1()
        {
            //var data = new List<string> { "1-3 a: abcde", "1-3 b: cdefg", "2-9 c: ccccccccc" };
            var data = InputData;
            var isValid = 0;
            foreach (var password in data)
            {
                bool res = ValidatePassword(password);
                if (res)
                    isValid++;
            }

            Console.WriteLine($"Valid Passwords: {isValid}");
        }

        private bool ValidatePassword(string entry)
        {
            string[] parts = entry.Split(' ');

            //get min and max of rule
            string[] minmax = parts[0].Split('-');
            int min = Int32.Parse(minmax[0]);
            int max = Int32.Parse(minmax[1]);

            //get letter
            var reqLetter = parts[1].ToCharArray()[0];

            int count = 0;
            var pwd = parts[2].ToCharArray();
            for(int i = 0; i<pwd.Length; i++)
            {
                if (pwd[i] == reqLetter)
                    count++;
            }

            return count >= min && count <= max;
        }

        public override void SolvePart2()
        {
            var data = InputData;
            var isValid = 0;
            foreach (var password in data)
            {
                bool res = RevalidatePassword(password);
                if (res)
                    isValid++;
            }

            Console.WriteLine($"Valid Passwords: {isValid}");
        }

        private bool RevalidatePassword(string entry)
        {
            string[] parts = entry.Split(' ');

            //get min and max of rule
            string[] minmax = parts[0].Split('-');
            int first = Int32.Parse(minmax[0]) -1;
            int second = Int32.Parse(minmax[1]) -1;

            //get letter
            var reqLetter = parts[1].ToCharArray()[0];

            var pwd = parts[2].ToCharArray();

            return pwd[first] == reqLetter ^ pwd[second] == reqLetter;
        }
    }
}
