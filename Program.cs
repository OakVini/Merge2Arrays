using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] first = new int[] { 3, 5, 6, 9, 12, 14, 18, 20, 25, 28 };
            int[] second = new int[] { 30, 32, 34, 36, 38, 40, 42, 44, 46, 48 };

            int[] result = first
              .Concat(second)
              .OrderBy(x => x)
              .ToArray();

            // 3, 5, 6, 9, 12, 14, 18, 20, 25, 28, 30, 32, 34, 36, 38, 40, 42, 44, 46, 48
            Console.Write(String.Join(", ", result));

            Console.ReadKey();
        }
    }
}
