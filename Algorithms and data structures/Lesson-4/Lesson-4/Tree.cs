using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_4
{
    public class Tree : ITree
    {
        public int count { get; set; }

        public Node Root;

        public int indexArray = 0;

        public void AddData(int value)
        {
            var newNode = new Node(value);
            var tmp = Root;
            if (Root == null)
                Root = newNode;
            else
                while (tmp != null)
                {
                    if (value > tmp.Data)
                    {
                        if (tmp.Right != null)
                        {
                            tmp = tmp.Right;
                            continue;
                        }
                        else
                        {
                            tmp.Right = new Node(value);
                            tmp.Right.Parent = tmp.Parent;
                            count++;
                            return;
                        }
                    }
                    else
                        if (value <= tmp.Data)
                    {
                        if (tmp.Left != null)
                        {
                            tmp = tmp.Left;
                            continue;
                        }
                        else
                        {
                            tmp.Left = new Node(value);
                            tmp.Left.Parent = tmp.Parent;
                            count++;
                            return;
                        }
                    }
                    else
                    {
                        throw new Exception("Данное дерево не дерево поиска");
                    }

                }
        }

        public void DeleteData(int value)
        {
            Node tmp = Root, parent = null;
            if (tmp.Data == value)
            {
                Console.WriteLine("Нельзя удалить корневой элемент");
                return;
            }
            while (true)
            {
                if (value < tmp.Data)
                {
                    if (tmp.Left != null)
                    {
                        parent = tmp;
                        tmp = tmp.Left;
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Не могу удалить несуществующий элемент");
                        return;
                    }
                }
                else
                {
                    if (value > tmp.Data)
                    {
                        if (tmp.Right != null)
                        {
                            parent = tmp;
                            tmp = tmp.Right;
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("Не могу удалить несуществующий элемент");
                            return;
                        }
                    }
                    else
                    {
                        if (tmp.Right != null)
                        {
                            while (tmp.Right != null)
                            {
                                tmp.Data = tmp.Right.Data;
                                parent = tmp;
                                tmp = tmp.Right;
                            }
                            parent.Right = tmp.Left;
                            count--;
                            return;
                        }
                        else if (tmp.Left != null)
                        {
                            while (tmp.Left != null)
                            {
                                tmp.Data = tmp.Left.Data;
                                parent = tmp;
                                tmp = tmp.Left;
                            }
                            parent.Left = tmp.Right;
                            count--;
                            return;
                        }
                        else if (parent.Right.Data == tmp.Data)
                        {
                            parent.Right = null;
                            count--;
                            return;
                        }
                        else
                        {
                            parent.Left = null;
                            count--;
                            return;
                        }
                    }
                }
            }
        }

        public void Print()
        {
            PrintTree.Print(Root);
        }

        public List<int> InorderList(Node node)
        {
            var list = new List<int>();
            if (Root == null)
            {
                Console.WriteLine("Дерева не существует");
                return null;
            }
            if (node.Left != null)
                list.AddRange(InorderList(node.Left));
            list.Add(node.Data);
            if (node.Right != null)
                list.AddRange(InorderList(node.Right));
            return list;
        }

        public Node BalancedTree(List<int> values, int min, int max)
        {
            if (min == max)
                return null;

            int median = min + (max - min) / 2;
            return new Node
            {
                Data = values[median],
                Left = BalancedTree(values, min, median),
                Right = BalancedTree(values, median + 1, max)
            };
        }

        public Node SeachData(Node root, int value)
        {
            if (root != null)
            {
                if (root.Data == value)
                {                    
                    Console.WriteLine("Найдено");
                    return root;
                }
                SeachData(root.Left, value);
                SeachData(root.Right, value);
            }
            return null;
        }
    }
}
