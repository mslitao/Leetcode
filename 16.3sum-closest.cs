using System;
using System.Collections.Generic;
using System.Linq;

public class Solution16
{
    public int ThreeSumClosest(int[] nums, int target)
    {
    int closest = 0;
        bool first = true;

        if (nums.Length < 3)
        {
            return closest;
        }

        for (int i = 0; i < nums.Length; ++i)
        {
            for (int j = i + 1; j < nums.Length; ++j)
            {
                if (nums[j] < nums[i])
                {
                    var tmp = nums[j];
                    nums[j] = nums[i];
                    nums[i] = tmp;
                }
            }
        }


        for (int i = 0; i < nums.Length - 2; ++i)
        {
            int num1 = nums[i];
            int j = i + 1;
            int k = nums.Length - 1;
            while (j < k)
            {
                int num2 = nums[j];
                int num3 = nums[k];
                var sum = num1 + num2 + num3;
                if (sum == target)
                {
                    return sum;
                }
                else if (sum > target)
                {
                    k--;
                }
                else
                {
                    j++;
                }

                if (first)
                {
                    closest = sum;
                    first = false;
                }
                else if (Math.Abs(target - sum) < Math.Abs(target - closest))
                {
                    closest = sum;
                }
            }
        }

        return closest;
    }
}