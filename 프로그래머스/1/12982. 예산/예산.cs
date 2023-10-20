using System;

public class Solution {
    public int solution(int[] d, int budget) {
        int answer = 0;
        int sum = 0;
        Array.Sort(d);
        
        for(int i = 0; i < d.Length; i++){
            
            if(sum + d[i] > budget){
                break;
            }
            
            sum += d[i];
            answer++;
        }
        
        return answer;
    }
}