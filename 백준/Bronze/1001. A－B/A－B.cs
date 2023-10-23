using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekJoon
{
    internal class BaekJoon
    {
        static void Main(string[] args)
        {
            string[] nums = ReadLine().Split(' ');

            WriteLine(int.Parse(nums[0]) - int.Parse(nums[1]));
        }
    }
}
