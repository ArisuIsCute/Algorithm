using System;

public class Solution {
    public int solution(int num1, int num2) {
        int answer;
        
        double result = ((float)num1 / (float)num2) * 1000;
        answer = (int)Math.Truncate(result);
        
        
        return answer;
    }
}