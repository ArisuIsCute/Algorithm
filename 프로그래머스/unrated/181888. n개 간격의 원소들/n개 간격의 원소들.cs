using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] num_list, int n) {    
        List<int> result = new List<int>();
        int gap = 0;
        
        result.Add(num_list[0]);
        
        for(int i = 0; i < num_list.Length; i++){
            if(gap == n){
                gap = 1;
                result.Add(num_list[i]);
            }else{
                gap++;
            }
        }
        int[] answer = result.ToArray();
        return answer;
    }
}