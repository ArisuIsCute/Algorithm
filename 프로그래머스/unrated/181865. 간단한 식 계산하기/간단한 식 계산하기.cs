using System;

public class Solution {
    public int solution(string binomial) {
        string[] str = binomial.Split(' ');
        switch(str[1]){
            case "+":
                return int.Parse(str[0]) + int.Parse(str[2]);
            case "-":
                return int.Parse(str[0]) - int.Parse(str[2]);
            case "*":
                return int.Parse(str[0]) * int.Parse(str[2]);
        }
        return 0;
    }
}