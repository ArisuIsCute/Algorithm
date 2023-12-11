using System;

public class Solution 
{
    public int solution(int left, int right)
    {
        int answer = 0, result = 0;
        
        for(int i = left; i <= right; i++)
        {
            result = 0;
            
            for(int j = 1; j <= i; j++) if(i % j == 0) result++;
            
            answer = result % 2 == 0 ? answer + i : answer - i;
        }
        
        return answer;
    }
}