using System;
using System.Collections.Generic;
using System.Linq;

public class Solution80 {
    public int RemoveDuplicates(int[] nums) {
        if(nums == null || nums.Length == 0) return 0;
        int start = 0;
        int prev = nums[0];
        int cnt = 1;
        for(int i = 1; i < nums.Length; ++i)
        {
            if(nums[i] != prev)
            {
                start ++;
                nums[start] = nums[i];
                prev = nums[start];
                cnt = 1;
            }
            else if(cnt == 1)
            {
                start ++;
                nums[start] = nums[i];
                cnt ++;
            }
        }

        return start +1;
    }
}