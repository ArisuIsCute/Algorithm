using System;
using System.Collections.Generic;
using static System.Console;

namespace BaekJoon
{
    internal class BaekJoon
    {
        static void Main(string[] args)
        {
            int n = int.Parse(ReadLine());
            int[] nums = new int[n];
            for(int i = 0; i < n; i++)
            {
                nums[i] = int.Parse(ReadLine());
            }
            for(int i =0; i < n; i++)
            {
                function(nums[i]);
            }
        }

        static void function(int n)
        {
            int[] arr = new int[n + 3];
            arr[0] = 1;
            arr[1] = 1;
            arr[2] = 2;
            for(int i = 3; i <= n; i++)
            {
                arr[i] = arr[i - 3] + arr[i - 2] + arr[i - 1];
            }
            WriteLine(arr[n]);
            return;
        }
    }
}