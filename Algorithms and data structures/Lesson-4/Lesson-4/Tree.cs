using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_4
{
    public class Tree : ITree
    {
        public int count { get; set; }

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
                        }
                    }
                    else 
                        if (value < tmp.Data)
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
                            }
                        }
                        else
                        {
                            throw new Exception("Wrong tree state");                  // Дерево построено неправильно
                        }

                }
            count++;
        }

        public void DeleteData(int value)
        {
            var tmp = Root;
            while (tmp != null)
            {
                if (tmp.Data == value)
                {
                    tmp.Data = tmp.Right.Data;
                    tmp = tmp.Right;
                    DeleteData(tmp.Right.Data);
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
            throw new NotImplementedException();
        }
    }
}
