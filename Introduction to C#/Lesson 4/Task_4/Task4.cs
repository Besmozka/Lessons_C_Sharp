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
            int fibonacciNum_1 = 0;
            int fibonacciNum_2 = 1;
            Console.Write("Введите порядковый номер числа Фибонначи: ");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine(Fibonachi(i));
            }
            Console.ReadKey();
        }

        static int GetFibonacci(int number, int fibonacciNum_1, int fibonacciNum_2)
        {
            int sumFibonacci = 0;
            if (number == 0)
                return sumFibonacci;
            else
            {
                if (number % 2 == 0)
                {
                    sumFibonacci = fibonacciNum_2 + fibonacciNum_1;
                    fibonacciNum_1 = sumFibonacci;
                }
                else
                {
                    sumFibonacci = fibonacciNum_2 + fibonacciNum_1;
                    fibonacciNum_2 = sumFibonacci;
                }
                Console.WriteLine(sumFibonacci);
            }
            return GetFibonacci(--number, fibonacciNum_1, fibonacciNum_2);
        }

        static int Fibonachi(int n)
        {
            if (n == 0 || n == 1)
                return n;
            else
            {
                return Fibonachi(n - 1) + Fibonachi(n - 2);
            }
        }

    }
}
