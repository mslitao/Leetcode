using System;
using System.Collections.Generic;
using System.Linq;


public class Solution350
{
    public int[] Intersect(int[] nums1, int[] nums2) {
        Dictionary<int, int> numFreq = new Dictionary<int, int>();
        foreach(int num in nums1)
        {
            if(!numFreq.ContainsKey(num)) numFreq.Add(num, 0);
            numFreq[num] ++;
        }

        List<int> results = new List<int>();
        foreach(var num in nums2)
        {
            if(numFreq.ContainsKey(num) && numFreq[num] > 0)
            {
                numFreq[num] --;
                results.Add(num);
            }
        }

        return results.ToArray();
    }
}