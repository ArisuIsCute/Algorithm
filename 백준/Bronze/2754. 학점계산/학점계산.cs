using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace BaekJoon
{
    internal class BaekJoon
    {
        static void Main(string[] args)
        {
            string rank = ReadLine();
            float score = 0.0f;

            if(rank.Length == 2)
            {
                switch (rank[1])
                {
                    case '-':
                        score += 0.7f;
                        break;
                    case '0':
                        score += 1.0f;
                        break;
                    case '+':
                        score += 1.3f;
                        break;
                }
            }

            switch (rank[0])
            {
                case 'A':
                    score += 3.0f;
                    break;
                case 'B':
                    score += 2.0f;
                    break;
                case 'C':
                    score += 1.0f;
                    break;
            }

            WriteLine("{0:0.0}", score);
        }
    }
}