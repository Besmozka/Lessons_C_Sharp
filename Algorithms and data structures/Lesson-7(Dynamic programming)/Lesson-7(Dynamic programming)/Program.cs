using BenchmarkDotNet.Running;
using System;
using BenchmarkDotNet.Attributes;

namespace Lesson_7_Dynamic_programming
{
    class Program
    {

        public static int[,] buffer;
        static void Main(string[] args)
        {
            int rows, columns;
            while (true)
            {
                Console.Write("Введите M: ");
                if (int.TryParse(Console.ReadLine(), out rows))
                    break;
            }
            while (true)
            {
                Console.Write("Введите N: ");
                if (int.TryParse(Console.ReadLine(), out columns))
                    break;
            }
            buffer = new int[rows, columns];
            Console.WriteLine(GetCountExitsBufferBlackPoint(rows, columns, 2,1));
            Console.ReadKey();
        }

        public static int GetCountExitsBuffer(int rows, int columns)
        {
            if (rows <= 1 || columns <= 1)
            {
                return 1;
            }
            if (buffer[rows - 1, columns - 1] != 0)
            {
                return buffer[rows - 1, columns - 1];
            }

            var countExits = GetCountExitsBuffer(rows - 1, columns) + GetCountExitsBuffer(rows, columns - 1);
            buffer[rows - 1, columns - 1] = countExits;

            return buffer[rows - 1, columns - 1];
        }

        public static int GetCountExits(int rows, int columns)
        {
            if (rows <= 1 || columns <= 1)
            {
                return 1;
            }

            return GetCountExits(rows - 1, columns) + GetCountExits(rows, columns - 1);
        }

        public static int GetCountExitsBufferBlackPoint(int rows, int columns, int xPoint1, int yPoint1)
        {
            if (rows <= 1 || columns <= 1)
            {
                return 1;
            }
            if (buffer[rows - 1, columns - 1] != 0)
            {
                return buffer[rows - 1, columns - 1];
            }
            if ((rows == xPoint1 && columns == yPoint1))
            {
                return 0;
            }
            if ((xPoint1 == 1 && yPoint1 <= columns) || (xPoint1 <= rows || yPoint1 == 1))
            {
                return 0;
            }
              var countExits = GetCountExitsBufferBlackPoint(rows - 1, columns, 2, 1) + GetCountExitsBufferBlackPoint(rows, columns - 1, 2, 1);
            buffer[rows - 1, columns - 1] = countExits;

            return buffer[rows - 1, columns - 1];
        }
    }
}
