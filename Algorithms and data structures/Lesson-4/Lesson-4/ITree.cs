using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_4
{
    public interface ITree
    {
        int count { get; set; }  // количество элементов в дереве
        void AddData(int value);
        void AddNode(Node node);// добавление элемента        
        void DeleteData(int value);
        void DeleteNode(Node node); //удаление элемента
        Node SeachData(int value); //поиск элемента
        void BalanceTree(); //баланс дерева
        void DrawTree(); //нарисовать дерево
    }
}
