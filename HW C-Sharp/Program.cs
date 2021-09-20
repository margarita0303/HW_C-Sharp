﻿using System;
using System.Collections.Generic;

namespace HW_C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testing HashTable.");
            
            var hashTable = new HashTable.HashTableWithLinkedList<int,string>();
            hashTable.Insert(12, "Value1");
            
            try
            {
                var result = hashTable.Find(12);
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
            
            Console.WriteLine("Testing RandomPassword.");
            
            var password = new RandomPassword.RandomPassword();
            Console.WriteLine(password.getPassword());
        }
    }
}