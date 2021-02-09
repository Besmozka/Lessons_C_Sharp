using System;
using System.Collections;
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

        public Node BFSmethod(SimpleGraph graph, string searchValue)
        {

            if (graph.Nodes == null)
            {
                Console.WriteLine("Такой граф не сущетсвует");
                return null; 
            }                
            var queue = new Queue();
            var visitedNodes = new Node[graph.Nodes.Count];
            var currentNodes = new Node[graph.Nodes.Count];
            var notVisitedNodes = new Node[graph.Nodes.Count];
            for (int i = 0; i < graph.Nodes.Count - 1; i++)
            {
                notVisitedNodes[i] = graph.Nodes[i];
            }
            currentNodes[0] = graph.Nodes[0];
            Console.WriteLine($"Заносим первый элемент в очередь: {graph.Nodes[0].Value}");
            while (true)
            {
                if (queue.Count == 0)
                {
                    Console.WriteLine($"Значение {searchValue} в графе не найдено");
                    return null;
                }
                for (int i = 0; i < currentNodes.Length - 1; i++)
                {
                    if (currentNodes[i].Value == searchValue)
                    {
                        Console.WriteLine("Значение найдено");
                        return currentNodes[i];
                    }
                    else
                    {
                        for (int j = 0; j < currentNodes[i].Edges.Count; j++)
                        {
                            currentNodes[i].Edges.Keys.
                        }
                    }
                }
            }            
        }
        public void DFSmethod(SimpleGraph graph, string searchValue)
        {

        }
    }
}
