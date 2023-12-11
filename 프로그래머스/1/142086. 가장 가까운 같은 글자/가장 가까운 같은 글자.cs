using System;
using System.Collections.Generic;

public class Solution
{
    public int[] solution(string s)
    {
        List<char> list = new List<char>();
        int[] answer = new int[s.Length];
        
        for(int i = 0; i < s.Length; i++)
        {
            if(list.Contains(s[i])) answer[i] = i - list.FindLastIndex(v => v == s[i]);
            else answer[i] = -1;
            
            list.Add(s[i]);
        }
        
        return answer;
    }
}