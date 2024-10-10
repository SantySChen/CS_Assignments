using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class MyList<T>
    {
        private List<T> _list;

        public MyList()
        {
            _list = new List<T>();
        }

        void Add(T element)
        {
            _list.Add(element);
        }

        T Remove(int index)
        {
            T element = _list[index];
            _list.RemoveAt(index);
            return element;
        }

        bool Contains(T element)
        {
            return _list.Contains(element);
        }

        void Clear()
        {
            _list.Clear();
        }

        void InsertAt(T element, int index)
        {
            _list.Insert(index, element);
        }

        void DeleteAt(int index)
        {
            _list.RemoveAt(index);
        }

        T Find(int index)
        {
            return _list[index];
        }
    }
}
