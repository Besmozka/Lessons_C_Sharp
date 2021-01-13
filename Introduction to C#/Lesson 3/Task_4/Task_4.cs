using System;
namespace Task_4
{
    class Task_4
    {
        static void Main(string[] args)
        {
            Console.Write("Задайте размерность поля кратно двум (от 10 до 26 максимум): ");
            int fieldSize = Convert.ToInt32(Console.ReadLine());
            char emptyField = 'O';
            char deckShip = 'X';
            char[,] gameField = new char[fieldSize, fieldSize];
            Random rnd = new Random();
            int shipLength = 4;
            for (int i = 0; i < gameField.GetLength(0); i++)                            // Заполнение поля
            {
                for (int j = 0; j < gameField.GetLength(1); j++)
                {
                    gameField[i, j] = emptyField;
                }
            }
            for (int j = 0; j < 10; j++) //общее количество кораблей на поле
            {
                if (j == 1)
                    shipLength = 3;
                if (j == 3)
                    shipLength = 2;
                if (j == 6)
                    shipLength = 1;
                bool shipsDone = false;
                while (!shipsDone)     //выполняется пока корабль не будет установлен
                {
                    int columnRandom = rnd.Next(0, gameField.GetLength(1));    // радномные координаты
                    int rowRandom = rnd.Next(0, gameField.GetLength(0));       // радномные координаты
                    bool newCircle = false;
                    bool canBuild = true;
                    if (rowRandom >= columnRandom)    // построить в строку или в ряд
                    {
                        for (int q = -1; q < shipLength + 1; q++)      // циклы проверки клеток поля на возможность установки корабля
                        {
                            for (int w = -1; w < 2; w++)
                            {
                                if (gameField.GetLength(1) > columnRandom + shipLength)
                                {
                                    if (rowRandom + w >= 0 && columnRandom + q >= 0 && gameField.GetLength(0) > rowRandom + w && gameField.GetLength(1) > columnRandom + q)   //проверка на выход за пределы тгрового поля(массива)
                                        if (gameField[rowRandom + w, columnRandom + q] == emptyField)    //проверка на уже устанвленный корабль
                                            canBuild = true;
                                        else
                                        {
                                            canBuild = false;
                                            newCircle = true;
                                            break;
                                        }
                                }
                                else
                                    canBuild = false;
                            }
                            if (newCircle)
                                break;
                        }
                        if (canBuild)  // постройка корабля
                            for (int i = 0; i < shipLength; i++)
                            {
                                gameField[rowRandom, columnRandom + i] = deckShip;
                                if (i == shipLength - 1)
                                    shipsDone = true;
                            }
                    }
                    else
                    {
                        for (int q = -1; q < shipLength + 1; q++)
                        {
                            for (int w = -1; w < 2; w++)
                            {
                                if (gameField.GetLength(0) > rowRandom + shipLength)
                                {
                                    if (rowRandom + q >= 0 && columnRandom + w >= 0 && gameField.GetLength(0) > rowRandom + q && gameField.GetLength(1) > columnRandom + w)
                                        if (gameField[rowRandom + q, columnRandom + w] == emptyField)
                                            canBuild = true;
                                        else
                                        {
                                            canBuild = false;
                                            newCircle = true;
                                            break;
                                        }
                                }
                                else
                                    canBuild = false;
                            }
                            if (newCircle)
                                break;
                        }
                        if (canBuild)
                            for (int i = 0; i < shipLength; i++)
                            {
                                gameField[rowRandom + i, columnRandom] = deckShip;
                                if (i == shipLength - 1)
                                    shipsDone = true;
                            }
                    }
                }
            }

            Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop + 2);
            for (int i = 0; i < gameField.GetLength(0); i++)                        //Рисовка поля
            {
                if (i == 0)
                {
                    char[] nameColumn = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
                    Console.SetCursorPosition(3, Console.CursorTop);
                    for (int g = 0; g < gameField.GetLength(1); g++)
                    {
                        Console.Write($"{nameColumn[g]} ");
                    }
                    Console.WriteLine();
                }
                if (i < 9)
                    Console.Write($"{i + 1}  ");
                else
                    Console.Write($"{i + 1} ");
                for (int j = 0; j < gameField.GetLength(1); j++)
                {
                    Console.Write($"{gameField[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}