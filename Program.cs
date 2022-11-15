using System;

namespace StackProject
{
    public class stack<T>
    {
        private T[] stackData = new T[10];
        private const int  STACK_MAX = 10;
        private int stackPtr = 0;

        public void push(T n) {
            if (stackPtr < STACK_MAX)
            {
                stackData[stackPtr] = n;
                stackPtr++;
            }
            else
            {
                Console.WriteLine("Stack Oveflow");
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Stack attack!");
            stack <int> myStack = new stack<int>();
            for (int i = 0; i<11; i++) {
                myStack.push(i);
            }
            stack<string> newStack = new stack<string>();
            newStack.push("Apples");

        }
    }
}
