using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1
{
    public class HashInt
    {
        public string value { get; set; }

        public override bool Equals(object obj)
        {
            var hashInt = obj as HashInt;

            if (hashInt == null)
                return false;

            return value == hashInt.value;
        }

        public override int GetHashCode()
        {
            int hashCode = value?.GetHashCode() ?? 0;            
            return hashCode;
        }

    }
}
