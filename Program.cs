using System;
using Stack.CustomStack;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        { 
            /*add elements to stack*/
            int AmountOfElements = 5;
            CustomStack<int> stack = new CustomStack<int>(AmountOfElements);
            for (int i = 0; i < AmountOfElements; i++)
            {
                stack.push(i);
            }
            
            int[] Elements = stack.GetStackElements();
            Console.WriteLine("Stack Content");
            foreach (int str in Elements)
                {
                    Console.WriteLine(str);
                }

            /*delete elements from stack*/
            for (int i = 0; i < AmountOfElements - 2; i++)
            {
                stack.pop();
            }

            Elements = stack.GetStackElements();
            Console.WriteLine("Stack Content");
            foreach (int str in Elements)
                {
                    Console.WriteLine(str);
                }    
        }
    }
}
