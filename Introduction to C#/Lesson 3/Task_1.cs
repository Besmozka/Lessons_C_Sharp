using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3
{
    class Task_1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("<Вывод элементов двумерного массива по диагонали>");
            Console.WriteLine();
            int[,] array = new int [10, 10];
            byte number = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = number++;
                    if (i == j)
                    {
                        Console.Write($"{array[i, j]} ");
                    }
                    Console.Write("  ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
