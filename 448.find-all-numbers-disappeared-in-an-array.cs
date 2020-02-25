using System;
using System.Collections.Generic;
using System.Linq;

public class Solution448 
{
    public IList<int> FindDisappearedNumbers(int[] nums) 
    {
        IList<int> results = new List<int>();
        if (nums.Length == 0)
            return results;

        int startIndex = 0;
        while (startIndex < nums.Length)
        {
            int index = startIndex;
            int sourceVal = -1;
            while (index < nums.Length && nums[index] !=index+1)
            {
                var tmp = nums[index];
                var nextIndex = tmp - 1;
                nums[index] = sourceVal;
                  
                index = nextIndex;
                sourceVal = tmp;
                if (index < 0)
                    break;
            }

            startIndex++;
        }

        for (int i = 0; i < nums.Length; ++i)
        {
            if (nums[i] == -1)
            {
                results.Add(i + 1);
            }
        }

        return results;
    }
}