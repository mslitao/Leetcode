using System;
using System.Linq;
using System.Collections.Generic;

public class Solution1390
{
    public int SumFourDivisors(int[] nums) {
        if(nums==null || nums.Length ==0) return 0;

        int res =0;

        foreach(var num in nums)
        {
            int cnt = 0, sum = 0;
            for (int i = 1; i*i <= num; ++i) {
                if (i*i == num) {
                    cnt++;
                    break;
                }

                if (num%i == 0) {
                    cnt += 2;
                    sum += i + num/i;
                }
                if (cnt > 4) break;
            }
            if (cnt == 4) res += sum;
        }

        return res;
    }
}