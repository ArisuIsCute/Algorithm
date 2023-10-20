using System;
using System.Collections.Generic;

public class Solution {
    public string[] solution(string[] todo_list, bool[] finished) {
        
        List<string> result = new List<string>();
        
        for(int i = 0; i < todo_list.Length; i++){
            if(!finished[i]) result.Add(todo_list[i]);
        }
        
        string[] answer = result.ToArray();
        return answer;
    }
}