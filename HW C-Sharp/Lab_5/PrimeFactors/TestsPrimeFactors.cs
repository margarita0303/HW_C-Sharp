using System;

namespace PrimeFactors
{
    class TestsNumber
    {
        public void TestAll()
        {
            if (TestExpressFactors())
            {
                Console.WriteLine("All tests done.");
            }
            else
            {
                Console.WriteLine("Tests failed");
            }
        }

        private bool TestExpressFactors()
        {
            var numOfMistakes = 0;
            Number number = new Number(60);
            if (number.ExpressFactors() != "2^2x3x5")
            {
                numOfMistakes += 1;
            }
            
            number = new Number(10);
            if (number.ExpressFactors() != "2x5")
            {
                numOfMistakes += 1;
            }
            
            number = new Number(2);
            if (number.ExpressFactors() != "2")
            {
                numOfMistakes += 1;
            }

            return numOfMistakes == 0;

        }
    }
}