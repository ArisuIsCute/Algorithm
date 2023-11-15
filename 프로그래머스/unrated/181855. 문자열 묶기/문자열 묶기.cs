using System;

public class Solution {
    public int solution(string[] strArr) {
        int[] max = new int[strArr.Length];
        
        foreach(string str in strArr){
            max[str.Length - 1]++;
        }
        
        int answer = 0;
        
        foreach(int i in max){
            if(answer < i) answer = i;
        }
        
        return answer;
    }
}