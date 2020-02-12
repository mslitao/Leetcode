using System;
using System.Collections.Generic;
using System.Linq;

public class Solution1 {
    public int[] TwoSum(int[] nums, int target) 
    {
        Dictionary<int, int> hashMap = new Dictionary<int, int>();
        for(int i =0; i< nums.Length; ++i)
        {
            var num = nums[i];
            if(hashMap.ContainsKey(target - num))
                return new int[]{ hashMap[target-num],i};
            else if(!hashMap.ContainsKey(num))
                hashMap.Add(num, i);
        }
            
        //Array.Sort(nums);
            
        return new int[]{-1, -1};
    }

    public int[] TwoSum_BF(int[] nums, int target) 
    {
        if (nums.Length < 2)
        {
            return null;
        }

        int[] results = new int[2];

        for (int i = 0; i < nums.Length; ++i)
        {
            for (int j = i + 1; j < nums.Length; ++j)
            {
                if (nums[i] + nums[j] == target)
                {
                    results[0] = i;
                    results[1] = j;
                }
            }
        }

        return results;
    }
}