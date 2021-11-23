using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Serialization
{
    class BinaryTreeSerializer
    {
        public BinaryTreeSerializer() { }

        public void Serialize(FileStream fs, BinaryTree binaryTree)
        {
            var list = new List<Int32>();
            PreOrderAndFillList(binaryTree, list);
            WriteInFile(fs, list);
        }

        public BinaryTree Deserialize(FileStream fs)
        {
            string resultString = GetStringFromFile(fs);
            return GetBinaryTreeFromString(resultString);
        }
        
        private void PreOrderAndFillList(BinaryTree binaryTree, List<Int32> list)
        {
            if (binaryTree.Value == null)
            {
                return;
            }

            Int32 notNullValue = (Int32)binaryTree.Value;
            list.Add(notNullValue);

            if (binaryTree.Left != null) 
                PreOrderAndFillList(binaryTree.Left, list);
            if (binaryTree.Right != null) 
                PreOrderAndFillList(binaryTree.Right, list);
        }

        private void WriteInFile(FileStream fs, List<Int32> list)
        {
            var resultString = "";
            foreach (var value in list)
            {
                resultString += $"{value:0000000000}";
            }

            using (TextWriter writer = new StreamWriter(fs))
            {
                writer.WriteLine(resultString);
            }
        }

        private string GetStringFromFile(FileStream fs)
        {
            string resultString = "";
            using (TextReader reader = new StreamReader(fs))
            {
                resultString = reader.ReadLine();
            }

            return resultString;
        }

        private BinaryTree GetBinaryTreeFromString(string binaryTreeAsString)
        {
            BinaryTree bt = new BinaryTree();
            for (int i = 0; i < binaryTreeAsString.Length; i += 10)
            {
                Console.WriteLine(binaryTreeAsString.Substring(i, 10));
                string node = binaryTreeAsString.Substring(i, 10);
                int value = Convert.ToInt32(node);
                bt.Insert(value);
            }

            return bt;
        }
    }
}