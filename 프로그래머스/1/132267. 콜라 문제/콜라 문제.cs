using System;

public class Solution {
    public int solution(int a, int b, int n) {
        int answer = 0, other = 0;
        
        while(n >= a){
            other = n % a;
            n /= a;
            n *= b;
            answer += n;
            n += other;
            other = 0;
        }
        
        return answer;
    }
}