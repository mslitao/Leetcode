using System;
using System.Collections.Generic;
using System.Linq;

public class Solution131
{
    public IList<IList<string>> Partition(string s) {
        IList<IList<string>> results = new List<IList<string>>();
        if(string.IsNullOrEmpty(s)) return results;

        int len = s.Length;
        bool[,] dp = new bool[len, len];
        int result = 0;
            
        for(int i =len-1; i >=0 ; --i)
            for(int j =i; j < len; ++j)
            {
                if(s[i] == s[j] && (j <= i +1 || dp[i+1, j-1]))
                {
                    dp[i, j] = true;
                    result++;
                }
            }
        List<string> current = new List<string>();
        BPPartitionString(current, 0, s, results, dp);

        return results;
    }

    public void BPPartitionString(List<string> current, int idx, string s, IList<IList<string>> results, bool[,] dp)
    {
        if(idx >= s.Length) 
        {
            List<string> res = new List<string>(current);
            results.Add(res);
            return;
        }

        for(int i =idx; i < s.Length; ++i)
        {
            if(!dp[idx, i]) continue;
            
            int pos = current.Count;
            current.Add(s.Substring(idx, i-idx+1));
            BPPartitionString(current, i+1, s, results, dp);
            current.RemoveAt(pos);
        }
    }
}