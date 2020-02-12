using System;
using System.Collections.Generic;
using System.Linq;

public class Solution15
{
    public IList<IList<int>> ThreeSum(int[] nums)
    {
        IList<IList<int>> data = new List<IList<int>>();
        if(nums.Length < 3)
        {
            return data;
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
        
        for (int i = 0; i < nums.Length-2;++i)
        {
            if (i == 0 || (i > 0 && nums[i] != nums[i - 1]))
            {
                int num1 = nums[i];
                int j = i + 1;
                int k = nums.Length - 1;
                while (j < k)
                {
                    int num2 = nums[j];
                    int num3 = nums[k];
                    if (num1 + num2 + num3 == 0)
                    {
                        data.Add(new List<int>() { num1, num2, num3 });
                        while (j < k && nums[j] == nums[j + 1])
                        {
                            j++;
                        }
                        while (j < k && nums[k] == nums[k - 1])
                        {
                            k--;
                        }
                        j++;
                        k--;
                    }
                    else if (num1 + num2 + num3 > 0)
                    {
                        k--;
                    }
                    else
                    {
                        j++;
                    }
                }
            }
        }
        return data;
    }
}