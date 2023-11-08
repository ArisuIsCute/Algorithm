using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] arr, bool[] flag) {
        List<int> list = new List<int>();
        for(int i = 0; i < flag.Length; i++){
            if(flag[i]){
                for(int cnt = arr[i] * 2; cnt > 0; cnt--){
                    list.Add(arr[i]);
                }
            }else{
                for(int cnt = arr[i]; cnt > 0; cnt--){
                    list.RemoveAt(list.Count - 1);
                }
            }
        }
        return list.ToArray();
    }
}