using System;

public class Solution {
    public int[] solution(int[] arr, int[,] queries) {
        int[] answer = new int[queries.GetLength(0)];
        int small, big, bigger;
        for(int i = 0; i < queries.GetLength(0); i++){
            //전체 반복
            small = queries[i, 0];
            big = queries[i, 1];
            bigger = queries[i, 2];
            
            int n = -1;
            for(int j = 0; j < arr.Length; j++){
                
                if(small <= j && big >= j && bigger < arr[j]){
                    if(n == -1 || n > arr[j]){
                        n = arr[j];
                    }
                }
               answer[i] = n; 
            }
            
        }
        
        return answer;
    }
}