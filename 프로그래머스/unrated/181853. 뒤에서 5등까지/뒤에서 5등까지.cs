using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] num_list) {
        List<int> list = num_list.ToList();
        list.Sort();
        
        while(list.Count != 5) list.RemoveAt(list.Count - 1);
        
        return list.ToArray();
    }
}