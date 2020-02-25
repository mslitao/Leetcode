using System;
using System.Collections.Generic;
using System.Linq;

public class Solution476 {
    public int FindComplement2(int num) {
        int mask = 1;
        while (mask < num) mask = (mask << 1) | 1;
        return ~num & mask;
    }

    public List<int> ConvertFromInteger(int num)
    {
        var data = new List<int>();
        if (num == 0)
        {
            data.Add(0);
        }

        while (num != 0)
        {
            data.Add(num % 2);
            num = num /2;
        }

        return data;
    }

    public int ConvertToInteger(List<int> nums)
    {
        int number = 0;
        var b = 1;
        foreach (var num in nums)
        {
            number = number + b * num;
            b = 2 * b;
        }
        
        return number;
    }

    public int FindComplement(int num)
    {
        var nums = ConvertFromInteger(num);
        for (int i = 0; i < nums.Count; ++i)
        {
            nums[i] = 1 - nums[i];
        }

        var result = ConvertToInteger(nums);
        return result;
    }
}