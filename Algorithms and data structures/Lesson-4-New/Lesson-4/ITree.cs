using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_4
{
    public interface ITree
    {
        int count { get; set; }
        void AddData(int value);
        void DeleteData(int value);
        void Print();
        public List<int> InorderList(Node node);
        Node SeachData(Node root, int value); 
        public Node BalancedTree(List<int> values, int min, int max);
    }
}
