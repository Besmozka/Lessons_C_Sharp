using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Task_2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("<Телефонный справочник>");

            string[,] array = new string[5, 2];
            ConsoleKeyInfo keyInfo;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.Write($"Введите имя контакта №[{i+1}]: ");
                array[i, 0] = Console.ReadLine();
                Console.WriteLine();
                Console.Write($"Введите телефон/e-mail для контакта №[{i+1}]: ");
                array[i, 1] = Console.ReadLine();
                Console.WriteLine();                
            }
            Console.WriteLine("Вывести телефонный справочник - Y, Выход - N");
            keyInfo = Console.ReadKey();
            if (keyInfo.Key == ConsoleKey.Y)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    Console.WriteLine();
                    Console.Write($"№ {i+1} Имя: {array[i, 0]}. ");
                    Console.WriteLine($"Телефон/e-mail: {array[i, 1]}");
                }
            }
            else if (keyInfo.Key == ConsoleKey.N)
            {
                return;
            }
            Console.ReadKey();
        }
    }
}
