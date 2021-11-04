using System.Collections;
using System.Collections.Generic;
using System;

namespace SortingCollections
{
    class TestsSortingCollections
    {
        private Person p1 = new Person("AA", 10);
        private Person p2 = new Person("BA", 8);
        private Person p3 = new Person("CA", 9);
        private Person p4 = new Person("CB", 5);
        

        public void TestAll()
        {
            if (Test1() && Test2())
            {
                Console.WriteLine("SortingCollections: tests passed.");
            }
            else
            {
                Console.WriteLine("SortingCollections: tests failed.");
            }
        }

        public bool Test1()
        {
            var list = new List<Person>{p1, p2, p3, p4};
            list.Sort(new PersonsAgeComparer());
            return  list[0].Age == 5 && list[0].Name == "CB" && list[1].Age == 8 && list[1].Name == "BA" &&
                   list[2].Age == 9 && list[2].Name == "CA" && list[3].Age == 10 && list[3].Name == "AA";
        }
        
        public bool Test2()
        {
            var list = new List<Person>{p1, p2, p3, p4};
            list.Sort(new PersonsNameComparer());
            return list[0].Age == 10 && list[0].Name == "AA" && list[1].Age == 8 && list[1].Name == "BA" &&
                   list[2].Age == 9 && list[2].Name == "CA" && list[3].Age == 5 && list[3].Name == "CB";
        }
    }
}