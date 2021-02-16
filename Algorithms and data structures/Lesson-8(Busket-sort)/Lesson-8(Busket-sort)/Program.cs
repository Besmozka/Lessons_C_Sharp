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
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(100);
            }
            var min = GetMinValue(array);
            var max = GetMaxValue(array);
            BusketSort(array, min, max);
            Console.ReadKey();
        }

        static int GetMinValue(int[] array)
        {
            int min = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (min > array[i]) //Евгений, подскажите пожалуйста,
                {                   //есть какой либо "сахарный" вариант записи
                    min = array[i]; //такого сравнения и присваивания?
                }
            }
            return min;
        }

        static int GetMaxValue(int[] array)
        {
            int max = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (max < array[i]) //Евгений, подскажите пожалуйста,
                {                   //есть какой либо "сахарный" вариант записи
                    max = array[i]; //такого сравнения и присваивания?
                }
            }
            return max;
        }
        static int[] BusketSort(int[] array, int minValue, int maxValue)
        {
            int numberBuskets = 10;
            List<int>[] blockLists = new List<int>[numberBuskets];
            for (int i = 0; i < blockLists.Length; i++)
            {
                blockLists[i] = new List<int>();
            }
            int dValue = (maxValue - minValue) / numberBuskets;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < numberBuskets; j++)
                {
                    if (j == 0)
                    {
                        if (minValue <= array[i] && array[i]< minValue + dValue)
                        {
                            blockLists[j].Add(array[i]);
                            break;
                        }
                    }
                    if (j == numberBuskets - 1)
                    {
                        if (minValue + dValue * j <= array[i] && array[i] <= maxValue)
                        {
                            blockLists[j].Add(array[i]);
                            break;
                        }
                    }
                    if (minValue + dValue * j <= array[i] && array[i] < minValue + dValue * (j + 1 ))
                    {
                        blockLists[j].Add(array[i]);
                        break;
                    }
                }
            }
            QuickSort(blockLists[0], 0, blockLists[0].Count - 1);
            
            return array;
        }

        static int Partition(List<int> array, int start, int end)
        {
            int temp;//swap helper помошник в свапе
            int marker = start;//divides left and right subarrays  делит левый и правый подмассивы
            for (int i = start; i <= end; i++)   
            {
                if (array[i] < array[end]) //array[end] is pivot
                {
                    temp = array[marker]; // swap
                    array[marker] = array[i];
                    array[i] = temp;
                    marker += 1;
                }
            }
            //put pivot(array[end]) between left and right subarrays
            temp = array[marker];
            array[marker] = array[end];
            array[end] = temp;
            return marker;
        }

        static void QuickSort(List<int> array, int start, int end)
        {
            if (start >= end)
            {
                return;
            }
            int pivot = Partition(array, start, end);
            QuickSort(array, start, pivot - 1);
            QuickSort(array, pivot + 1, end);
        }
    }
}
