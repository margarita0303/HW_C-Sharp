using System;
using System.Collections.Generic;
using Task1;

namespace HW_C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lab 11
            // var testsTask1 = new Task1.Tests();
            // testsTask1.TestAll();

            var testsSerialization = new Serialization.Tests();
            testsSerialization.TestSerializing();
            testsSerialization.TestDeserializing();
        }
    }
}