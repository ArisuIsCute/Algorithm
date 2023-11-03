using System;

public class Solution {
    public string solution(string my_string, string alp) {
        string upper_string = my_string.ToUpper();
        string answer = "";
        for(int i = 0; i < my_string.Length; i++)
        {
            if (my_string[i] == alp[0]) answer += upper_string[i];
            else answer += my_string[i];
        }
        return answer;
    }
}