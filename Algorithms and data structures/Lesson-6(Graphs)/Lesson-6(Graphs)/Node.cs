using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_6_Graphs_
{
    class Node
    {
        public string Value { get; set; }

        public Dictionary<Node, int> Edges { get; set; }
    }
}
