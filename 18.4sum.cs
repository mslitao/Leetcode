using System;
using System.Collections.Generic;

public class Solution18 {
    public IList<IList<int>> FourSum(int[] nums, int target) {
        Array.Sort(nums);
        IList<IList<int>> result = new List<IList<int>>();
        for (int i = 0; i < nums.Length - 3; i++)
        {
            // this is to keep sure there's no duplicates
            if (i > 0 && nums[i] == nums[i - 1]) 
                continue;
            for (int j = i + 1; j < nums.Length - 2; j++)
            {
                //same logic for j, make sure there's no duplicates
                if (j > i + 1 && nums[j] == nums[j - 1]) 
                    continue;
                int sum = target - nums[i] - nums[j];
                int left = j + 1;
                int right = nums.Length - 1;
                while (left < right){
                    if (nums[left] + nums[right] == sum){
                        List<int> lst = new List<int>();
                        lst.Add(nums[i]); lst.Add(nums[j]);
                        lst.Add(nums[left]); lst.Add(nums[right]);
                        result.Add(lst);
                        left++; right--;
                        // Keep sure there's no duplicates
                        while (left < nums.Length && nums[left] == nums[left - 1]) left++;
                        while (right > j + 1 && nums[right] == nums[right + 1]) right--;
                    }
                    else if (nums[left] + nums[right] < sum) left++;
                    else if (nums[left] + nums[right] > sum) right--;
                }
            }
        }
        return result;
    }
}