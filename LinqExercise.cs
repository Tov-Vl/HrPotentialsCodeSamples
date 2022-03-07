using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp4
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var arr = new[] { 1, 2, 4, 5, 7 };
            var res = arr.Join(arr, i => i, i => i+1, (i, i2) => i+1);

            Console.WriteLine(String.Join(", ", res));
        }
    }
}