using System;
using System.IO;

namespace Serialization
{
    public class Tests
    {
        public void TestSerializing()
        {
            BinaryTree binaryTree = new BinaryTree();
            binaryTree.Insert(5);
            binaryTree.Insert(2);
            binaryTree.Insert(10);
            binaryTree.Insert(20);
            using (FileStream fs = File.Create("/home/margarita/RiderProjects/HW C-Sharp/HW C-Sharp/Lab_11/Serialization/SerializedBinaryTree.txt"))
            {
                var serializer = new BinaryTreeSerializer();
                serializer.Serialize(fs, binaryTree);
            }
            Console.WriteLine("Testing serializing : check file SerializedBinaryTree.txt");
        }

        public void TestDeserializing()
        {
            var binaryTree = new BinaryTree();
            using (FileStream fs = File.OpenRead("/home/margarita/RiderProjects/HW C-Sharp/HW C-Sharp/Lab_11/Serialization/SerializedBinaryTree.txt"))
            {
                var serializer = new BinaryTreeSerializer();
                binaryTree = serializer.Deserialize(fs);
            }
            Console.WriteLine("Testing Deserializing :");
            Console.WriteLine("Root (must be 5) = " + binaryTree.Value);
            Console.WriteLine("Left node (must be 2) = " + binaryTree.Left.Value);
            Console.WriteLine("Right node (must be 10) = " + binaryTree.Right.Value);
            Console.WriteLine("Right-right node (must me 20) = " + binaryTree.Right.Right.Value);
        }
    }
}