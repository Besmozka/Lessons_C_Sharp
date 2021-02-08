using System;
using System.Collections.Generic;

namespace Lesson_6_Graphs_
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleGraph graph = new SimpleGraph();
            graph.AddNode("One");
            graph.AddNode("Two");
            graph.AddNode("Three");
            graph.AddNode("Four");
            graph.AddNode("Five");
            graph.AddNode("Six");
            graph.AddEdge(graph.Nodes[1], graph.Nodes[2], 10);
            graph.AddEdge(graph.Nodes[2], graph.Nodes[3], 1);
            graph.AddEdge(graph.Nodes[4], graph.Nodes[3], 7);
            graph.AddEdge(graph.Nodes[4], graph.Nodes[5], 120);
            graph.AddEdge(graph.Nodes[5], graph.Nodes[1], 40);
            graph.AddEdge(graph.Nodes[4], graph.Nodes[2], 13);
            graph.AddEdge(graph.Nodes[5], graph.Nodes[2], 11);
            Console.ReadLine();
        }

    }
}
