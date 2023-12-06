using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int[] ingredient) {
        int answer = 0, cnt;
        List<int> list = new List<int>();
        
        foreach(int n in ingredient){
            list.Add(n);
            cnt = list.Count;
            
            if(cnt < 4) continue;
            if(list[cnt - 4] == 1 && list[cnt - 3] == 2 && list[cnt - 2] == 3 && list[cnt - 1] == 1){
                answer++;
                list.RemoveRange(cnt - 4, 4);
            }
        }
        
        return answer;
    }
}