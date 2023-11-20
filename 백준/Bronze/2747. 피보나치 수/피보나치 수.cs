using System;
using System.Collections.Generic;
using static System.Console;

namespace BaeJoon
{
    internal class BaekJoon
    {
        static void Main(string[] args)
        {
            int n = int.Parse(ReadLine());
            WriteLine(fibo(n));
        }

        static int fibo(int n)
        {
            List<int> list = new List<int>() { 1, 1 };
            while(list.Count < n)
            {
                list.Add(list[list.Count - 1] + list[list.Count - 2]);
            }
            return list[n - 1];
        }
    }
}