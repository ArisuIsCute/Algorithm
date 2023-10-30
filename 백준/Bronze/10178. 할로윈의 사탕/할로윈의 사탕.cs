using static System.Console;


namespace BaekJoon
{
    internal class BaekJoon
    {
        static void Main(string[] args)
        {
            int n = int.Parse(ReadLine());
            string[] cAv = new string[2];
            int[] you = new int[n], dad = new int[n];
            for (int  i = 0; i < n; i++)
            {
                cAv = ReadLine().Split(' ');
                you[i] = int.Parse(cAv[0]) / int.Parse(cAv[1]);
                dad[i] = int.Parse(cAv[0]) % int.Parse(cAv[1]);
            }
          
            for(int i = 0; i < n; i++)
            {
                WriteLine("You get {0} piece(s) and your dad gets {1} piece(s).", you[i], dad[i]);
            }
        }
    }
}
