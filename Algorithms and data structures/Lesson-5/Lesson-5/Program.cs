using System;
using System.Collections;

namespace Lesson_5
{
    class Program
    {
        static void Main(string[] args)
        {
            var tree = new BinaryTree();
            var treeSize = 20;
            var randomInt = new Random();
            for (int i = 0; i < treeSize; i++)
            {
                tree.AddData(randomInt.Next(100));
            }
            tree.PrintTree();

            var value = Convert.ToInt32(Console.ReadLine());
            BFSmethod(tree, value);
        }

        static Node BFSmethod(BinaryTree binaryTree, int searchValue)
        {
            var queue = new Queue();
            var node = binaryTree.Root;
            queue.Enqueue(node);
            Node nodeData;
            while (true)
            {
                if (queue == null)
                {
                    return null;
                }
                nodeData = (Node)queue.Dequeue();
                if (nodeData.Data == searchValue)
                {
                    Console.WriteLine("Найдено");
                    return node;
                }
                else if (node.Left != null)
                {
                    queue.Enqueue(node.Left);
                    node = node.Left;
                }
                else if (node.Right != null)
                {
                    queue.Enqueue(node.Right);
                    node = node.Right;
                }
            }
        }

        static void DFSmethod(BinaryTree binaryTree)
        {

        }
    }
}
