using System;

public class Solution {
    public int solution(string my_string, string is_prefix) {
        int answer = 1;
        if(is_prefix.Length > my_string.Length) return 0;
        for(int i = 0; i < is_prefix.Length; i++){
            if(is_prefix[i] != my_string[i]) answer = 0;
        }
        return answer;
    }
}