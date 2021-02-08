using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_6_Graphs_
{
    interface ISimpleGraph
    {
        public void AddNode(string value);
        public void AddEdge(Node fromNode, Node toNode, int weight);

    }
}
