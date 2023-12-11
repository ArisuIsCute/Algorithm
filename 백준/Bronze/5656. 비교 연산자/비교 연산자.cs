using System;
using static System.Console;

namespace solution
{
    public class Class1
    {
        public static void Main(string[] args)
        {
            string[] input;
            List<string> result = new List<string>();
            bool end = false;
            while (!end)
            {
                input = ReadLine().Split(' ');
                switch (input[1])
                {
                    case "!=":
                        result.Add(int.Parse(input[0]) != int.Parse(input[2]) ? "true" : "false");
                        break;
                    case "<":
                        result.Add(int.Parse(input[0]) < int.Parse(input[2]) ? "true" : "false");
                        break;
                    case "<=":
                        result.Add(int.Parse(input[0]) <= int.Parse(input[2]) ? "true" : "false");
                        break;
                    case ">":
                        result.Add(int.Parse(input[0]) > int.Parse(input[2]) ? "true" : "false");
                        break;
                    case ">=":
                        result.Add(int.Parse(input[0]) >= int.Parse(input[2]) ? "true" : "false");
                        break;
                    case "==":
                        result.Add(int.Parse(input[0]) == int.Parse(input[2]) ? "true" : "false");
                        break;
                    case "E":
                        end = true;
                        break;
                }
            }

            for(int i = 0; i < result.Count; i++) WriteLine("Case " + (i + 1) + ": " + result[i]);
        }
    }
}