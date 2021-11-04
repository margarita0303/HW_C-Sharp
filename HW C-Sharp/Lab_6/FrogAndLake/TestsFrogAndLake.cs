using System;
using System.Collections;
using System.Collections.Generic;

namespace FrogAndLake
{
    class TestsFrogAndLake
    {
        public void TestAll()
        {
            if (Test1() && Test2())
            {
                Console.WriteLine("FrogAndLake: tests passed.");
            }
            else
            {
                Console.WriteLine("FrogAndLake: tests failed.");
            }
        }

        public bool Test1()
        {
            var lake = new Lake(new List<int> {1, 2, 3, 4, 5, 6, 7, 8});
            var answer = new List<int>();
            foreach (var stone in lake)
            {
                answer.Add(stone);
            }

            return answer[0] == 1 && answer[1] == 3 && answer[2] == 5 && answer[3] == 7
                    && answer[4] == 8 && answer[5] == 6 && answer[6] == 4 && answer[7] == 2;
        }
        
        public bool Test2()
        {
            var lake = new Lake(new List<int> {13, 23, 1, -8, 4, 9});
            var answer = new List<int>();
            foreach (var stone in lake)
            {
                answer.Add(stone);
            }

            return answer[0] == 13 && answer[1] == 1 && answer[2] == 4 && answer[3] == 9 && answer[4] == -8 && answer[5] == 23;
        }
    }
}