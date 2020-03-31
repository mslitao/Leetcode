using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution1395 {
    public int NumTeams(int[] rating) {
        if(rating ==null || rating.Length <3) return 0;

        return NumTeamDP(rating, true) + NumTeamDP(rating, false); 
    }

    public int NumTeamDP(int[] rating, bool isAsc)
    {
        int n = rating.Length;
        int[] dp = new int[n];

        for(int i = 1; i < n ; ++i)
        {
            int tmp = 0;
            for(int j = i-1; j>=0; j--)
            {
                if(isAsc && rating[j] < rating[i] ||
                   !isAsc && rating[j] > rating[i])
                {
                    tmp += 1;
                }
            }

            dp[i] = tmp;
        }

        int result = 0;
        for(int i = 2; i < n ; ++i)
        {
            for(int j = i-1; j>=1; j--)
            {
                if(isAsc && rating[j] < rating[i] ||
                   !isAsc && rating[j] > rating[i])
                {
                    result += dp[j];
                }
            }
        }

        return result;
    }
}