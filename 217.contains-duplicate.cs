using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution217
{
    public bool ContainsDuplicate(int[] nums) {
        if (nums == null || nums.Length <= 1)
            return false;

        HashSet<int> data = new HashSet<int>();
        foreach (var num in nums)
        {
            data.Add(num);
        }

        return data.Count != nums.Length;   
    }
}