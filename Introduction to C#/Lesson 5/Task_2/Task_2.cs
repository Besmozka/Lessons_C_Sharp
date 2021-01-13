using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Task_2
    {
        static void Main(string[] args)
        {
            TimeFile addTime = new TimeFile();            
            addTime.WriteText = DateTime.Now.ToString("T");
            Console.ReadKey();
        }
    }
}
