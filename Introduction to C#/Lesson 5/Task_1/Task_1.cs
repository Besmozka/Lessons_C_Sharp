using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Task_1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите любую строку:");
            string userText = Console.ReadLine();
            Console.WriteLine("Введите название файла: ");
            string userFileName = Console.ReadLine();
            TextFile textFile = new TextFile();
            textFile.fileName = userFileName + ".txt";
            textFile.WriteText = userText;
            Console.WriteLine($"Текст успешно записан в файл {textFile.fileName}");
            Console.ReadLine();
        }
    }
}
