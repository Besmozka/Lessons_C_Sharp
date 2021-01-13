using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task_3
{
    class Task_3
    {
        static void Main(string[] args)
        {
            Console.Write("Введите произвольный набор чисел от 0 до 255: ");
            string userNumber = Console.ReadLine();
            BinaryFile binaryFile = new BinaryFile();
            binaryFile.SetUserString = userNumber;            
            Console.ReadKey();
        }        
    }
}
