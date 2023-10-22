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
            string[] p = ReadLine().Split();
            string[] nums = ReadLine().Split();

            for(int i = 0; i < int.Parse(p[0]); i++)
            {
                if (int.Parse(nums[i]) < int.Parse(p[1])){
                    Write(nums[i] + ' ');
                }
            }
            return;
        }
    }
}
