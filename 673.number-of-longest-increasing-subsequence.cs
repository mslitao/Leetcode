using System;
using System.Collections.Generic;
using System.Linq;

public class Solution673
{
    public int FindNumberOfLIS2(int[] nums) 
    {
        if (nums.Length < 1)
        {
            return 0;
        }

        int len = nums.Length;
        int[] maxLength = new int[len];
        int[] maxCount = new int[len];
        Array.Fill(maxLength, 1);
        Array.Fill(maxCount, 1);

        for(int i =0; i < nums.Length; ++i)
        {
            for(int j =0; j < i; ++j)
            {
                if(nums[j] >= nums[i])
                {
                    continue;
                }
                if(maxLength[j] >= maxLength[i])
                {
                    maxLength[i] = maxLength[j] + 1;
                    maxCount[i] =  maxCount[j];
                }

                else if(maxLength[j] + 1 == maxLength[i])
                {
                    maxCount[i] = maxCount[i] +  maxCount[j];
                }
            }
        }

        int maxLen = maxLength.Max();
        int result = 0;
        for(int i =0; i < len; ++i)
        {
            if(maxLen == maxLength[i])
            {
                result += maxCount[i];
            }
        }
        return result;
    }
    public int FindNumberOfLIS(int[] nums) 
    {
        if (nums.Length < 1)
        {
            return 0;
        }

        List<int> LengthDict = new List<int>();
        List<int> LengthDict2 = new List<int>();
        Dictionary<int, int> dict = new Dictionary<int, int>();
        LengthDict.Add(1);
        LengthDict2.Add(1);
        dict.Add(1, 1);
        int maxLengthRes = 0;
        for (int i = 1; i < nums.Length; ++i)
        {
            int maxLength = 0;
            int maxCount = 0;
            for (int j = i - 1; j >= 0; --j)
            {
                if (nums[j] < nums[i] && LengthDict[j] > maxLength)
                {
                    maxLength = LengthDict[j];
                    maxCount = LengthDict2[j];
                }
                else if(nums[j] < nums[i] && LengthDict[j] == maxLength)
                {
                    maxCount = maxCount + LengthDict2[j]; 
                }
            }
            if (maxCount == 0)
            {
                maxCount = 1;
            }
            LengthDict.Add(maxLength + 1);
            LengthDict2.Add(maxCount);

            var tmpLen = maxLength + 1;
            if (dict.ContainsKey(tmpLen))
            {
                dict[tmpLen] = dict[tmpLen] + maxCount;
            }
            else
            {
                dict.Add(tmpLen, maxCount);
            }
            if(tmpLen > maxLengthRes)
            {
                maxLengthRes = tmpLen;
            }
        }
        if (dict.ContainsKey(maxLengthRes))
            return dict[maxLengthRes];
        else return 1;
    }
}