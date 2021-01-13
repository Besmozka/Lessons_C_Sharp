using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    class ToDo
    {
        public ToDo()
        {
            _Title = "Пусто";
            _isDone = false;
        }
        public string _Title { get; set; }
        public bool _isDone { get; set; }
    }
}
