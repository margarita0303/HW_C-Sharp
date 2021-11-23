using System;
using System.Collections.Generic;
using FileSearch;

namespace HW_C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // var testsWritingInFile = new WritingInFile.Tests();
            // testsWritingInFile.TestAll();
            //
            // var testsSerialization = new Serialization.Tests();
            // testsSerialization.TestSerializing();
            // testsSerialization.TestDeserializing();

            var testsSearchongFile = new FileSearch.Tests();
            testsSearchongFile.TestAll();
        }
    }
}