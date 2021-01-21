using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var randomNumber = new Random();
            var array = new int[101];
            int n;
            for (int i = 0; i < array.Length; i++)
                array[i] = i + 1;
            Array.Sort(array);
            for (int i = 0; i < array.Length; i++) Console.WriteLine($"Номер элемента массива {i}, значение {array[i]}");
            while (true)
            {
                Console.Write("Введите число: ");
                if (int.TryParse(Console.ReadLine(), out n))
                    break;
            }
            Console.WriteLine($"Номер найденного элемента массива {BinarySearch(array, n)}");
            
            Console.ReadKey();
        }

        public static int BinarySearch(int[] inputArray, int searchValue) // O (log N)
        {                     
            int min = 0; 
            int max = inputArray.Length - 1;
            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (searchValue == inputArray[mid])
                {
                    return mid;
                }
                else if (searchValue < inputArray[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            return -1;
        }
    }
}
