using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    internal class LinQ
    {
        public static void IntroLinq()
        {
            int[] numbers = new int[] { 98, 99, 200, 95, 97, 94, 80, 2019 };
            var sum = numbers.Sum(x => x++);
            Console.Write($"Sum : {sum}");


            var min = numbers.Min();
            Console.WriteLine("\nMin : " + min);

            var max = numbers.Max();
            Console.WriteLine("Max : " + max);

            var duplicatest = numbers.Distinct();
            foreach (var item in duplicatest)
            {
                Console.WriteLine(item);
            }
        }
    }
}