using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab_7_Tests
{
    public class Lab7Tests
    {
        public void TestAll()
        {
            Console.WriteLine("Testing Lab7\n");
            TestTask1();
            TestTask2();
            TestTask3();
            TestTask4();
            TestMinMaxTask();
            TestThreeSumProblemTask();
        }

        public void TestTask1()
        {
            Console.WriteLine("Testing Task 1:");
            
            var persons = new List<Lab_7_Task_1.Person>() 
            { new Lab_7_Task_1.Person("John"), new Lab_7_Task_1.Person("Margarita"), new Lab_7_Task_1.Person("Sam"),
                new Lab_7_Task_1.Person("Tom"), new Lab_7_Task_1.Person("Emily")};

            var delimiter = ',';
            var task1 = new Lab_7_Task_1.Task1();

            Console.WriteLine(task1.DoTask1(persons, delimiter));
            Console.WriteLine();
        }
        
        public void TestTask2()
        {
            Console.WriteLine("Testing Task 2:");
            
            var persons = new List<Lab_7_Task_2.Person>() 
                { new Lab_7_Task_2.Person("Mary"), new Lab_7_Task_2.Person("Genry"), new Lab_7_Task_2.Person("I"),
                    new Lab_7_Task_2.Person("Tom"), new Lab_7_Task_2.Person("Margarita")};
            var task2 = new Lab_7_Task_2.Task2();
            var answer = task2.DoTask2(persons);
            foreach (var person in answer)
            {
                Console.WriteLine(person.Name);
            }
            Console.WriteLine();
        }
        
        public void TestTask3()
        {
            Console.WriteLine("Testing Task 3:");
            var task3 = new Lab_7_Task_3.Task3();
            task3.DoTask3("Это что же получается: ходишь, ходишь в школу, а потом бац - вторая смена");
            Console.WriteLine();
        }
        
        public void TestTask4()
        {
            Console.WriteLine("Testing Task 4:");
            var translator = new Dictionary<string, string>();
            translator["this"] = "Эта";
            translator["dog"] = "собака";
            translator["eats"] = "ест";
            translator["too"] = "слишком";
            translator["much"] = "много";
            translator["vegetables"] = "овощей";
            translator["after"] = "после";
            translator["lunch"] = "обеда";
            
            var task4 = new Lab_7_Task_4.Task4(translator);
            var book = task4.GetBook("This dog eats too much vegetables after lunch", 3);

            foreach (var page in book)
            {
                Console.WriteLine(page);
            }
            Console.WriteLine();
        }
        
        public void TestMinMaxTask()
        {
            Console.WriteLine("Testing MinMaxTask:");
            var task5 = new Lab_7_MaxMinTask.MaxMinTask();
            Console.WriteLine(12340 + " -> " + task5.DoMaxMinTask(12340)[0] + " and " + task5.DoMaxMinTask(12340)[1]);
            Console.WriteLine(98761 + " -> " + task5.DoMaxMinTask(98761)[0] + " and " + task5.DoMaxMinTask(98761)[1]);
            Console.WriteLine(98761 + " -> " + task5.DoMaxMinTask(9000)[0] + " and " + task5.DoMaxMinTask(9000)[1]);
            Console.WriteLine(11321 + " -> " + task5.DoMaxMinTask(11321)[0] + " and " + task5.DoMaxMinTask(11321)[1]);
            Console.WriteLine();
        }
        
        public void TestThreeSumProblemTask()
        {
            Console.WriteLine("Testing ThreeSumProblemTask:");
            var task6 = new Lab_7_ThreeSumProblem.ThreeSumTask();

            Console.Write("Start Array: ");
            PrintList((new int[] { 0, 1, -1, -1, 2 }).ToList());
            PrintListOfLists(task6.DoThreeSumTask(new int[] { 0, 1, -1, -1, 2 }));
            
            Console.Write("Start Array: ");
            PrintList((new int[] { 0, 0, 0, 5, -5 }).ToList());
            PrintListOfLists(task6.DoThreeSumTask(new int[] { 0, 0, 0, 5, -5 }));
            
            Console.Write("Start Array: ");
            PrintList((new int[] { -5, 0, 0, 5, 0 }).ToList());
            PrintListOfLists(task6.DoThreeSumTask(new int[] { -5, 0, 0, 5, 0 }));
            
            Console.Write("Start Array: ");
            PrintList((new int[] { 1, 2, 3 }).ToList());
            PrintListOfLists(task6.DoThreeSumTask(new int[] { 1, 2, 3 }));
            
            Console.Write("Start Array: ");
            PrintList((new int[1]).ToList());
            PrintListOfLists(task6.DoThreeSumTask(new int[1]));
        }

        private void PrintListOfLists(List<List<int>> listOfLists)
        {
            foreach (var list in listOfLists)
            {
                PrintList(list);
            }
        }

        private void PrintList(List<int> list)
        {
            foreach (var value in list)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine();
        }
    }
}