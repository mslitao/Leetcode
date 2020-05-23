using System;
using System.Collections.Generic;
using System.Linq;

public class Solution414
{
    public int ThirdMax(int[] nums) {
        var n = nums.Length;

        if (n == 1) return nums[0];

        var max1 = long.MinValue;
        var max2 = long.MinValue;
        var max3 = long.MinValue;

        foreach (var cur in nums) {
            if (max1 < cur) {
                max3 = max2;
                max2 = max1;
                max1 = cur;
            } else if (max1 != cur && max2 < cur) {
                max3 = max2;
                max2 = cur;
            } else if (max2 != cur && cur < max1 && max3 < cur) {
                max3 = cur;
            }
        }

        return (int)(max3 == long.MinValue ? max1 : max3);
    }
}