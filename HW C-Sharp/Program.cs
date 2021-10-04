using System;
using System.Collections.Generic;
using System.Linq;
using HashTable;
using Simplifier;
using Palindrome;
using ConversionOperators;

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
        }
    }
}