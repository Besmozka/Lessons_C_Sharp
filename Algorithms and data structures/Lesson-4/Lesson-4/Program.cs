using System;

namespace Lesson_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var tree = new Tree();
            tree.AddData(4);
            tree.AddData(5);
            tree.AddData(1);
            tree.AddData(3);
            tree.AddData(9);
            tree.AddData(7);
            tree.AddData(6);
            tree.AddData(0);
            tree.AddData(8);
            tree.DeleteData(16);
            Console.WriteLine();

        }
    }
}
