using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution39
{
    public IList<IList<int>> CombinationSum(int[] candidates, int target) {
        IList<IList<int>> results = new List<IList<int>>();
        if(candidates==null || candidates.Length ==0 ) return results;

        List<int> current = new List<int>();
        BacktrackCombinationSum(current, 0, 0, candidates, target, results);
        return results;
    }

    public void BacktrackCombinationSum(List<int> current, int sum, int idx, int[] nums, int target, IList<IList<int>> results)
    {
        if(sum == target)
        {
            // When persist the list, need to clone first.
            var res = new List<int>(current);
            results.Add(res);
            return;
        }
        
        if(sum > target)
        {
            return;
        }

        for(int i = idx; i < nums.Length; ++i)
        {
            var num = nums[i];
            var pos = current.Count;
            current.Add(num);
            BacktrackCombinationSum(current, sum+num, i,  nums, target, results);
            // Reset the current
            current.RemoveAt(pos);
        }
    }
}