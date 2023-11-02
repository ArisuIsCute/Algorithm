using System;
using System.Collections.Generic;

public class Solution {
    public string[] solution(string[] strArr) {
        List<string> list = new List<string>();
        bool inAd = false;
        foreach(string str in strArr){
            for(int i = 0; i < str.Length - 1; i++){
                if(str[i] == 'a' && str[i + 1] == 'd') inAd = true;
            }
            if(!inAd) list.Add(str);
            inAd = false;
        }
        return list.ToArray();
    }
}