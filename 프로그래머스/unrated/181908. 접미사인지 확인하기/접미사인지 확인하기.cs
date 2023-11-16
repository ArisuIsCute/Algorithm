using System;

public class Solution {
    public int solution(string my_string, string is_suffix) {
        string compare = my_string;
        for(int i = 0; i < my_string.Length; i++){
            if(compare == is_suffix) return 1;
            compare = compare.Substring(1, compare.Length - 1);
        }
        return 0;
    }
}