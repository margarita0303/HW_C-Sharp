using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace Task1
{
    public class WritingOneMillionNumbers
    {
        // Fisher–Yates shuffle
        private static void Shuffle(List<int> list)
        {  
            var random = new Random();  
            var length = list.Count;
            while (length > 1) {  
                length--;  
                var k = random.Next(length + 1);
                (list[k], list[length]) = (list[length], list[k]);
            }  
        }
        
        public void WriteOneMillionNumbers()
        {
            var list = Enumerable.Range(1, 100000000).ToList();
            Shuffle(list);

            using (FileStream fs = File.Create("/home/margarita/RiderProjects/HW C-Sharp/HW C-Sharp/Lab_11/Task1/task1.txt"))
            using (TextWriter writer = new StreamWriter(fs))
            {
                foreach (var number in list)
                {
                    writer.WriteLine("{0:00000000}", number);
                }
            }
        }
    }
}