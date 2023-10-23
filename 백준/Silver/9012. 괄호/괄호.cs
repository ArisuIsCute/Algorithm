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
            string n = ReadLine();
            string[] str = new string[int.Parse(n)];
            for(int i = 0; i < int.Parse(n); i++)
            {
                str[i] = ReadLine();
            }
            for(int i = 0; i < int.Parse(n); i++)
            {
                Check(str[i]);
            }
        }

        static void Check(string str)
        {
            int cnt = 0;

            for(int i = 0; i < str.Length; i++)
            {
                if (str[i] == '(') cnt++;
                else cnt--;
                if(cnt < 0)
                {
                    WriteLine("NO");
                    return;
                }
            }
            if(cnt == 0)
            {
                WriteLine("YES");
            }
            else
            {
                WriteLine("NO");
            }
            return;
        }
    }
}
