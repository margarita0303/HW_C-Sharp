using System;
using System.Collections.Generic;
using FileSearch;

namespace HW_C_Sharp
{
    enum MyEnum
    {
        i1 = 2, 
        i2 = 5
    }
    class Program
    {
        static void Main(string[] args)
        {
            var testsAllergies = new Allergies.TestsAllergies();
            testsAllergies.TestAll();

            var testsRacingCar = new RacingCar.TestsRacingCar();
            testsRacingCar.TestAll();
        }
    }
}