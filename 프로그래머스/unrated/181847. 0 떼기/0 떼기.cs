using System;

public class Solution {
    public string solution(string n_str) {
        string answer = "";
        bool apr = false;
        for(int i = 0; i < n_str.Length; i++){
            if(n_str[i] != '0') apr = true;
            if(apr) answer += n_str[i];
        }
        return answer;
    }
}