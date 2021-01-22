using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class PointClass
    {
        public int X;
        public int Y;
    }

    public struct PointStruct
    {
        public int X;
        public int Y;
    }

    class Program
    {
        static void Main(string[] args)
        {
            var arrayLength = 0;
            while (true)
            {
                Console.WriteLine("Введите длину массива: ");
                if (int.TryParse(Console.ReadLine(), out arrayLength))
                {
                    GetArray(arrayLength);
                    break;
                }
            }

            Console.ReadKey();
        }

        static void GetArray(int arrayLength)
        {
            Random random = new Random();
            var array = new int[arrayLength];
            for (int i = 0; i < arrayLength - 1; i++)
            {
                array[i] = random.Next(0, 100);
                Console.WriteLine(array[i]);
            }
        }
    }
}
