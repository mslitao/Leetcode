//239. Sliding Window Maximum
using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] MaxSlidingWindow(int[] nums, int k) 
    {
        // use a num map to memorize the num with the latest index.
        // everytime, when update the window
        // right: add a new number means update the latest index for this number.
        // left: remove a number means only if the to-delete number is the latest, otherwise, no need to delete it.
        // In fact, another way is to have dictionary with the value of count, when delete it, just minus 1 int the value.
        SortedDictionary<int, int> numMap = new SortedDictionary<int, int>();
        List<int> results = new List<int>();
        if(nums == null || nums.Length == 0) return results.ToArray();

        for(int i = 0; i < nums.Length; ++i)
        {
            int num = nums[i];
            if(i < k) // for the first sliding window, add to the map
            {
                if(numMap.ContainsKey(num)) numMap[num] = i;
                else numMap.Add(num, i);
            }
            else
            {
                //results.Add(numMap.OrderByDescending(n =>n.Key).First().Key);
                results.Add(numMap.Last().Key);

                var numToRemove = nums[i - k];
                var indexToRemove = numMap[numToRemove];
                if(indexToRemove == i-k) numMap.Remove(numToRemove);

                if(numMap.ContainsKey(num)) numMap[num] = i;
                else numMap.Add(num, i);
            }
        }

        // Everytime, we ned to order the dictionary by the key to have the larget one.
        
        //results.Add(numMap.OrderByDescending(n =>n.Key).First().Key);
        results.Add(numMap.Last().Key);

        return results.ToArray();
    }
}