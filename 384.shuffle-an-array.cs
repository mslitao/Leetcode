using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution384
{
    public int[] nums;
    private int[] original;
    private Random random = new Random();
    
    public Solution384(int[] nums) 
    {
        this.nums = nums;
        original = nums.ToArray();
    }
    
    public int[] Reset() {
        nums = original.ToArray();
        return nums;
    }
    
    public int[] Shuffle() {
        for (int i = 0; i < nums.Length; i++)
        {
            int randomIndex = random.Next(i, nums.Length);
            int temp = nums[i];
            nums[i] = nums[randomIndex];
            nums[randomIndex] = temp;
        }
        return nums;
    }
}

/**
 * Your Solution object will be instantiated and called as such:
 * Solution obj = new Solution(nums);
 * int[] param_1 = obj.Reset();
 * int[] param_2 = obj.Shuffle();
 */