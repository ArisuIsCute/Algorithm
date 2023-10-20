using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(string my_string) {
        int[] answer = new int[52];
        for(int i = 0; i < my_string.Length; i++){
           if(my_string[i] <= 90 && my_string[i] >= 65){
               //대문자라면
               answer[my_string[i] - 'A']++;
           }else{
               //소문자라면
               answer[my_string[i] - 71]++;
           }
        }
        return answer;
    }
}