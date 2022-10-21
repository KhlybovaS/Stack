using System;

namespace Stack.CustomStack
{
    public class CustomStack<T> 
    {
        int AmountOfElements = 5;
        T[] stack;
        int top = -1;

        public CustomStack(int AmountOfElements)
        {
            stack = new T[AmountOfElements];
        }

        public int push(T Element)
        {
            if (top == AmountOfElements - 1)
            {
                throw new InvalidOperationException("Stack overflow");
            }
            else 
            {
                top = top + 1;
                stack[top] = Element;
            }
            
            return 0;
        }

        public T pop()
        {
            T RemovedElement;
            if (top >= 0)
            {
                RemovedElement = stack[top];
                top = top - 1;
                return RemovedElement;
            }
            return default(T);
        }

        public T[] GetStackElements()
        {
            T[] Elements = new T[top + 1];
            Array.Copy(stack, 0, Elements, 0, top + 1);
            return Elements;
        }
    }
}
