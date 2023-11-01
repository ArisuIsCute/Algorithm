using System;

public class Solution {
    public int solution(int[] arr1, int[] arr2) {
        if(arr1.Length != arr2.Length) return arr1.Length > arr2.Length ? 1 : -1;
        
        int sum1 = 0, sum2 = 0;
        foreach(int i in arr1) sum1 += i;
        foreach(int i in arr2) sum2 += i;
        return sum1 == sum2 ? 0 : sum1 > sum2 ? 1 : -1;
    }
}