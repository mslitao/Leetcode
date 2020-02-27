using System;
using System.Collections.Generic;

public class Solution1346
{
    public bool CheckIfExist(int[] arr) {
        if(arr == null || arr.Length < 2) return false;
        
        HashSet<int> sets = new HashSet<int>();
        int zeroCnt = 0;
    
        foreach(var num in arr)
        {
            if(num == 0)
                zeroCnt ++;
            sets.Add(num);
        }
        
        if(zeroCnt >1) return true;
        foreach(var num in arr)
        {
            if(num != 0 && sets.Contains(num*2))
                return true;
        }
        
        return false;
    }
}