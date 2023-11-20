using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using static System.Console;

namespace BaekJoon
{
    internal class BaekJoon
    {
        static int cnt1 = 0;
        static int cnt2 = 0;

        public static void Main(string[] args)
        {
            int n = int.Parse(ReadLine());
            fib(n);
            fibonacci(n);
            WriteLine(cnt1 + " " + cnt2);
        }

        static int fib(int n)
        {
            if (n == 1 || n == 2)
            {
                cnt1++;
                return 1;
            }
            return fib(n - 1) + fib(n - 2);
        }

        static int fibonacci(int n) 
        {
            List<int> list = new List<int>() { 1, 1 };
            while(list.Count < n)
            {
                cnt2++;
                list.Add(list[list.Count - 1] + list[list.Count - 2]);
            }
            return list[n - 1];
        }
    }
}