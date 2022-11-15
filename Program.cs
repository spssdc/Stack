using System;

namespace StackProject
{
    public class stack
    {
        private int[] stackData = new int[10];
        private const int  STACK_MAX = 10;
        private int stackPtr = 0;

        public void push(int n) {
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
            stack myStack = new stack();
            for (int i = 0; i<11; i++) {
                myStack.push(i);
            }

        }
    }
}
