using System;
using System.Collections.Generic;
using System.Linq;
using HashTable;
using Simplifier;
using Palindrome;
using ConversionOperators;
using SortingHamsters;

namespace HW_C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var myTests = new TestsConversionOperators();
            myTests.TestAll();
            if (myTests.TestAll())
            {
                Console.WriteLine("Tests for conversion operators have been passed");
            }
            
            var sorter = new SorterForHamsters();
            Console.WriteLine("Not sorted hamsters");
            sorter.Print();
            sorter.SortHamsters();
            Console.WriteLine("Sorted hamsters");
            sorter.Print();

            // Hamster h1 = new Hamster(2, 30, 62, "gr", "sef");
            // Hamster h2 = new Hamster(3, 29, 62, "gr", "sef");
            // Hamster h3 = new Hamster();
            // Hamster h4 = new Hamster();
            // h3.Print();
            // h4.Print();
            // Console.WriteLine(h3 < h4);
            // Console.WriteLine(h1 > h2);
            // Console.WriteLine(h1 <= h2);
            // Console.WriteLine(h1 >= h2);
            // Console.WriteLine(h1 == h2);
            // Console.WriteLine(h1 != h2);
        }
    }
}