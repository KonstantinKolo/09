using System;
using System.Collections.Generic;
using System.Linq;

namespace _01 {
    class Program {
        static void Main(string[] args) {
            //1 2 3 4 5 6
            string input = Console.ReadLine();
            List<uint> list = input.Split(' ').Select(uint.Parse).ToList();

            uint sum = 0;
            double average = 0;

            foreach(var item in list) {
                sum += item;
            }
            average = Convert.ToDouble(sum) / Convert.ToDouble(list.Count());

            Console.WriteLine($"sum: {sum}\naverage: {average:F2}");
        }
    }
}
