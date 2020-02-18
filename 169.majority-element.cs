using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution169
{
    public int MajorityElement(int[] nums) {
        int cnt = 0;
        int candidate = 0;
        for(int i =0; i< nums.Length; ++ i)
        {
            var num = nums[i];

            if(cnt ==0)
            {
                candidate = num;
                cnt++;
            }
            else if(candidate == num)
            {
                cnt ++;
            }
            else
            {
                cnt --;
            }
        }

        return candidate;
    }
}