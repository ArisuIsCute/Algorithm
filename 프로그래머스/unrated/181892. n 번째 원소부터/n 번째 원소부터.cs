using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] num_list, int n) {
        
        List<int> result = new List<int>();
        
        for(int i = 0; i < num_list.Length; i++){
            if(i + 1 >= n){
                result.Add(num_list[i]);
            }
        }
        
        int[] answer = result.ToArray();
        return answer;
    }
}