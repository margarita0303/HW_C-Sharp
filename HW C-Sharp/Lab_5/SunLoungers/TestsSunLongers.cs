using System;

namespace SunLongers
{
    public class TestsBeach
    {
        public void TestAll()
        {
            if (TestNumberOfFreeSunLongers())
            {
                Console.WriteLine("All tests done.");
            }
            else
            {
                Console.WriteLine("Tests failed");
            }
        } 
        
        private bool TestNumberOfFreeSunLongers()
        {
            var numOfMistakes = 0;
            Beach beach = new Beach("010");
            if (beach.NumberOfFreeSunLongers() != 0)
            {
                numOfMistakes += 1;
            }

            beach = new Beach("000");
            if (beach.NumberOfFreeSunLongers() != 2)
            {
                numOfMistakes += 1;
            }
            
            beach = new Beach("0000");
            if (beach.NumberOfFreeSunLongers() != 2)
            {
                numOfMistakes += 1;
            }
            
            beach = new Beach("1111");
            if (beach.NumberOfFreeSunLongers() != 0)
            {
                numOfMistakes += 1;
            }
            
            beach = new Beach("00100");
            if (beach.NumberOfFreeSunLongers() != 2)
            {
                numOfMistakes += 1;
            }
            
            beach = new Beach("10001");
            if (beach.NumberOfFreeSunLongers() != 1)
            {
                numOfMistakes += 1;
            }
            
            beach = new Beach("0001");
            if (beach.NumberOfFreeSunLongers() != 1)
            {
                numOfMistakes += 1;
            }
            
            beach = new Beach("100010001000001");
            if (beach.NumberOfFreeSunLongers() != 4)
            {
                numOfMistakes += 1;
            }
            
            beach = new Beach("0hghggtrgt");
            if (beach.NumberOfFreeSunLongers() != 0)
            {
                numOfMistakes += 1;
            }

            return numOfMistakes == 0;
        }
    }
}