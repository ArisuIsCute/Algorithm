using System.Collections.Generic;
using static System.Console;

namespace BaekJoon
{
    internal class BaekJoon
    {
        static void Main(string[] args)
        {
            int n = int.Parse(ReadLine());
            List<int> answer = new List<int>();

            answer.Add(1);
            answer.Add(3);

            for(int i = 2; i < n; i++)
            {
                answer.Add((answer[i - 2] * 2 + answer[i - 1]) % 10007);
            }

            WriteLine(answer[n - 1]);
        }
    }
}