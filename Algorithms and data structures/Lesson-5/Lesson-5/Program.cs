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
            DFSmethod(tree, value);
        }

        static Node BFSmethod(BinaryTree binaryTree, int searchValue)
        {
            var queue = new Queue();
            var node = binaryTree.Root;
            queue.Enqueue(node);
            while (true)
            {
                if (queue.Count == 0)
                {
                    Console.WriteLine("Не найдено");
                    return null;
                }
                node = (Node)queue.Dequeue();
                Console.WriteLine($"Вытаскиваем из очередь {node.Right.Data}");
                if (node.Data == searchValue)
                {
                    Console.WriteLine("Найдено");
                    return node;
                }
                else 
                {
                    if (node.Left != null)
                    {
                        queue.Enqueue(node.Left);
                        Console.WriteLine($"Добавляем в очередь {node.Left.Data}");
                    }
                    if (node.Right != null)
                    {
                        queue.Enqueue(node.Right);
                        Console.WriteLine($"Добавляем в очередь {node.Right.Data}");
                    }
                }
                Console.WriteLine("Нажмите любую клавишу для следующей итерации цикла");
                Console.ReadKey();
            }
        }

        static Node DFSmethod(BinaryTree binaryTree, int searchValue)
        {
            var stack = new Stack();
            var node = binaryTree.Root;
            stack.Push(node);
            while (true)
            {
                if (stack == null)
                {
                    Console.WriteLine("Не найдено");
                    return null;
                }
                node = (Node)stack.Pop();
                Console.WriteLine($"Вытаскиваем из стэка {node.Data}");
                if (node.Data == searchValue)
                {
                    Console.WriteLine("Найдено");
                    return node;
                }
                else
                {
                    if (node.Right != null)
                    {
                        Console.WriteLine($"Добавляем в стэк {node.Right.Data}");
                        stack.Push(node.Right);
                    }
                    if (node.Left != null)
                    {
                        Console.WriteLine($"Добавляем в стэк {node.Left.Data}");
                        stack.Push(node.Left);
                    }
                }
                Console.WriteLine("Нажмите любую клавишу для следующей итерации цикла");
                Console.ReadKey();
            }
        }
    }
}
