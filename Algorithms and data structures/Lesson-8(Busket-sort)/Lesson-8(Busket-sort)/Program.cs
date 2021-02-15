using System;
using System.Collections.Generic;

namespace Lesson_8_Busket_sort_
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            int arrayLenght;
            while (true)
            {
                Console.WriteLine("Введите размерность массива: ");
                if (int.TryParse(Console.ReadLine(), out arrayLenght))
                    break;
                
            }
            var array = new int[arrayLenght];
            for (int i = 0; i < array.Length - 1; i++)
            {
                array[i] = random.Next(50);
            }
            BusketSort(array);
            Console.ReadKey();
        }

        static int[] BusketSort(int[] array)
        {
            var minArray = new List<int>();
            var maxArray = new List<int>();
            if (array == null)
            {
                Console.WriteLine("Данный массив не существует");
                return null;
            }
            if (array.Length > 1)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[array.Length/2] <= array[i])
                    {
                        maxArray.Add(array[i]);
                    }
                    else
                    {
                        minArray.Add(array[i]);
                    }
                }
            }
            else
            {
                return array;
            }
            return null;
        }

        static int[] ExternalSort()
        {
            return null;
        }
    }
}
