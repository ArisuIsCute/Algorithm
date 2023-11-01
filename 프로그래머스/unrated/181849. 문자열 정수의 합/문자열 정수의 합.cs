using System;

public class Solution {
    public int solution(string num_str) {
        int answer = 0;
        int num;
        for(int i = 0; i < num_str.Length; i++){
            num = num_str[i] - '0';
            answer += num;
        }
        return answer;
    }
}