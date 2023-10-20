using System;

public class Solution {
    public int solution(int n) {
        for(int i = 1; ;i++){
            if(n % i == 1) return i;
        }
    }
}