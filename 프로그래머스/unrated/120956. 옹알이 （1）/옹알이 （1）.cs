using System;
using System.Text.RegularExpressions;

public class Solution {
    public int solution(string[] babbling) {
        int answer = 0;
        Regex regex = new Regex("^((ye){0,1}(aya){0,1}(woo){0,1}(ma){0,1})+$");
        foreach(string str in babbling){
            if(regex.IsMatch(str)) answer++;
        }
        
        return answer;
    }
}