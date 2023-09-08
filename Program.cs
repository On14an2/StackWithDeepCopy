using System;
using StackQuestion;
class Program
{
    static void Main()
    {
        Console.Write("Введите размер стека:");
        int size = int.Parse(Console.ReadLine());
        int count = 0;
        LimitedStack<int> stack = new LimitedStack<int>(size);
        string input = null;
        bool overflow = true;
        while (overflow)
        {
            if (count < size)
            {
                Console.Write("Введите элемент: ");
                input = Console.ReadLine();
                int item = int.Parse(input);
                stack.Push(item);
                count++;
            }
            LimitedStack<int> copiedStack = new LimitedStack<int>(stack);
            if (count >= size)
            {
                while (!stack.IsEmpty)
                {
                    Console.WriteLine(stack.Pop());
                }
                overflow = false;
                Console.WriteLine("copy");
                while (!copiedStack.IsEmpty)
                {
                    Console.WriteLine(copiedStack.Pop());
                }
            }
        }
    }
}