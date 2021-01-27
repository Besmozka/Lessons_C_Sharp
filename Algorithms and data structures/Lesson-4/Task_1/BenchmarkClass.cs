using System;
using System.Collections.Generic;
using System.Text;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace Task_1
{
    public class BenchmarkClass
    {
        public static string findString = "ADBCF";
        static int size = 10000;
        public static HashSet<HashString> hashSet = GetHashSpreadSheet(size);
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

        public static HashSet<HashString> GetHashSpreadSheet(int size)
        {
            var hashSet = new HashSet<HashString>();
            for (int i = 0; i < size; i++)
            {
                var hashString = new HashString();
                hashString.value = GenerateRandomString("ABCDEF", 5);
                hashSet.Add(hashString);
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
        public static bool GetHash()
        {
            var hashString = new HashString();
            hashString.value = findString;
            return hashSet.Contains(hashString);
        }

        [Benchmark]
        public bool TestArray()
        {
            foreach (var item in array)
                if (String.Compare(item, findString) == 0)
                    return true;
            return false;
        }
        [Benchmark]
        public bool TestHashSet()
        {
            var hashString = new HashString();
            hashString.value = findString;
            if (hashSet.Contains(hashString))
                return true;
            return false;
        }

    }
}
