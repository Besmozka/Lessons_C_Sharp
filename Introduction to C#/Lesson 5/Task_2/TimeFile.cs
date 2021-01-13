using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task_2
{
    public class TimeFile
    {
        private string fileName = "startup.txt";
        public string WriteText {            
            set {
                if (File.Exists(fileName))        
                    File.AppendAllText(fileName, "\nЭтот файл был открыт в: " + value);
                else
                    File.AppendAllText(fileName, "Этот файл был создан в: " + value);
                //File.Exists(fileName) ? File.AppendAllText(fileName, "\nЭтот файл был открыт в: " + value) : File.AppendAllText(fileName, "Этот файл был создан в: " + value);  Николай, не могу разобраться почему тут нельзя использовать тернарный оператор
            }
        }


    }
}
