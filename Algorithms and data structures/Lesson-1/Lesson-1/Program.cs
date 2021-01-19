using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_1
{
    class Program
    {
        static void Main(string[] args)
        {
            if (SimpleNumber())
                Console.WriteLine("Число простое");
            else
                Console.WriteLine("Число не простое");
            Console.ReadKey();
        }


        static bool SimpleNumber()
        {
            int n = 0;
            while (true)
            {
                Console.Write("Введите число: ");
                if (int.TryParse(Console.ReadLine(), out n))
                    break;
            }
            int d = 0;
            int i = 2;
            while (i < n)
            {
                if ((n % i) == 0)
                {
                    d++;
                    i++;
                }
                else
                    i++;
            }
            if (d == 0)
                return true;
            else
                return false;
        }

    }
}
