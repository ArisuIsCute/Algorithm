using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(int[] numbers) {
        List<int> list = numbers.ToList();
        list.Sort();
        return list[list.Count - 1] * list[list.Count - 2];
    }
}