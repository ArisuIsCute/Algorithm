using System;

public class Solution {
    public int solution(int[] num_list) {
        int answer = 0;
        
        int sum = 0, muliti = 1;
        
        for(int i = 0; i < num_list.Length; i++){
            sum += num_list[i];
            muliti *= num_list[i];
        }
        
        if(num_list.Length >= 11){
            answer = sum;
        }else{
            answer = muliti;
        }
        
        return answer;
    }
}