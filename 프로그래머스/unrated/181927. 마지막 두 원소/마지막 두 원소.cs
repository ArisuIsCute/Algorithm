using System;

public class Solution {
    public int[] solution(int[] num_list) {
        int[] answer = new int[num_list.Length + 1];
        
        int last = num_list[num_list.Length - 1], lastBefore =num_list[num_list.Length - 2];
        
        int result;
        
        if(last > lastBefore){
            result = last - lastBefore;
        }else{
            result = last * 2;
        }
        
        int i;
        for(i = 0; i < num_list.Length; i++){
            answer[i] = num_list[i];
        }
        answer[i] = result;
        
        return answer;
    }
}