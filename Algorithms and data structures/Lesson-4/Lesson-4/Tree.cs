using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_4
{
    public class Tree : ITree
    {
        public  int count { get; set; }

        public Node Root;

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

        public void BalanceTree()
        {

        }

        public void DrawTree()
        {
           
        }

        public Node SeachData(int value)
        {
            return Root;
        }

        public void PrintPretty(string indent, bool last)
        {
            Console.Write(indent);
            if (last)
            {
                Console.Write("└─");
                indent += "  ";
            }
            else
            {
                Console.Write("├─");
                indent += "| ";
            }
            Console.WriteLine(Data);

            var children = new List<BNode>();
            if (this.left != null)
                children.Add(this.left);
            if (this.right != null)
                children.Add(this.right);

            for (int i = 0; i < children.Count; i++)
                children[i].PrintPretty(indent, i == children.Count - 1);

        }
        ///// <summary>
        ///// Поиск узла по значению
        ///// </summary>
        ///// <param name="value">Искомое значение</param>
        ///// <param name="startWithNode">Узел начала поиска</param>
        ///// <returns>Найденный узел</returns>
        //public Node FindNode(int value, Node startWithNode = null)
        //{
        //    startWithNode = startWithNode ?? Root;
        //    int result;
        //    return (result = value.CompareTo(startWithNode.Data)) == 0
        //        ? startWithNode
        //        : result < 0
        //            ? startWithNode.LeftNode == null
        //                ? null
        //                : FindNode(value, startWithNode.LeftNode)
        //            : startWithNode.RightNode == null
        //                ? null
        //                : FindNode(value, startWithNode.RightNode);
        //}
        ///// <summary>
        ///// Вывод бинарного дерева
        ///// </summary>
        //public void PrintTree()
        //{
        //    PrintTree(Root);
        //}

        ///// <summary>
        ///// Вывод бинарного дерева начиная с указанного узла
        ///// </summary>
        ///// <param name="startNode">Узел с которого начинается печать</param>
        ///// <param name="indent">Отступ</param>
        ///// <param name="side">Сторона</param>
        //private void PrintTree(Node startNode, string indent = "", Side? side = null)
        //{
        //    if (startNode != null)
        //    {
        //        var nodeSide = side == null ? "+" : side == Side.Left ? "L" : "R";
        //        Console.WriteLine($"{indent} [{nodeSide}]- {startNode.Data}");
        //        indent += new string(' ', 3);
        //        //рекурсивный вызов для левой и правой веток
        //        PrintTree(startNode.LeftNode, indent, Side.Left);
        //        PrintTree(startNode.RightNode, indent, Side.Right);
        //    }
        //}
    }
}
