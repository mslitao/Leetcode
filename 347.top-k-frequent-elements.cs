using System;
using System.Collections.Generic;
using System.Linq;

public class Solution347
{
    public IList<int> TopKFrequent(int[] nums, int k) 
    {
        Dictionary<int, int> numFreq = new Dictionary<int, int>();
        for(int i =0; i < nums.Length; ++i)
        {
            if(!numFreq.ContainsKey(nums[i]))
            {
                numFreq.Add(nums[i], 0);
            }
            numFreq[nums[i]] = numFreq[nums[i]] + 1;
        }

        var sortedNumFreq = numFreq.OrderByDescending(n=>n.Value).ToList();

        List<int> results = new List<int>();

        for(int i =0; i < k && i < sortedNumFreq.Count(); ++i)
        {
            results.Add(sortedNumFreq[i].Key);
        }

        return results;
    }
}