using System;
using static System.Console;

namespace solution
{
    public class Class1
    {
        public static void Main(string[] args)
        {
            int cnt = int.Parse(ReadLine());
            string[] str = new string[cnt];
            
            for (int i = 0; i < cnt; i++) str[i] = ReadLine();
            
            foreach(string s in str) WriteLine(s[0] + "" + s[s.Length - 1]);
        }
    }
}