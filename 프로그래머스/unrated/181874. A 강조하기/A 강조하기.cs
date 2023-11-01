using System;

public class Solution {
    public string solution(string myString) {
        string answer = "", upStr = myString.ToUpper(), downStr = myString.ToLower();
        for(int i = 0; i < myString.Length; i++){
            if(myString[i] == 'a' || myString[i] == 'A') answer += upStr[i];
            else answer += downStr[i];
        }
        return answer;
    }
}