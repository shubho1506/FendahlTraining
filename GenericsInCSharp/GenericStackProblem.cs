using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsInCSharp
{
    //Problem 2: Generic Stack Class
    //Implement a generic stack class MyStack<T> with methods Push, Pop, and Peek.
    //Ensure it works with different data types.
    class GenericStackProblem<T>
    {
        private List<T> stack = new List<T>();

        public void Push(T item) => stack.Add(item);
        public T Pop()
        {
            if (stack.Count == 0) throw new InvalidOperationException("Stack is empty.");
            T item = stack[stack.Count - 1];
            stack.RemoveAt(stack.Count - 1);
            return item;
        }
        public T Peek()
        {
            if (stack.Count == 0) throw new InvalidOperationException("Stack is empty.");
            return stack[stack.Count - 1];
        }
        public bool IsEmpty() => stack.Count == 0;
    }
}
