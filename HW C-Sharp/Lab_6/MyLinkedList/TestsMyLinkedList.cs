using System;
using System.Collections;
using System.Collections.Generic;

namespace MyLinkedList
{
    class TestsMyLinkedList
    {
        public void TestAll()
        {
            if (TestAdd() && TestRemove() && TestClear() && TestEnumerator())
            {
                Console.WriteLine("MyLinkedList: tests passed.");
            }
            else
            {
                Console.WriteLine("MyLinkedList: tests failed.");
            }
        }

        public void Demonstrate()
        {
            var list = new IEnumerableLinkedList<int>();
            list.Add(10);
            list.Add(20);
            Console.WriteLine("List with 2 elements (10, 20):");
            foreach (var node in list)
            {
                Console.WriteLine(node.Data);
            }

            list.Remove(10);
            Console.WriteLine("List after removed 10:");
            foreach (var node in list)
            {
                Console.WriteLine(node.Data);
            }

        }

        public static bool TestAdd()
        {
            var list = new IEnumerableLinkedList<int>();
            if (list.Count != 0) return false;
            list.Add(6);
            if (list.Count != 1 || list.Head.Data != 6 || list.Tail.Data != 6) return false;
            list.Add(3);
            if (list.Count != 2 || list.Head.Data != 6 || list.Head.Next.Data != 3 || list.Tail.Data != 3) return false;
            list.Add(10);
            list.Add(20);
            if (list.Count != 4 || list.Head.Data != 6 || list.Tail.Data != 20) return false;
            return true;
        }

        public static bool TestRemove()
        {
            var list = new IEnumerableLinkedList<int>(new List<int> {1, 2, 3, 4, 5});
            list.Remove(1);
            if (list.Count != 4 || list.Head.Data != 2 || list.Head.Previous != null || list.Head.Next.Data != 3) return false;
            list.Remove(5);
            if (list.Count != 3 || list.Head.Data != 2 || list.Tail.Data != 4 || list.Tail.Next != null || list.Tail.Previous.Data != 3) return false;
            list.Remove(3);
            if (list.Count != 2 || list.Head.Data != 2 || list.Tail.Data != 4 || list.Head.Next != list.Tail ||
                list.Tail.Previous != list.Head) return false;
            return true;
        }

        public static bool TestClear()
        {
            var list = new IEnumerableLinkedList<int>(new List<int> {1, 2});
            list.Clear();
            return !(list.Count != 0 || list.Head != null || list.Tail != null);
        }

        public static bool TestEnumerator()
        {
            var list = new IEnumerableLinkedList<int>(new List<int> {1, 2, 3});
            var index = 0;
            foreach (var node in list)
            {
                if (index == 0 && (node.Data != 1 || node.Next.Data != 2 || node.Previous != null)) return false;
                if (index == 1 && (node.Data != 2 || node.Previous.Data != 1 || node.Next.Data != 3)) return false;
                if (index == 2 && (node.Data != 3 || node.Previous.Data != 2 || node.Next != null)) return false;
                index++;
            }

            return true;
        }
    }
}