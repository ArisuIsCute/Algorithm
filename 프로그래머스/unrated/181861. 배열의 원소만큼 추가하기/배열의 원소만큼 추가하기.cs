using System;

public class Solution {
    public int[] solution(int[] arr) {
        int size = 0;
        
        for(int i = 0; i < arr.Length; i++){
            for(int j = 0; j < arr[i]; j++){
                size++;
            }
        }
        
        int[] answer = new int[size];
        int cnt = 0;
            
        for(int i = 0; i < arr.Length; i++){
            for(int j = 0; j < arr[i]; j++){
                answer[cnt++] = arr[i]; 
            }
        }
        return answer;
    }
}