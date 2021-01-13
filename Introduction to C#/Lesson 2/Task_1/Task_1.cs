using System;

namespace Lesson_2
{
    class Task_1
    {
        static void Main(string[] args)
        {
            string minTemperature = null;
            string maxTemperature = null;
            double convertMinTemp = 0;
            double convertMaxTemp = 0;

            Console.Write("Введите минимальную температуру за сутки (°C): ");
            minTemperature = Console.ReadLine();
            convertMinTemp = Convert.ToInt32(minTemperature);
            if (convertMinTemp < -100)
            {
                Console.WriteLine("Слишком низкая температура.");
                Console.ReadLine();
                return;
            }
            if (convertMinTemp > 100)
            {
                Console.WriteLine("Слишком высокая температура.");
                Console.ReadLine();
                return;
            }

            Console.Write("Введите максимальную температуру за сутки (°C): ");
            maxTemperature = Console.ReadLine();
            convertMaxTemp = Convert.ToInt32(maxTemperature);
            if (convertMaxTemp < -100)
            {
                Console.WriteLine("Слишком низкая температура.");
                Console.ReadLine();
                return;
            }
            if (convertMaxTemp > 100)
            {
                Console.WriteLine("Слишком высокая температура."); 
                Console.ReadLine();
                return;
            }

            double averageTemp = (convertMaxTemp + convertMinTemp) / 2;
            Console.WriteLine("Среднесуточная температура равна (°C): " + Math.Round(averageTemp, 1));
            Console.ReadLine();
        }
    }
}
