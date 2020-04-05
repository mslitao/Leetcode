using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution1403
{
    public IList<int> MinSubsequence(int[] nums) {
        List<int> results = new List<int>();
        if(nums == null || nums.Length == 0) return results;
        var sortedNums = nums.OrderByDescending(n=>n);
        int sum = nums.Sum();
        
        int current = 0;
        foreach(var num in sortedNums)
        {
            current += num;
            results.Add(num);
            if(current * 2 > sum)
            {
                break;
            }
        }

        return results;
    }
}