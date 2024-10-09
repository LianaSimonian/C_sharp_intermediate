using System;
using System.Collections.Generic;

namespace Stack
{
    internal class Stack
    {
        private readonly List<object> _stack = new List<object>();
        public int Top { get;private set; }
        public Stack()
        {
            Top = -1;
        }

        public void Push(object obj)
        {
            if (obj == null)
                throw new InvalidOperationException("Null value cannot be added to a stack");
            _stack.Add(obj);
            Top++;
        }
        public Object Pop()
        {
            if(IsEmpty())
                throw new InvalidOperationException("Cannot pop from an empty stack ");

            var item = _stack[Top];
            _stack.RemoveAt(Top--);
            return item;
        }

        public void Clear()
        {
            if (IsEmpty()) return;
            _stack.Clear();
        }

        public bool IsEmpty()
        {
            return Top == -1;
        }
    }
}