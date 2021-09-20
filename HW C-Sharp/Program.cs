using System;
using System.Collections.Generic;

namespace HW_C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testing HashTableWithOpenAdressing.");
            var hashTable = new HashTable.HashTableWithOpenAdressing<int,string>(1);
            hashTable.Insert(304, "Value1");
            hashTable.Insert(22, "Value1");
            hashTable.Insert(28, "Value1");
            hashTable.Insert(31, "Value1");
            hashTable.Insert(101, "Value1");

            try
            {
                var result = hashTable.Find(304);
                Console.WriteLine(result);
            }
            catch (KeyNotFoundException)
            {
                Console.WriteLine("Key can not be found.");
            }
            
            try
            {
                var result = hashTable.Find(23);
                Console.WriteLine(result);
            }
            catch (KeyNotFoundException)
            {
                Console.WriteLine("Key can not be found.");
            }
            
            hashTable.Insert(20, "Value2");
            hashTable.Delete(20);
            
            try
            {
                var result = hashTable.Find(20);
                Console.WriteLine(result);
            }
            catch (KeyNotFoundException)
            {
                Console.WriteLine("Key can not be found.");
            }

            // Console.WriteLine("Testing HashTable.");
            //
            // var hashTable = new HashTable.HashTableWithLinkedList<int,string>();
            // hashTable.Insert(12, "Value1");
            //
            // try
            // {
            //     var result = hashTable.Find(12);
            //     Console.WriteLine(result);
            // }
            // catch (KeyNotFoundException)
            // {
            //     Console.WriteLine("Key can not be found.");
            // }
            //
            // try
            // {
            //     var result = hashTable.Find(23);
            //     Console.WriteLine(result);
            // }
            // catch (KeyNotFoundException)
            // {
            //     Console.WriteLine("Key can not be found.");
            // }
            //
            // hashTable.Insert(20, "Value2");
            // hashTable.Delete(20);
            //
            // try
            // {
            //     var result = hashTable.Find(20);
            //     Console.WriteLine(result);
            // }
            // catch (KeyNotFoundException)
            // {
            //     Console.WriteLine("Key can not be found.");
            // }
            //
            // Console.WriteLine("Testing RandomPassword.");
            //
            // var password = new RandomPassword.RandomPassword();
            // Console.WriteLine(password.getPassword());
        }
    }
}