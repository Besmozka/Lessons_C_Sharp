using System;

namespace Task_4
{
    class Task_4
    {
        enum Months
        {
            Январь = 1,
            Февраль,
            Март,
            Апрель,
            Май,
            Июнь,
            Июль,
            Август,
            Сентябрь,
            Октябрь,
            Ноябрь,
            Декабрь,
        }
        static void Main(string[] args)
        {
            string minTemperature = null;
            string maxTemperature = null;
            string currentMonth = null;
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


            Console.Write("Введите порядковый номер текущего месяца: ");
            currentMonth = Console.ReadLine();
            if (Convert.ToInt32(currentMonth) < 0)
            {
                Console.WriteLine("Введите число от 1 до 12.");
                Console.ReadLine();
                return;
            }
            if (Convert.ToInt32(currentMonth) > 12)
            {
                Console.WriteLine("Введите число от 1 до 12.");
                Console.ReadLine();
                return;
            }


            switch (Convert.ToInt32(currentMonth))
            {
                case (int)Months.Январь:
                    Console.WriteLine("Текущий месяц Январь");
                    if (averageTemp > 0)
                    {
                        Console.WriteLine("Дождливая зима");
                    }
                    break;
                case (int)Months.Февраль:
                    Console.WriteLine("Текущий месяц Февраль");
                    if (averageTemp > 0)
                    {
                        Console.WriteLine("Дождливая зима");
                    }
                    break;
                case (int)Months.Март:
                    Console.WriteLine("Текущий месяц Март");
                    break;
                case (int)Months.Апрель:
                    Console.WriteLine("Текущий месяц Апрель");
                    break;
                case (int)Months.Май:
                    Console.WriteLine("Текущий месяц Май");
                    break;
                case (int)Months.Июнь:
                    Console.WriteLine("Текущий месяц Июнь");
                    break;
                case (int)Months.Июль:
                    Console.WriteLine("Текущий месяц Июль");
                    break;
                case (int)Months.Август:
                    Console.WriteLine("Текущий месяц Август");
                    break;
                case (int)Months.Сентябрь:
                    Console.WriteLine("Текущий месяц Сентябрь");
                    break;
                case (int)Months.Октябрь:
                    Console.WriteLine("Текущий месяц Октябрь");
                    break;
                case (int)Months.Ноябрь:
                    Console.WriteLine("Текущий месяц Ноябрь");
                    break;
                case (int)Months.Декабрь:
                    Console.WriteLine("Текущий месяц Декабрь");
                    if (averageTemp > 0)
                    {
                        Console.WriteLine("Дождливая зима");
                    }
                    break;
                default:
                    break;
            }

            Console.ReadKey();
        }
    }
}
