using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class MyStack<T>
    {
        private List<T> _stack;
        public MyStack() 
        { 
            _stack = new List<T>();
        }
        int Count()
        {
            return _stack.Count;
        }

        T Pop()
        {
            if (_stack.Count == 0)
            {
                throw new InvalidOperationException();
            }
            T item = _stack[_stack.Count - 1];
            _stack.RemoveAt(_stack.Count - 1);
            return item;
        }

        void Push(T item)
        {
            _stack.Add(item);
        }
    }
}
