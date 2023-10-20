using System;

public class Solution {
    public string solution(string my_string, int n) {
        string answer = "";
        
        int start = my_string.Length - n;
        
        for(int i = start; i < my_string.Length; i++){
            answer += my_string[i];
        }
        
        return answer;
    }
}