public class Solution494
{
    public int FindTargetSumWays(int[] nums, int S) {
        int len = nums.Length;
        if(len ==0) return 0;
        if(S>1000) return 0;

        int[] dp = new int[2001];
        dp[1000 + nums[0]]  += 1;
        dp[1000 - nums[0]]  += 1;
        for(int i =1; i < len; ++i)
        {
            var num = nums[i];
            int[] next = new int[2001];
            for(int sum =-1000; sum <=1000; ++sum)
            {
                if(dp[sum + 1000] > 0)
                {
                    var sum1 = sum + num;
                    var sum2 = sum - num;
                    
                    next[sum1 + 1000] += dp[sum + 1000];
                    next[sum2 + 1000] += dp[sum + 1000]; 
                }
            }  
            dp = next;              
        }
        return dp[S+1000];
    }
}