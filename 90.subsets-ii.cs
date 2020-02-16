using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution90
{
    public IList<IList<int>> SubsetsWithDup(int[] nums) {
        Array.Sort(nums);
        IList<IList<int>> results = new List<IList<int>>();
        var current = new List<int>();
        BacktrackSubsetsWithDup(current, 0, nums.Length, nums, results);

        return results;
    }

    public void BacktrackSubsetsWithDup(List<int> current, int step, int n, int[] nums, IList<IList<int>> results)
    {
        results.Add(new List<int>(current));
        for(int i =step; i < n; ++i)
        {
            current.Add(nums[i]);
            BacktrackSubsetsWithDup(current, i+1, n, nums, results );
            current.Remove(nums[i]);

            // Logic to skip duplicates
            while (i + 1 < n && nums[i] == nums[i + 1]) ++i;
        }
    }
}