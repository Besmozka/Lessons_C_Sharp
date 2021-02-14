using System;

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
                array[i] = random.Next(1000);
            }
        }

        static int[] BusketSort(int[] array)
        {
            int[] minArray = new int[array.Length / 2];
            int[] maxArray = new int[array.Length - minArray.Length];
            int maxCount = 0, minCount = 0;
            if (array == null)
            {
                Console.WriteLine("Данный массив не существует");
                return null;
            }
            if (array.Length != 0)
            {
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[array.Length/2] >= array[i])
                    {
                        maxArray[maxCount] = array[i];
                        maxCount++;
                    }
                    else
                    {
                        minArray[minCount] = array[i];
                        minCount++;
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
