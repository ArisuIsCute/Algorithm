using System;

public class Solution {
    public int solution(string myString, string pat) {
        string newString = "";
        foreach(char c in myString) newString += c == 'A' ? 'B' : 'A';
        return newString.Contains(pat) ? 1 : 0;
    }
}