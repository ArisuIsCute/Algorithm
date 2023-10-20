using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int n, int k) {    
        List<int> result = new List<int>();
        
        for(int i = 1; i <= n; i++){
            if(i % k == 0){
                result.Add(i);
            }
        }
        int[] answer = new int[result.Count];
        
        for(int i = 0; i < result.Count; i++){
            answer[i] = result[i];
        }
        return answer;
    }
}