using System;
using System.Collections.Generic;
using System.Linq;

public class Solution78
{
    public IList<IList<int>> Subsets(int[] nums) {
        IList<IList<int>> results = new List<IList<int>>();

        int step =0;
        int n = nums.Length;
        List<int> current = new List<int>();
        BacktrackSubsets(current, step, n, nums, results);

        return results;
    }

    public void BacktrackSubsets(List<int> current, int step, int n, int[] nums, IList<IList<int>> results)
    {
        results.Add(new List<int>(current));
        for(int i =step; i < n; ++i)
        {
            current.Add(nums[i]);
            BacktrackSubsets(current, i+1, n, nums, results );
            current.Remove(nums[i]);
        }
    }
}