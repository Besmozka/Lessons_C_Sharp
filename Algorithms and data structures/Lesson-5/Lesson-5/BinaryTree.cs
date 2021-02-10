using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_5
{
    public class BinaryTree : IBinaryTree
    {
        public int count { get; set; }

        public Node Root;

        public void PrintTree()
        {
            PrintBinaryTree.Print(Root);
        }
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
                        Console.WriteLine("Такого элемента нет в дереве");
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
                            Console.WriteLine("Такого элемента нет в дереве");
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
    }
}