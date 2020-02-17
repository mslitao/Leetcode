using System;
using System.Collections.Generic;
using System.Linq;

public class Solution136
{
    public int SingleNumber(int[] nums) 
    {
        int res = 0;
        foreach (var num in nums) res ^= num;
        return res;
    }
    /*

    */
}