using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_6_Graphs_
{
    class Node
    {
        public object Value { get; set; }

        public List<Edge> Edges { get; set; }
    }
}
