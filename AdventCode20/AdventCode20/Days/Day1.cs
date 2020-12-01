using System;
using System.Collections.Generic;
using System.Text;

namespace AdventCode20.Days
{
    class Day1 : Day
    {
        public override void SolvePart1()
        {
            int firstNum = 0;
            int secondNum = 0;

            //var list = new List<int>() {1721, 979, 366, 299, 675, 1456 };

            var list = InputDataAsInt;

            var complete = false;
            for(int i = 0; i<list.Count-1; i++ )
            {
                for(int j = 1; j<list.Count; j++)
                {
                    firstNum = list[i];
                    secondNum = list[j];
                    if (firstNum + secondNum == 2020)
                    {
                        complete = true;
                        break;
                    }
                }
                if (complete)
                    break;
            }
            var res = firstNum * secondNum;
            Console.Write($"Nums Found: {firstNum} {secondNum} Equals {res}\n");
        }

        public override void SolvePart2()
        {
            int firstNum = 0;
            int secondNum = 0;
            int thirdNum = 0;

            //var list = new List<int>() {1721, 979, 366, 299, 675, 1456 };

            var list = InputDataAsInt;

            var complete = false;
            for (int i = 0; i < list.Count; i++)
            {
                firstNum = list[i];
                for (int j = 1; j < list.Count; j++)
                {
                    secondNum = list[j];
                    for (int k = 2; k < list.Count; k++)
                    {
                        thirdNum = list[k];
                        if (firstNum + secondNum + thirdNum == 2020)
                        {
                            complete = true;
                            break;
                        }
                    }
                    if (complete)
                        break;
                }
                if (complete)
                    break;
            }
            var res = firstNum * secondNum * thirdNum;
            Console.Write($"Nums Found: {firstNum} {secondNum} {thirdNum} Equals {res}\n");
        }
    }
}
