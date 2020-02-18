using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution209 {
    public int MinSubArrayLen(int s, int[] nums) {
        if(nums == null || nums.Length == 0 ) return 0;
        int left =0; 
        int right = 0;
        int sum = nums[0];
        int minLength = int.MaxValue;
        while(right < nums.Length)
        {
            while(sum < s)
            {
                right ++;
                if(right == nums.Length)
                {
                    break;
                }
                sum += nums[right];
            }
            
            while(sum >= s && left <= right)
            {
                
                minLength = Math.Min(minLength, right - left + 1);

                /*Console.WriteLine(minLength);
                Console.WriteLine(sum);
                Console.WriteLine(left.ToString() + "->" + right.ToString());*/
                
                sum -= nums[left];
                left++;
            }
        }
        if(minLength == int.MaxValue) return 0;
        else return minLength;
    }
}