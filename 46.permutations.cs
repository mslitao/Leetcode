using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution46
{
    public IList<IList<int>> Permute(int[] nums) {
        IList<IList<int>> results = new List<IList<int>>();
        IList<int> current = new List<int>();
        
        BPPermute(current, nums.ToList(), results);
        
        return results;
    }
    // Backtracking is a good way to generate the permute.
    public void BPPermute(IList<int> current, List<int> nums, IList<IList<int>> results)
    {
        if(nums.Count == 0)
        {
            var result = new List<int>(current);
            results.Add(result);
            return;
        }
        
        for(int i =0; i < nums.Count; ++i)
        {
            var n = nums[i];
            var idx = current.Count;
            current.Add(n);
            var leftNums = new List<int>(nums);
            
            leftNums.RemoveAt(i);
            BPPermute(current, leftNums, results);
            current.RemoveAt(idx);
        }
    }
}