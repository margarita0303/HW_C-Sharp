using System;

namespace Palindrome
{
    class Palindrome
    {

        private static int Reverse(int value)
        {
            var valueAsArray = value.ToString().ToCharArray();
            Array.Reverse(valueAsArray);
            string newValueAsString = new string(valueAsArray);
            return Convert.ToInt32(newValueAsString);
        }

        private static int? FindNumberOrSteps(int seed, int pal)
        {
            int steps = 0;
            int currentValue = seed;
            while (currentValue < pal)
            {
                currentValue += Reverse(currentValue);
                steps++;
            }

            if (currentValue == pal)
            {
                return steps;
            }

            return null;
        }
        
        public static Tuple<int, int> PalSeq(int pal)
        {
            int? steps = 0;
            int seed = 0;

            if (pal == 1)
            {
                return new Tuple<int, int>(1, 0);
            }

            for (int i = 1; i < pal; i++)
            {
                seed = i;
                steps = FindNumberOrSteps(seed, pal);
                if (steps != null)
                {
                    break;
                }
            }

            if (steps != null)
            {
                return new Tuple<int, int>(seed, (int)steps);
            }
            
            return new Tuple<int, int>(0, 0);
        }
    }
}

