using System;
using System.Collections.Generic;
using System.Linq;

public class Mock0430
{
    //DP 2 numbers
    public int MaximumProduct(int[] nums) {
        if(nums.Length < 3) return 0;
        int max1 = Math.Max(nums[0], nums[1]);
        int min1 = Math.Min(nums[0], nums[1]);
        int max2 = nums[0] * nums[1];
        int min2 = nums[0] * nums[1];
        int max3 = int.MinValue;
        for(int i = 2; i < nums.Length; ++i)
        {
            var num = nums[i];
            max3 = Math.Max(max3, Math.Max(max2 * num, min2 * num));
            max2 = Math.Max(max2, Math.Max(min1 * num, max1 * num));
            min2 = Math.Min(min2, Math.Min(min1 * num, max1 * num));
            max1 = Math.Max(max1, num);
            min1 = Math.Min(min1, num);
        }

        return max3;
    }

    public IList<string> TopKFrequent(string[] words, int k) {
        Dictionary<string, int> wordFreq = new Dictionary<string, int>();

        foreach(var word in words)
        {
            if(!wordFreq.ContainsKey(word))
            {
                wordFreq.Add(word, 1);
            }
            else
            {
                wordFreq[word] ++;
            }
        }

        return wordFreq.ToList().OrderByDescending(x=> x.Value).ThenBy(x=>x.Key).Take(k).Select(x=>x.Key).ToList();
    }
}