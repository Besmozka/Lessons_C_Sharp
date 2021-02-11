using System;

namespace Lesson_7_Dynamic_programming_
{
    class Program
    {
        public static int[] A = new int[10] { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, };
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
            var pole = new int[rows, columns];
            var f = new Program();
            f.F(5);

        }

        public void GetCountExits(int[,] pole)
        {

        }

        int F(int n)
        {
            if (A[n] != -1) return A[n];
            if (n < 2) return 1;
            else
            {
                A[n] = F(n - 1) + F(n - 2);
                return A[n];
            }
        }
    }
}
