using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] arr) {
        List<int> answer = new List<int>();
        
        for(int i = 0; i < arr.Length;){
            if(answer.Count == 0) answer.Add(arr[i++]);
            else if(answer[answer.Count - 1] == arr[i]){
                answer.RemoveAt(answer.Count - 1);
                i++;
            }else{
                answer.Add(arr[i++]);
            }
        }
        
        if(answer.Count == 0) return new int[]{-1};
        return answer.ToArray();
    }
}