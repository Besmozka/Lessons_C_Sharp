using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task_4
{
    class Task_4
    {
        static void Main(string[] args)
        {
            Console.Write("Введите путь: ");
            string userPath = Console.ReadLine();
            DirectoryTree directoryTree = new DirectoryTree();
            directoryTree.GetUserPath = userPath;
            Console.ReadLine();
        }
    }
}
