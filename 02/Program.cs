using System;
using System.Collections;

namespace _02 {
    class Program {
        static void Main(string[] args) {
            Stack stack = new Stack();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) {
                stack.Push(Console.ReadLine());
            }

            while (stack.Count > 0) {
                Console.WriteLine(stack.Pop());
            }
        }
    }
}
