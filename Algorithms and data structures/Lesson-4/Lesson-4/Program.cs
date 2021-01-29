using System;

namespace Lesson_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var tree = new Tree();
            var random = new Random();
            var treeSize = 20;            
            while (true)
            {
                for (int i = 0; i < treeSize; i++)
                    tree.AddData(random.Next(100));
                tree.Print();
                var list = tree.InorderList(tree.Root);
                tree.BalancedTree(list, 0, list.Count);
                tree.Print();
                Console.ReadLine();
            }

        }
    }
}
