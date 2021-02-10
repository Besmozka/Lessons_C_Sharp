using System;

namespace Lesson_7_Dynamic_programming_
{
    class Program
    {
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

        }

        public void GetCountExits(int[,] pole)
        {

        }
    }
}
