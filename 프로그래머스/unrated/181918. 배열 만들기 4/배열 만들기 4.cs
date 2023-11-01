using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] arr) {
        List<int> stk = new List<int>();
        int i = 0;
        while(true){
            if(i >= arr.Length) break;
            
            if(stk.Count == 0) stk.Add(arr[i++]);
            else if(stk[stk.Count - 1] < arr[i]) stk.Add(arr[i++]);
            else stk.RemoveAt(stk.Count - 1);
        }
        return stk.ToArray();
    }
}