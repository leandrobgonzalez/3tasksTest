using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace verizon_stack_2
{
    class Program
    {

        static void Main()
        {

            string S = "3 DUP 5 - -";
            Stack<int> stack = new Stack<int>();

            string[] commands = S.Split(' ');
            foreach (var item in commands)
            {
                switch (item)
                {
                    case "POP":
                        stack.Pop();
                        break;
                    case "DUP":
                        stack.Push(stack.Peek());
                        break;
                    case "+":
                        int sum = stack.ElementAt(1) + stack.Peek();
                        stack.Pop();
                        stack.Pop();
                        stack.Push(sum);
                        break;
                    case "-":
                        int index = 0;
                        int subtract = -1;
                        if (stack.Count > 1)
                        {
                            subtract = stack.Peek() - stack.ElementAt(1);
                            index = 1;
                        }
                        stack.Pop();
                        if (stack.Count > 1)
                        {
                            stack.Pop();
                        }
                        stack.Push(subtract);
                        break;
                    default:
                        stack.Push(Convert.ToInt32(item));
                        break;
                }
            }
            Console.WriteLine(stack.Peek());
            Console.ReadLine();
        }
    }
}
