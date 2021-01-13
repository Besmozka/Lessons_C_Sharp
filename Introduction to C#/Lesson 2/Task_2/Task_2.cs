using System;

namespace Lesson_2
{
    class Task_2
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
            string currentMonth = null;


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
                    break;
                case (int)Months.Февраль:
                    Console.WriteLine("Текущий месяц Февраль");
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
                    break;
                default:
                    break;
            }
            Console.ReadKey();

        }
    }
}
