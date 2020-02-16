using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution93
{
    public IList<string> RestoreIpAddresses(string s) 
    {
        IList<string> results = new List<string>();
        BacktrackingRestoreIpAddresses(s, 0, new List<int>(), results);
        return results;
    }

    public void BacktrackingRestoreIpAddresses(string s, int n, List<int> temp, IList<string> results)
    {
        if(n == 4) 
        {
            if(string.IsNullOrEmpty(s))
            {
                results.Add(string.Join('.', temp));
            }
            return;
        }

        for(int k = 1; k < 4 && k <= s.Length; ++k)
        {
            var num = int.Parse(s.Substring(0, k));
            if(num >=0  && num <=255 && num.ToString().Length == k)
            {
                temp.Add(num);
                BacktrackingRestoreIpAddresses(s.Substring(k), n + 1, temp, results);
                temp.RemoveAt(n);
            }
        }
    }
}