using System;
using System.Collections.Generic;
using System.Linq;

namespace _04 {
    class Program {
        static void Main(string[] args) {
            int[] input ="4 2 2 5 2 3 2 3 1 5 2".Split(' ').Select(int.Parse).ToArray();
            List<int> updated = new List<int>();

            for (int a = 0; a < input.Count(); a++) {
                int counter = -1;
                for (int b = 0; b < input.Count(); b++) {
                    if (input[a] == input[b])
                        counter++;
                }

                if(counter % 2 != 0)
                    updated.Add(input[a]);
            }

            Console.WriteLine(string.Join(" ", updated));
        }
    }
}
