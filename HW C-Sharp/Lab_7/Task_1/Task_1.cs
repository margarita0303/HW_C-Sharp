using System.Collections.Generic;
using System.Linq;

namespace Lab_7_Task_1
{
    public class Task1
    {
        public string DoTask1(List<Person> persons, char delimeter)
        {
            return string.Join(delimeter, persons.Skip(3).Select(p => p.Name));
        }
    }
}