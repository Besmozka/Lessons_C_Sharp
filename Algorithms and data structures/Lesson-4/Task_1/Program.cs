using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {           
            BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);
        }
        
        public class BenchmarkClass
        {
            public static string findString = "ADBCF";
            public static int size = 10000;
            public static HashSet<string> hashSet = GetHashSpreadSheet(size);
            public static string[] array = GetArray(size);

            public static string[] GetArray(int size)
            {
                var array = new string[size];
                for (int i = 0; i < array.Length - 1; i++)
                {
                    var randomString = GenerateRandomString("ABCDEF", 5);
                    array[i] = randomString;                    
                }
                return array;
            }   
            
            public static HashSet<string> GetHashSpreadSheet(int size)
            {
                HashSet<string> hashSet = new HashSet<string>();
                for (int i = 0; i < size; i++)
                {
                    hashSet.Add(GenerateRandomString("ABCDEF", 5));
                }
                return hashSet;
            }
            public static string GenerateRandomString(string alphabet, int length)
            {
                Random rnd = new Random();
                StringBuilder sb = new StringBuilder(length - 1);
                int Position = 0;

                for (int i = 0; i < length; i++)
                {
                    Position = rnd.Next(0, alphabet.Length - 1);
                    sb.Append(alphabet[Position]);
                }
                return sb.ToString();
            }

            //[Benchmark]

            //public bool TestArray()
            //{
            //    foreach (var item in array)
            //        if (String.Compare(item, findString) == 0)
            //            return true;
            //    return false;
            //}
            [Benchmark]

            public bool TestHashSet()
            {
                return hashSet.Contains(findString);
            }
            
        }
    }
}
