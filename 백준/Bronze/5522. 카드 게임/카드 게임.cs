using static System.Console;


namespace BaekJoon
{
    internal class BaekJoon
    {
        static void Main(string[] args)
        {
            int sum = 0;
           for(int i = 0; i < 5; i++)
            {
                sum += int.Parse(ReadLine());
            }
            WriteLine(sum);
        }
    }
}
