using System;
using System.Collections.Generic;
using System.Linq;

public class Solution983
{
    // DP solution
    public int MincostTickets(int[] days, int[] costs) 
    {
        int[] memo = new int[366];
        Array.Fill(memo, int.MaxValue);
        HashSet<int> daysets = new HashSet<int>();
        foreach(var d in days)
        {
            daysets.Add(d);
        }
        return DPMincostTickets(1, memo, costs, daysets );
    }


    public int DPMincostTickets(int i, int[] memo, int[] costs, HashSet<int> dayset) {
        if (i > 365)
            return 0;
        if (memo[i] != int.MaxValue)
            return memo[i];

        int ans;
        if (dayset.Contains(i))
        {
            ans = Math.Min(DPMincostTickets(i+1, memo, costs, dayset) + costs[0],
                           Math.Min(DPMincostTickets(i+7, memo, costs, dayset) + costs[1],
                                    DPMincostTickets(i+30, memo, costs, dayset) + costs[2]));
        } 
        else 
        {
            ans = DPMincostTickets(i+1, memo, costs, dayset);
        }

        memo[i] = ans;
        return ans;
    }
}