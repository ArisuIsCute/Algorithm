using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace BaekJoon
{
    internal class BaekJoon
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool isSk = true;

            while (true)
            {
                if(n >= 3)
                {
                    n -= 3;
                }
                else if(n >= 1)
                {
                    n -= 1;
                }

                if (n == 0) break;
                isSk = !isSk;
            }
            if(isSk)
            {
                Console.WriteLine("SK");
            }
            else
            {
                Console.WriteLine("CY");
            }
        }
    }
}
