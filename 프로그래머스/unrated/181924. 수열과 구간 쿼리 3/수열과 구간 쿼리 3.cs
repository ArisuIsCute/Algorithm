using System;

public class Solution {
    public int[] solution(int[] arr, int[,] queries) {
        int[] answer = new int[arr.Length];
        int n1, n2, tmp;
        for(int i = 0; i < queries.GetLength(0); i++){
            n1 = queries[i, 0];
            n2 = queries[i, 1];
            
            tmp = arr[n1];
            arr[n1] = arr[n2];
            arr[n2] = tmp;
        }
        answer = arr;
        return answer;
    }
}