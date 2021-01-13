﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Task3
    {
        enum Seasons
        {
            Winter,
            Spring,
            Summer,
            Autumn
        }
        static void Main(string[] args)
        {
            int monthNumber;
            while (true)
            {
                Console.Write("Введите порядковый номер месяца: ");
                monthNumber = Convert.ToInt32(Console.ReadLine());
                if (monthNumber > 0 && monthNumber <= 12)
                    break;
                else
                    Console.WriteLine("Ошибка: введите число от 1 до 12!");
            }
            Console.WriteLine($"Время года: {WriteSeason(CheckSeason(monthNumber))}");
            Console.ReadKey();
        }

        static Seasons CheckSeason(int monthNumber)
        {
            Seasons currentSeason = 0;
            switch (monthNumber)
            {
                case 12:
                case 1:
                case 2:
                    currentSeason = Seasons.Winter;
                    break;
                case 3:
                case 4:
                case 5:
                    currentSeason = Seasons.Spring;
                    break;
                case 6:
                case 7:
                case 8:
                    currentSeason = Seasons.Summer;
                    break;
                case 9:
                case 10:
                case 11:
                    currentSeason = Seasons.Autumn;
                    break;
                default:
                    break;
            }
            return currentSeason;
        }

        static string WriteSeason(Seasons currentSeason)
        {
            string season = null;
            switch (currentSeason)
            {
                case Seasons.Winter:
                    season = "Зима";
                    break;
                case Seasons.Spring:
                    season = "Весна";
                    break;
                case Seasons.Summer:
                    season = "Лето";
                    break;
                case Seasons.Autumn:
                    season = "Осень";
                    break;
                default:
                    break;
            }
            return season;
        }
    }
}
