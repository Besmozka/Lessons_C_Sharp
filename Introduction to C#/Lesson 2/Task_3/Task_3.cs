using System;

namespace Task_3
{
    class Task_3
    {
        static void Main(string[] args)
        {
            double number = 0;

            Console.Write("Введите число: ");
            number = Convert.ToInt32(Console.ReadLine());
            if ((Math.IEEERemainder(number, 2)) == 0)
            {
                Console.WriteLine("Число четное.");
            }
            else
            {
                Console.WriteLine("Число нечетное.");
            }
        }
    }
}
