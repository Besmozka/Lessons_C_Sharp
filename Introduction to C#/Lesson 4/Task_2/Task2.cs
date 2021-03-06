﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Task2
    {
        static void Main(string[] args)
        {
            Console.Write("Введите последовательность чисел через пробел: ");
            string userString = Console.ReadLine();            
            Console.WriteLine($"Сумма всех чисел равна: {SumUserString(userString)}");
            Console.ReadKey();

        }

        static int SumUserString(string userString)
        {
            int sumArray = 0;
            string longNumber = null;
            for (int i = 0; i < userString.Length; i++)
            {
                if (!Char.IsWhiteSpace(userString, i))
                {
                    longNumber += userString[i];
                    if (i == userString.Length - 1)
                        sumArray += Convert.ToInt32(longNumber);
                }
                else
                {
                    sumArray += Convert.ToInt32(longNumber);
                    longNumber = null;
                }
            }
            return sumArray;
        }
    }
}
