using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task_3
{
    class BinaryFile
    {
        string fileName = "Binary.bin";
        public string SetUserString
        {
            set
            {
                SaveByteFile(value, fileName);
            }
        }

        private void SaveByteFile(string userString, string path)
        {
            char[] space = { ' ' };
            string[] numbers = userString.Split(space, StringSplitOptions.RemoveEmptyEntries);
            byte[] byteNumbers = new byte[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
                byteNumbers[i] = Convert.ToByte(numbers[i]);
            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate)))
                foreach (var byteNumber in byteNumbers)
                    writer.Write(byteNumber);            
        }       
    }
}
