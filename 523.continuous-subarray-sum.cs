using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution523 {

    public bool CheckSubarraySum2(int[] nums, int k) 
    {
        Dictionary<int,int> map = new Dictionary<int,int>();
        map.Add(0,-1);
        int sum = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
            
            int mod = k ==0 ? sum: sum % k;
            
            if (map.ContainsKey(mod))
            {
                if (i - map[mod] >= 2) return true;
            }
            else
            {
                map[mod] = i;
            }
        }
        
        return false;
    }

   public bool CheckSubarraySum(int[] nums, int k) {
        int len = nums.Length;
        int[,] dp  = new int[len + 1, len + 1];

        for(int i =0; i <= len; ++ i)
        {
            dp[0, i] = 0;  dp[i, 0] = 0; 
            if(i > 0)
            {
                dp[1, i] = dp[1, i-1] +nums [i -1];
                dp[i, i] = nums[i -1];
            }
            
        }

        for(int i = 1; i <= len; i++)
        {
            for(int j = i + 1; j <= len; j++)
            {
                dp[i, j] = nums[j - 1] + dp[i, j-1];

                if(k ==0 && dp[i, j] == 0 )
                    return true;
                else if(k != 0 && dp[i, j] % k == 0 )
                    return true;
            }
        } 

        return false;
    }
}