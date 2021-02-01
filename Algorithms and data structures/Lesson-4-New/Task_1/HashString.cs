using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1
{
    public class HashString
    {
        public string value { get; set; }

        public override bool Equals(object obj)
        {
            var hashString = obj as HashString;

            if (hashString == null)
                return false;

            return value == hashString.value;
        }

        public override int GetHashCode()
        {
            int hashCode = value?.GetHashCode() ?? 0;
            return hashCode;
        }

    }
}
