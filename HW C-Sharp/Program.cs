using System;
using System.Collections.Generic;

namespace HW_C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var tests1 = new FrogAndLake.TestsFrogAndLake();
            tests1.TestAll();

            var tests2 = new SortingCollections.TestsSortingCollections();
            tests2.TestAll();

            var tests3 = new MyLinkedList.TestsMyLinkedList();
            tests3.TestAll();
            
            // tests3.Demonstrate();
        }
    }
}