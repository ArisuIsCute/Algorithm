using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(int[] num_list) {
        List<int> list = num_list.ToList();
        list.Sort();
        list.RemoveRange(0, 5);
        return list.ToArray();
    }
}