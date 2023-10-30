using static System.Console;


namespace BaekJoon
{
    internal class BaekJoon
    {
        static void Main(string[] args)
        {
            int n = int.Parse(ReadLine());
            int[] score = new int[2];
            string[] str;
            for (int i = 0; i < n; i++)
            {
                str = ReadLine().Split(' ');

                if (int.Parse(str[0]) > int.Parse(str[1]))
                {
                    score[0]++;
                }
                else if (int.Parse(str[0]) < int.Parse(str[1]))
                {
                    score[1]++;
                }
            }
            WriteLine("{0} {1}", score[0], score[1]);
        }
    }
}
