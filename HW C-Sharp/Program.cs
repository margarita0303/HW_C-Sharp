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
            // var tmp = new Allergies.Allergies("John", 67);
            // Console.WriteLine(tmp.ToString());
            // tmp.AddAllergy("Eggs");
            // Console.WriteLine(tmp.ToString());
            // Console.WriteLine(tmp.Score);
            // tmp.DeleteAllergy("Tomatoes");
            // Console.WriteLine(tmp.ToString());
            // Console.WriteLine(tmp.Score);
            // tmp.DeleteAllergy("aaaa");
            // Console.WriteLine(tmp.ToString());
            // Console.WriteLine(tmp.Score);
            // var allergiesForPerson1 = new Allergies.Allergies("John", 10);
            // string allergiesForPerson1AsString = allergiesForPerson1.ToString();
            // Console.WriteLine(allergiesForPerson1AsString);

            var tests = new Allergies.TestsAllergies();
            tests.TestAll();
        }
    }
}