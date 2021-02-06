using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_4
{
    public class Node
    {
        public int Data { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }
        public Node Parent { get; set; }

        public Node(int _Data)
        {
            Data = _Data;
        }

        public Node()
        {

        }
    }
}
