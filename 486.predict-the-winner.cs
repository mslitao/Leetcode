using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution486
{
    public bool PredictTheWinner(int[] nums) {
        return PlayTheNumPicks(nums, 0, 0, 0, nums.Length-1, 0);
    }

    public bool PlayTheNumPicks(int[] nums, int cur0, int cur1, int left, int right, int player) {
        
        if(right == left) 
        {
            if (player == 0)
            {
                return cur0 + nums[left] >= cur1;
            }
            else
            {
                return cur0 < cur1 + nums[left];
            }
        }
        else if(left>right)
        {
           return cur0 >= cur1; 
        }

        if (player == 0) 
        {
            return !PlayTheNumPicks(nums, cur0 + nums[left], cur1, left + 1, right, 1) 
                   || !PlayTheNumPicks(nums, cur0 + nums[right], cur1, left, right-1, 1);
        } 
        else 
        {
            return !PlayTheNumPicks(nums, cur0, cur1 + nums[left], left + 1, right, 0) 
                   || !PlayTheNumPicks(nums, cur0, cur1 + nums[right], left, right - 1, 0);
        }
    }
}