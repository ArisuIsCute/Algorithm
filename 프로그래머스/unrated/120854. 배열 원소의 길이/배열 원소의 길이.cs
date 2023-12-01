using System;

public class Solution {
    public int[] solution(string[] strlist) {
        int[] answer = new int[strlist.Length];
        int i = 0;
        foreach(string str in strlist) answer[i++] = str.Length;
        return answer;
    }
}