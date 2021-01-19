using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Task4
    {
        int i = 0;
        static void Main(string[] args)
        {
            int number = 0;
            Console.Write("Введите порядковый номер числа Фибонначи: ");
            int.TryParse(Console.ReadLine(), out number);
            for (int i = 0; i <= number; i++)
            {
                Console.WriteLine(GetFibonachi(i));
            }
            for (int i = 0; i <= number; i++)
            {
                Console.WriteLine(GetFibonachiCycle(i));
            }
            Console.ReadKey();
        }

        static int GetFibonachi(int n)
        {
            if (n == 0 || n == 1)
                return n;
            else
            {
                return GetFibonachi(n - 1) + GetFibonachi(n - 2);
            }
        }

        static int GetFibonachiCycle(int n)
        {            
            int f1 = 0; 
            int f2 = 1;
            int fibonachiSum = 0;
            if (n == 0)
                return f1;
            else if (n == 1) 
                return f2;
            for (int i = 1; i < n; i++)
            {
                fibonachiSum = f1 + f2;
                f1 = f2;
                f2 = fibonachiSum;
            }
            return fibonachiSum;
        }

    }
}
