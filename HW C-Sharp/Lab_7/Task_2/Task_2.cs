using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab_7_Task_2
{
    public class Task2
    {
        public List<Person> DoTask2(List<Person> persons)
        {
            return persons.Where((p, index) => p.Name.Length > index).ToList();
        }
    }
}