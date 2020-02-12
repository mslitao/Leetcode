using System;
using System.Collections.Generic;
using System.Linq;

public class Solution128 {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> sets = new HashSet<int>();
        nums.ToList().ForEach(n=>sets.Add(n));
        
        int maxLen = 0;
        foreach(var num in nums)
        {
            if(!sets.Contains(num))
            {
                continue;
            }

            int left = num;
            int right =num + 1;
            while(sets.Contains(left)) sets.Remove(left--);
            while(sets.Contains(right)) sets.Remove(right++);
            maxLen = Math.Max(maxLen, right - left - 1);
        }

        return maxLen;
    }
}