using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] arr) {
        List<int> list = new List<int>();
        List<int> answer = new List<int>();
        bool open = false;
        if(!Array.Exists(arr, x => x == 2)){
            answer.Add(-1);
            return answer.ToArray();
        }
        foreach(int i in arr){
            if(!open && i == 2) open = true;
            if(open && i == 2){
                answer.AddRange(list);
                list.Clear();
            }
            if(open) list.Add(i);
        }
        answer.Add(2);
        return answer.ToArray();
    }
}