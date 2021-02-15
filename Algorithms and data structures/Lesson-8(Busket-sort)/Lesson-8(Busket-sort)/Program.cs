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

        static void QuickSort(List<int> blockList, int minIndex, int maxIndex)
        {
            if (minIndex >= maxIndex)
            {
                return;
            }
            var middleValue = (maxIndex - minIndex) / 2;
            var min = minIndex;
            var max = maxIndex;
            for (int i = 0; i < maxIndex; i++)
            {
                if (blockList[i] >= blockList[max])
                {
                    var temp = blockList[max];
                    blockList[max] = blockList[i];
                    blockList[i] = temp;
                    max--;
                }
            }
            QuickSort(blockList, minIndex, middleValue);
            QuickSort(blockList, middleValue, maxIndex);
        }

        //static int[] MergeSort(List<int> blockList, int lowIndex, int highIndex)
        //{
        //    if (lowIndex < highIndex)
        //    {
        //        if (highIndex - lowIndex == 1)
        //        {
        //            if (blockList[highIndex] < blockList[lowIndex])
        //            {
        //                var t = blockList[lowIndex];
        //                blockList[lowIndex] = blockList[highIndex];
        //                blockList[highIndex] = t;
        //            }
        //        }
        //        else
        //        {
        //            var middleIndex = (lowIndex + highIndex) / 2;
        //            MergeSort(blockList, lowIndex, middleIndex);
        //            MergeSort(blockList, middleIndex + 1, highIndex);
        //            Merge(blockList, lowIndex, middleIndex, highIndex);
        //        }
        //    }

        //    return blockList;

            static int[] ExternalSort()
        {
            return null;
        }
    }
}
