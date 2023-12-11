using System;
using static System.Console;

namespace solution
{
    public class Class1
    {
        public static void Main(string[] args)
        {
            string[] n = ReadLine().Split(' ');
            int[] right = { 1, 1, 2, 2, 2, 8 };

            for (int i = 0; i < 6; i++)
            {
                Write(right[i] - int.Parse(n[i]) + " ");
            }
        }
    }
}