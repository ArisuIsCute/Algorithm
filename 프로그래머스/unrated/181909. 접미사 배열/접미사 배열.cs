using System;
using System.Collections.Generic;

public class Solution {
    public string[] solution(string my_string) {
        List<string> list = new List<string>();
        
        string str = my_string;
        for(int i = 0; i < my_string.Length; i++){
            list.Add(str);
            str = str.Substring(1, str.Length - 1);
        }
        list.Sort();
        
        return list.ToArray();
    }
}