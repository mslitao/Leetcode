using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution368
{
    public IList<int> LargestDivisibleSubset(int[] nums) {
        List<int> results = new List<int>();
        if(nums== null || nums.Length == 0) return results;
        
        var sortedNums = nums.ToList();
        sortedNums.Sort();

        int[] dpLen = new int[nums.Length];
        int[] dpIdx = new int[nums.Length];
        int maxLen = int.MinValue;
        int maxIdx = 0;
        for(int i =0; i < sortedNums.Count; ++i)
        {
            int len = 1;
            int preIndex = -1;

            for(int j = i -1; j >= 0 ; j--)
            {
                if(sortedNums[i] % sortedNums[j] == 0)
                {
                    if(dpLen[j] + 1 > len)
                    {
                        len = dpLen[j] + 1;
                        preIndex = j;
                    }
                }
            }

            if(len > maxLen)
            {
                maxLen = len;
                maxIdx = i;
            }

            dpLen[i] = len;
            dpIdx[i] = preIndex;
        }
        
        //Console.WriteLine(string.Join(",", dpLen));
        //Console.WriteLine(string.Join(",", dpIdx));
        while(maxIdx != -1)
        {
            results.Add(sortedNums[maxIdx]);
            maxIdx = dpIdx[maxIdx];
        }

        return results;

    }
}