using System;

namespace Lab_7_Task_2
{
    public class Person
    {
        public string Name;
        public int Age;
        
        public Person(string name, int age = 20)
        {
            Name = name;
            Age = age;
        }
    }
}