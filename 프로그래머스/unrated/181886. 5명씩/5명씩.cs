using System;
using System.Collections.Generic;

public class Solution {
    public string[] solution(string[] names) {
        
        List<string> result = new List<string>();
        int gap = 0;
        result.Add(names[0]);
        for(int i = 0; i < names.Length; i++){
            if(gap == 5){
                gap = 1;
                result.Add(names[i]);
            }else{
                gap++;
            }
        }
        
        string[] answer = result.ToArray();
        return answer;
    }
}