using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution477
{
    public int TotalHammingDistance(int[] nums) {
        int total = 0;
        int n = nums.Length;
        for(int i = 0; i < 32; ++i)
        {
            int cnt = 0;
            foreach(var num in nums)
            {
                if((num & (1<<i)) != 0)
                    ++cnt;
            }

            total+= cnt*(n-cnt);
        }

        return total;
    }

}