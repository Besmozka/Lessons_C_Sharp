using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_5
{
    public interface IBinaryTree
    {
        int count { get; set; }  // количество элементов в дереве
        void AddData(int value);
        void DeleteData(int value);
    }
}