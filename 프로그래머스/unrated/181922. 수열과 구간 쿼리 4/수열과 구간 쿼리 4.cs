using System;

public class Solution {
    public int[] solution(int[] arr, int[,] queries) {
        int s, e, k;
        for(int i = 0; i < queries.GetLength(0); i++){
            s = queries[i, 0];
            e = queries[i, 1];
            k = queries[i, 2];
            
            for(int j = 0; j < arr.Length; j++){
                if(s <= j && j <= e && j % k == 0){
                    arr[j]++;
                }
            }
        }
        return arr;
    }
}