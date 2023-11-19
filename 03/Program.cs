using System;
using System.Collections;
using System.Collections.Generic;

namespace _03 {
    class Program {
        static void Main(string[] args) {
            int[] arrInput = { 19, -10, 12, -6, -3, 34, -2, 5 };
            List<int> positive = new List<int>();
            Queue queue = new Queue();
            
            foreach(int item in arrInput) {
                queue.Enqueue(item);
            }

            
            while(queue.Count > 0) {
                int num = Convert.ToInt32(queue.Dequeue());

                if (num > 0)
                    positive.Add(num);
            }

            Console.WriteLine(string.Join(" ", positive));
        }
    }
}
