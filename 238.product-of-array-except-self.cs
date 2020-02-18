using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution238
{
    public int[] ProductExceptSelf(int[] nums) {
        int len = nums.Length;
        if(len <=1) return nums;
        int[] results = new int[len]; 

        int temp = 1;
        for(int i = 0; i < len; ++i)
        {
            results[i] = temp;
            temp = temp * nums[i];
        }
        temp = 1;
        for(int i = len - 1; i >= 0; --i)
        {
            results[i] = results[i] * temp;
            temp = temp * nums[i];
        }

        return results;
    }
}