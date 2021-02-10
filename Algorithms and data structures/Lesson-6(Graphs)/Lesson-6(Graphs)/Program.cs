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
            Console.WriteLine();
            DFSmethod(graph, "Six");
            Console.ReadLine();
        }

        #region BFSmethod
        public static Node BFSmethod(SimpleGraph graph, string searchValue)
        {            
            var cycleNumber = 1;
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
                Console.WriteLine($"Цикл №{cycleNumber++}");

                if (queue.Count == 0) // если очередь на начало цикла пуста, то новых элементов для проверки нет
                {
                    Console.WriteLine($"Значение {searchValue} в графе не найдено");
                    return null;
                }

                while (queue.Count > 0) // пока очередь не будет пуста, берем из нее элемент и добавляем его в список Проверяемых
                {
                    tempNode = (Node)queue.Dequeue();
                    Console.WriteLine($"Извлекаем из очереди в список Проверяемых: {tempNode.Value}");
                    currentNodes.Add(tempNode);
                }

                for (int i = 0; i < currentNodes.Count; i++) // цикл от 0 до количества элементов в списке Проверяемых
                {
                    Console.WriteLine($"Проверяем значение {currentNodes[i].Value}");
                    if (currentNodes[i].Value == searchValue)
                    {
                        Console.WriteLine("Значение найдено");
                        return currentNodes[i];
                    }
                    else
                    {
                        foreach (KeyValuePair<Node, int> edgeNodes in currentNodes[i].Edges)
                        {
                            if (notVisitedNodes.Contains(edgeNodes.Key))
                            {
                                Console.WriteLine($"Добавляем в очередь: {edgeNodes.Key.Value} и удаляем его из списка Непроверенных");
                                queue.Enqueue(edgeNodes.Key);
                                notVisitedNodes.Remove(edgeNodes.Key);
                            }
                            else
                            {
                                Console.WriteLine($"{currentNodes[i].Value} есть в списке Проверенных, пропускаем");
                            }
                        }                                                
                    }
                }
                foreach (var node in currentNodes)
                {
                    Console.WriteLine($"Добавляем {node.Value} из списка Проверяемых в список Проверенных, и очищаем список Проверяемых");
                }                
                visitedNodes.AddRange(currentNodes);
                currentNodes.Clear();
            }            
        }

        #endregion

        #region DFSmethod

        public static Node DFSmethod(SimpleGraph graph, string searchValue)
        {
            var cycleNumber = 1;
            if (graph.Nodes == null)
            {
                Console.WriteLine("Такой граф не сущетсвует");
                return null;
            }
            var stack = new Stack();
            var visitedNodes = new List<Node>();
            var currentNodes = new List<Node>();
            var notVisitedNodes = new List<Node>();
            Node tempNode = null;

            notVisitedNodes.AddRange(graph.Nodes);

            stack.Push(graph.Nodes[0]);
            Console.WriteLine($"Заносим первый элемент в стэк: {graph.Nodes[0].Value}");

            while (true)
            {
                Console.WriteLine($"Цикл №{cycleNumber++}");

                if (stack.Count == 0)
                {
                    Console.WriteLine($"Значение {searchValue} в графе не найдено");
                    return null;
                }

                while (stack.Count > 0)
                {
                    tempNode = (Node)stack.Pop();
                    Console.WriteLine($"Извлекаем из стэка в список Проверяемых: {tempNode.Value}");
                    currentNodes.Add(tempNode);
                }

                for (int i = 0; i < currentNodes.Count; i++)
                {
                    Console.WriteLine($"Проверяем значение {currentNodes[i].Value}");
                    if (currentNodes[i].Value == searchValue)
                    {
                        Console.WriteLine("Значение найдено");
                        return currentNodes[i];
                    }
                    else
                    {
                        foreach (KeyValuePair<Node, int> edgeNodes in currentNodes[i].Edges)
                        {
                            if (notVisitedNodes.Contains(edgeNodes.Key))
                            {
                                Console.WriteLine($"Добавляем в стэк: {edgeNodes.Key.Value} и удаляем его из списка Непроверенных");
                                stack.Push(edgeNodes.Key);
                                notVisitedNodes.Remove(edgeNodes.Key);
                            }
                            else
                            {
                                Console.WriteLine($"{currentNodes[i].Value} есть в списке Проверенных, пропускаем");
                            }
                        }
                    }
                }
                foreach (var node in currentNodes)
                {
                    Console.WriteLine($"Добавляем {node.Value} из списка Проверяемых в список Проверенных, и очищаем список Проверяемых");
                }
                visitedNodes.AddRange(currentNodes);
                currentNodes.Clear();
            }
        }
        #endregion
    }
}
