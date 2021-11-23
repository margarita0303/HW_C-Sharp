using System;
using System.IO;

namespace FileSearch
{
    class Tests
    {
        public void TestAll()
        {
            Test1();
            Test2();
        }
        public void Test1()
        {
            var sf = new SearchingFile();
            var di = new DirectoryInfo(@"/home");
            var filePath = sf.FindfFile("TestsSunLongers.cs", di);
            if (filePath == null)
            {
                Console.WriteLine("File was not found");
            }
            else
            {
                Console.WriteLine("FilePath of TestsSunLongers.cs: " + filePath);
            }
        }
        
        public void Test2()
        {
            var sf = new SearchingFile();
            var di = new DirectoryInfo(@"/home");
            var filePath = sf.FindfFile("TestFile.txt", di);
            if (filePath == null)
            {
                Console.WriteLine("File was not found");
            }
            else
            {
                Console.WriteLine("FilePath of TestFile.txt: " + filePath);
            }
        }
    }
}