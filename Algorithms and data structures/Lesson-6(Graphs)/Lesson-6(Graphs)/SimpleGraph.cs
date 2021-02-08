using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_6_Graphs_
{
    class SimpleGraph: ISimpleGraph
    {
        public List<Node> Nodes = new List<Node>();

        public void AddNode(string value)
        {
            if (value != null)
            {
                var node = new Node()
                {
                    Value = value,
                    Edges = new Dictionary<Node, int>()
                };
                Nodes.Add(node);
            }
            else
            {
                Console.WriteLine("Введите содержимое");
                return;
            }
        }

        public void AddEdge(Node fromNode, Node toNode, int weight)
        {
            if (fromNode != null && toNode != null)
            {
                fromNode.Edges.Add(toNode, weight);
                toNode.Edges.Add(fromNode, weight);
            }
            else
            {
                Console.WriteLine("Одно из значений не существует");
                return;
            }
        }
    }
}
