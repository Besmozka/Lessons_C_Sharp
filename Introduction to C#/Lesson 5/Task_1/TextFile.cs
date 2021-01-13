using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task_1
{
    public class TextFile
    {
        public string fileName = "text.txt";
        public string WriteText {            
            set {
                File.WriteAllText(fileName, value);                
            }
        }


    }
}
