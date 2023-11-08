using System;

public class Solution {
    public string solution(string my_string, int[] indices) {
        Array.Sort(indices);
        int cnt = 0;
        string result = "";
        for(int i = 0; i < my_string.Length; i++){
            if(cnt != indices.Length && i == indices[cnt]) cnt++;
            else result += my_string[i];
        }
        return result;
    }
}