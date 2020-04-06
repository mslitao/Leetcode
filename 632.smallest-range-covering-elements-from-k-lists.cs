using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution632
{
    public int[] SmallestRange(IList<IList<int>> nums) {
        int[] results = new int[2];
        if(nums == null || nums.Count == 0) return results;

        // Step 1: Merge nums into one list and keep another list to track where's the number from.
        List<int> numbers = new List<int>();
        List<int> indexes = new List<int>();
        MergeNumbers(nums, numbers, indexes);
        
        Console.WriteLine(string.Join(",", numbers));
        Console.WriteLine(string.Join(",", indexes));

        // Step 2: Use a rolling window logic to find a minimun range.
        int start = 0;
        int end = 0;
        Dictionary<int, int> map = new Dictionary<int, int>();
        int n = nums.Count;
        int range = int.MaxValue;
        while(true)
        {
            if(map.Count == n)
            {
                if(numbers[end-1] - numbers[start] + 1 < range)
                {
                    range = numbers[end-1] - numbers[start] + 1;
                    results[0] = numbers[start];
                    results[1] = numbers[end-1];
                }

                map[indexes[start]] --;
                if(0 == map[indexes[start]])
                {
                    map.Remove(indexes[start]);
                }
                
                start ++;
            }
            else
            {
                if(end >= numbers.Count) break;
                if(!map.ContainsKey(indexes[end]))
                {
                    map.Add(indexes[end], 0);
                }
                map[indexes[end]] ++;
                end ++;
            }
        }
        
        return results;
    }

    public void MergeNumbers(IList<IList<int>> nums, List<int> results, List<int> indexes)
    {
        int[] map = new int[nums.Count];

        while(true)
        {
            int next = int.MaxValue;
            int index = -1;
            for(int i = 0; i < nums.Count; ++i)
            {
                if(map[i] >= nums[i].Count)
                {
                    continue;
                }

                if(nums[i][map[i]] < next)
                {
                    next = nums[i][map[i]];
                    index = i;
                }
            }

            if(index == -1)
            {
                break;
            }

            map[index] ++;
            results.Add(next);
            indexes.Add(index);
        }

        return;
    }
}