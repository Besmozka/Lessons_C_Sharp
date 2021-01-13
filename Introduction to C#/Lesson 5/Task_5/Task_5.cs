using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;

namespace Task_5
{
    class Task_5
    {
        static void Main(string[] args)
        {
            ToDo[] toDoList = new ToDo[1];
            string path = @"C:\New\ToDo.json";
            CheckCreatedList(path,ref toDoList);
            while (true)
            {
                DisplayMenu();
                int userChoise = ReadInt();
                if (userChoise >= 1 && userChoise <= 5)
                    switch (userChoise)
                    {
                        case 1: // вывести список
                            Console.Clear();
                            DisplayToDoList(toDoList);
                            Console.WriteLine("Нажмите любую клавишу для возврата к меню");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case 2:  // добавить задачу
                            Console.Clear();
                            Console.Write("Введите задачу: ");
                            AddTask(ref toDoList, Console.ReadLine());
                            Console.Clear();
                            break;
                        case 3: // выполнить задачу
                            Console.Write("Введите номер выполненной задачи: ");
                            userChoise = ReadInt();
                            if (userChoise > 0 && userChoise < toDoList.Length)
                            {
                                toDoList[userChoise - 1]._isDone = true;
                                toDoList[userChoise - 1]._Title = "[x] " + toDoList[userChoise - 1]._Title;
                            }
                            else
                            {
                                Console.WriteLine($"Задача с номером {userChoise} еще не создана. Нажмите любую клавишу для возврата к меню");
                                Console.ReadKey();
                            }
                            Console.Clear();
                            break;
                        case 4: // записать список в json
                            SaveJson(toDoList, path);
                            break;
                        case 5: // выход
                            return;
                        default:
                            break;
                    }
            }
        }        


        static int ReadInt()
        {
            int intValue = 0;
            if (int.TryParse(Console.ReadLine(), out intValue))
                return intValue;
            else
            {
                Console.WriteLine("Неверный формат");
                intValue = ReadInt();
            }
            return intValue;           
        }

        static void CheckCreatedList(string path, ref ToDo[] toDoList)
        {
            if (File.Exists(path))
            {
                string[] json = File.ReadAllLines(@"C:\New\ToDo.json");
                Array.Resize(ref toDoList, json.Length);
                for (int i = 0; i < json.Length; i++)
                    toDoList[i] = JsonSerializer.Deserialize<ToDo>(json[i]);
                Console.WriteLine("Список задач скопирован из файла: " + path);
            }
        }

        static void DisplayMenu()
        {
            Console.WriteLine(@"Введите номер действия:
  Вывести весь список задач - 1
  Добавить задачу - 2
  Выполнить задачу - 3
  Записать список в task.json - 4
  Закрыть программу - 5");
            return;
        }

        public static void DisplayToDoList(ToDo[] toDoList)
        {
            Console.WriteLine("Список задач (ToDo-list):");
            for (int i = 0; i < toDoList.Length - 1; i++)
                Console.WriteLine($"{i + 1}. {toDoList[i]._Title}");

        }

        static void AddTask(ref ToDo[] toDoList, string task)
        {         
                toDoList[toDoList.Length - 1] = new ToDo();
                toDoList[toDoList.Length - 1]._Title = task;
                Array.Resize(ref toDoList, toDoList.Length + 1);
        }

        static void SaveJson(ToDo[] toDoList, string path)
        {
            File.Delete(path);
            for (int i = 0; i < toDoList.Length - 1; i++)
            {
                string json = JsonSerializer.Serialize(toDoList[i]);
                File.AppendAllText(path, json + "\n");
            }
        }
    }
}
