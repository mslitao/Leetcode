using System;
using System.Collections.Generic;
using System.Linq;

public class Solution525
{
    public int findMaxLength(int[] nums) {
        Dictionary<int, int> map = new Dictionary<int, int>();
        map.Add(0, -1);

        int sum = 0;
        int maxLen = 0;
        for(int i = 0; i < nums.Length; ++i)
        {
            sum += nums[i] == 1? 1: -1;

            if(map.ContainsKey(sum))
            {
                maxLen = Math.Max(maxLen, i - map[sum]);
            }
            else
            {
                map.Add(sum, i);
            }
        }

        return maxLen;
    }
}