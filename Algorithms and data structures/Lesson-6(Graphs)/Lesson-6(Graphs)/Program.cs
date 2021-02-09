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
            graph.AddEdge(graph.Nodes[0], graph.Nodes[1], 10);
            graph.AddEdge(graph.Nodes[1], graph.Nodes[2], 10);
            graph.AddEdge(graph.Nodes[2], graph.Nodes[3], 1);
            graph.AddEdge(graph.Nodes[4], graph.Nodes[3], 7);
            graph.AddEdge(graph.Nodes[4], graph.Nodes[5], 120);
            graph.AddEdge(graph.Nodes[5], graph.Nodes[1], 40);
            graph.AddEdge(graph.Nodes[4], graph.Nodes[2], 13);
            graph.AddEdge(graph.Nodes[5], graph.Nodes[2], 11);
            BFSmethod(graph, "Five");
            Console.ReadLine();
        }

        public static Node BFSmethod(SimpleGraph graph, string searchValue)
        {

            if (graph.Nodes == null)
            {
                Console.WriteLine("Такой граф не сущетсвует");
                return null; 
            }                
            var queue = new Queue();
            var visitedNodes = new List<Node>();
            var currentNodes = new List<Node>();
            var notVisitedNodes = new List<Node>();
            Node tempNode = null;
            notVisitedNodes.AddRange(graph.Nodes);
            queue.Enqueue(graph.Nodes[0]);
            Console.WriteLine($"Заносим первый элемент в очередь: {graph.Nodes[0].Value}");
            while (true)
            {
                if (queue.Count == 0)
                {
                    Console.WriteLine($"Значение {searchValue} в графе не найдено");
                    return null;
                }
                for (int i = 0; i < queue.Count; i++)
                {             
                    tempNode = (Node)queue.Dequeue();
                    Console.WriteLine($"Извлекаем из очереди в список Проверяемых: {tempNode.Value}");
                    currentNodes.Add(tempNode);
                }

                for (int i = 0; i < currentNodes.Count; i++)
                {
                    if (currentNodes[i].Value == searchValue)
                    {
                        Console.WriteLine("Значение найдено");
                        return currentNodes[i];
                    }
                    else
                    {
                        if (!visitedNodes.Contains(currentNodes[i]))
                        {
                            foreach (KeyValuePair<Node, int> edgeNodes in currentNodes[i].Edges)
                            {
                                Console.WriteLine($"Добавляем в очередь: {edgeNodes.Key.Value} и удаляем его из списка Непроверенных");
                                queue.Enqueue(edgeNodes.Key);
                                notVisitedNodes.Remove(edgeNodes.Key);
                            }
                        }
                        else
                        {
                            Console.WriteLine($"{currentNodes[i].Value} есть в списке Проверенных, пропускаем");
                        }
                    }
                }
                Console.WriteLine("Добавляем все ноды из списка Проверяемых в список Проверенных, и очищаем список Проверяемых");
                visitedNodes.AddRange(currentNodes);
                currentNodes.Clear();
            }            
        }
        public static void DFSmethod(SimpleGraph graph, string searchValue)
        {

        }
    }
}
