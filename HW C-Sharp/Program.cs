using System;
using System.Collections.Generic;
using System.Linq;
using HashTable;
using Simplifier;
using Palindrome;
using ConversionOperators;
using EventBus;
using SortingHamsters;

namespace HW_C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            TestsEventBus tests = new TestsEventBus();
            tests.TestAll();
        }
    }
}