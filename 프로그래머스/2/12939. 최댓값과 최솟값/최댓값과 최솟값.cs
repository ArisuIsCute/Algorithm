using System;
using System.Linq;

public class Solution {
    public string solution(string s) {
        int[] n = s.Split(' ').Select(v => Convert.ToInt32(v)).ToArray();
        Array.Sort(n);
        return n[0] + " " + n[n.Length - 1];
    }
}