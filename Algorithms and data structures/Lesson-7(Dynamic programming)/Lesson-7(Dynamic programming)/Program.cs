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
            int rows, columns, xPoint, yPoint;
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
            while (true)
            {
                Console.Write("Введите x точки: ");
                if (int.TryParse(Console.ReadLine(), out xPoint))
                    break;
            }
            while (true)
            {
                Console.Write("Введите y точки: ");
                if (int.TryParse(Console.ReadLine(), out yPoint))
                    break;
            }
            buffer = new int[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    buffer[i,j] = -1;
                }
            }
            if (xPoint == 1)
            {
                for (int i = yPoint - 1; i < columns - 1; i++)
                {
                    buffer[xPoint - 1, i] = 0;
                }
            }

            if (yPoint == 1)
            {
                for (int i = xPoint - 1; i < rows; i++)
                {
                    buffer[i, yPoint - 1] = 0;
                }
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{buffer[i,j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Количество возможных путей из левого верхнего угла в правый нижний равно (с черными метками): {GetCountExitsBufferBlackPoint(rows, columns, xPoint, yPoint)}");
            Console.ReadKey();
        }

        public static int GetCountExitsBuffer(int row, int column)
        {
            if (row <= 1 || column <= 1)
            {
                return 1;
            }
            if (buffer[row - 1, column - 1] > 0)
            {
                return buffer[row - 1, column - 1];
            }

            var countExits = GetCountExitsBuffer(row - 1, column) + GetCountExitsBuffer(row, column - 1);
            buffer[row - 1, column - 1] = countExits;

            return buffer[row - 1, column - 1];
        }

        public static int GetCountExits(int row, int column)
        {
            if (row <= 1 || column <= 1)
            {
                return 1;
            }

            return GetCountExits(row - 1, column) + GetCountExits(row, column - 1);
        }

        public static int GetCountExitsBufferBlackPoint(int row, int column, int xPoint, int yPoint)
        {
            if ((row <= 1 || column <= 1) && (buffer[row - 1, column - 1] != 0))
            {
                return 1;
            }
            if (buffer[row - 1, column - 1] > -1)
            {
                return buffer[row - 1, column - 1];
            }
            if ((row == xPoint && column == yPoint))
            {
                return 0;
            }            
            var countExits = GetCountExitsBufferBlackPoint(row - 1, column, xPoint, yPoint) + GetCountExitsBufferBlackPoint(row, column - 1, xPoint, yPoint);
            buffer[row - 1, column - 1] = countExits;

            return buffer[row - 1, column - 1];
        }
    }
}
