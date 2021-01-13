using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Task_3
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string stringBackwards = Console.ReadLine();
            int lengthStringBackwards = stringBackwards.Length;
            Console.WriteLine();

            Console.Write("Строка наоборот: ");
            for (int i = 0; i < stringBackwards.Length; i++)
            {
                Console.Write(stringBackwards[--lengthStringBackwards]);
            }
            Console.ReadLine();
        }
    }
}
