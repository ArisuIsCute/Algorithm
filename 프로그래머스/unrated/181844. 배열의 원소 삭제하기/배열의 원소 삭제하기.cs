using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] arr, int[] delete_list) {
        List<int> list = new List<int>();
        bool isSame = false;
        for(int i = 0; i < arr.Length; i++){
            foreach(int j in delete_list){
                if(arr[i] == j) isSame = true;
            }
            if(!isSame) list.Add(arr[i]);
            isSame = false;
        }
        return list.ToArray();
    }
}