using System.Linq;

public class Solution {
    public string solution(string s) {
        return new string(s.ToCharArray().OrderByDescending(v => v).ToArray());
    }
}