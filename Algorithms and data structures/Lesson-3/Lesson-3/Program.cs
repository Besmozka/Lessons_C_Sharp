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

        public static double PointDistanceDouble(PointStruct pointOne, PointStruct pointTwo)
        {
            double x = pointOne.X - pointTwo.X;
            double y = pointOne.Y - pointTwo.Y;
            return Math.Sqrt((x * x) + (y * y));
        }

        public static float PointDistance(PointStruct pointOne, PointStruct pointTwo)
        {
            float x = pointOne.X - pointTwo.X;
            float y = pointOne.Y - pointTwo.Y;
            return MathF.Sqrt((x * x) + (y * y));
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
