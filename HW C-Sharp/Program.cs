using System;
using System.Collections.Generic;
using System.Linq;
using HashTable;
using Simplifier;
using Palindrome;
using ConversionOperators;
using EventBus;
using SortingHamsters;
using SunLongers;

namespace HW_C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TESTING TASK1 : EVENTBUS");
            TestsEventBus testsEventBus = new TestsEventBus();
            testsEventBus.TestAll();
            
            Console.WriteLine("TESTING TASK 2 : SUNLONGERS");
            TestsBeach testsBeach = new TestsBeach();
            testsBeach.TestAll();
        }
    }
}