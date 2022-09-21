using System;
using System.Collections.Generic;

namespace BaseBall
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[] ops = new string[] { "5", "2", "C", "D", "+" };
            int result=CalPoints(ops);
            Console.WriteLine("Game Sum is:{0}", result);
            Console.ReadLine();
        }

        public static int CalPoints(string[] operations)
        {
            Stack<int> result = new Stack<int>();
            foreach (string operation in operations)
            {
                switch (operation)
                {
                    case "D":
                        result.Push(result.Peek() * 2);
                        break;
                    case "+":
                        var lastElement = result.Pop();
                        var newElement = lastElement + result.Peek();
                        result.Push(lastElement);
                        result.Push(newElement);
                        break;
                    case "C":
                        result.Pop();
                        break;
                    default:
                        result.Push(Convert.ToInt32(operation));
                        break;
                }
            }
            int sum = 0;
            while (result.Count > 0)
            {
                sum += result.Pop();
            }
            return sum;
        }
    }
}
