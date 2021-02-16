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
                min = min > array[i] ? array[i]: min;
            }
            return min;
        }

        static int GetMaxValue(int[] array)
        {
            int max = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                max = max < array[i] ? array[i] : max;
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
            int dValue = (maxValue - minValue) / numberBuskets; //определение необходимого диапазона данных для блока 

            for (int i = 0; i < array.Length; i++) 
            {
                for (int j = 0; j < numberBuskets; j++) //цикл для приращивания диапазона данных для блока 
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

            for (int i = 0; i < blockLists.Length; i++)
            {
                QuickSort(blockLists[i], 0, blockLists[i].Count - 1);             
            }

            int arrayIndex = 0;
            int listIndex;
            for (int i = 0; i < blockLists.Length; i++)
            {
                listIndex = 0;
                while (listIndex != blockLists[i].Count)
                {
                    array[arrayIndex] = blockLists[i][listIndex];
                    arrayIndex++;
                    listIndex++;
                }
            }            
            return array;
        }

        static int Partition(List<int> array, int start, int end)
        {
            int temp;
            int marker = start;
            for (int i = start; i <= end; i++)   
            {
                if (array[i] < array[end])
                {
                    temp = array[marker];
                    array[marker] = array[i];
                    array[i] = temp;
                    marker++;
                }
            }           
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
