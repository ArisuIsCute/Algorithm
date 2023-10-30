using static System.Console;


namespace BaekJoon
{
    internal class BaekJoon
    {
        static void Main(string[] args)
        {
            int T = int.Parse(ReadLine());
            string[] nums = new string[2];
            int[] res = new int[T];
            for(int i = 0; i < T; i++)
            {
                nums = ReadLine().Split(' ');
                res[i] = int.Parse(nums[0]) + int.Parse(nums[1]);
            }
            for(int i = 0;i < T; i++)
            {
                WriteLine("Case {0}: {1}", i + 1, res[i]);
            }
        }
    }
}
