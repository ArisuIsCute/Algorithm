using System;

public class Solution {
    public int solution(string[] spell, string[] dic) {
        int answer = 0;
        
        foreach(string str in dic)
        {
            foreach(string t in spell)
            {
                if(!str.Contains(t) || str.Length != spell.Length)
                {
                    answer = 2;
                    break;
                }
                answer = 1;
            }
            if(answer == 1) return answer;
        }
        
        return answer;
    }
}