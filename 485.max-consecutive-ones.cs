using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution485 {
    public int FindMaxConsecutiveOnes(int[] nums) {
        if(nums == null || nums.Length ==0) return 0;
        
        int result = 0;
        int start =0;
        int end = 0;
        while(end < nums.Length)
        {
            if(nums[end] == 0)
            {
                start = end + 1;
            }
            else
            {
                result = Math.Max(result, end - start + 1);
            }
            
            end ++;
        }
        
        return result;
    }
}