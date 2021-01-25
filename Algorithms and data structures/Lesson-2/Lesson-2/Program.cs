using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class LinkedList : ILinkedList
    {
        private int count;

        public Node Head { get; set; }

        public Node Tail { get; set; }


        public void AddNode(int value)
        {
            var newNode = new Node { Value = value };

            if (Head == null)
            {
                Head = newNode;
                Tail = newNode;
                count = 1;
            }
            else
            {
                Tail.NextNode = newNode;
                newNode.PrevNode = Tail;
                Tail = newNode;
                count++;
            }
        }

        public void AddNodeAfter(Node node, int value)
        {
            var newNode = new Node { Value = value };
            var NextNode = node.NextNode;
            var PrevNode = node.PrevNode;
            node.NextNode = newNode;
            newNode.NextNode = NextNode;
            newNode.PrevNode = PrevNode;
            NextNode.PrevNode = newNode;
            count++;
        }

        public Node FindNode(int searchValue)
        {
            var currentNode = Head;
            var numberNode = 1;
            while (currentNode != null)
            {
                if (currentNode.Value == searchValue)
                {
                    Console.WriteLine($"Номер найденной ноды: {numberNode}");
                    return currentNode;
                }
                else
                {
                    currentNode = currentNode.NextNode;
                    numberNode++;
                }

            }

            return null;
        }

        public int GetCount()
        {
            return count;
        }

        public void RemoveNode(int index)
        {
            var currentNode = Head;
            var numberNode = 1;
            while (currentNode != null)
            {
                if (numberNode == index)
                {
                    var nextNode = currentNode.NextNode;
                    var prevNode = currentNode.PrevNode;
                    prevNode.NextNode = nextNode;
                    nextNode.PrevNode = prevNode;
                    count--;
                    return;
                }
                else
                {
                    currentNode = currentNode.NextNode;
                    numberNode++;
                }
            }
        }

        public void RemoveNode(Node node)
        {
            var nextNode = node.NextNode;
            var prevNode = node.PrevNode;
            prevNode.NextNode = nextNode;
            nextNode.PrevNode = prevNode;
            count--;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var linkedList = new LinkedList();
            linkedList.AddNode(10);
            linkedList.AddNode(20);
            linkedList.AddNode(30);
            linkedList.AddNode(40);
            linkedList.AddNode(50);
            linkedList.AddNode(60);
            linkedList.AddNode(70);
            DisplayList(linkedList);

            Console.WriteLine($"Длина списка: {linkedList.GetCount()}");

            int userValue;
            while (true)
            {
                Console.Write("Введите значение поиска: ");
                if (int.TryParse(Console.ReadLine(), out userValue))
                    break;
            }
            linkedList.FindNode(userValue);

            while (true)
            {
                Console.Write("Удалить запись под номером: ");
                if (int.TryParse(Console.ReadLine(), out userValue))
                    break;
            }
            linkedList.RemoveNode(userValue);
            DisplayList(linkedList);

            while (true)
            {
                Console.Write("Введите число для добавления записи: ");
                if (int.TryParse(Console.ReadLine(), out userValue))
                    break;
            }
            linkedList.AddNodeAfter(linkedList.Head.NextNode, userValue);
            DisplayList(linkedList);

            linkedList.RemoveNode(linkedList.Tail.PrevNode);
            DisplayList(linkedList);

            Console.ReadKey();
        }

        static void DisplayList(LinkedList linkedList)
        {
            var currentNode = linkedList.Head;
            while (currentNode != null)
            {
                Console.WriteLine(currentNode.Value);
                currentNode = currentNode.NextNode;
            }
        }
    }  
}
