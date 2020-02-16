using System;
using System.Collections.Generic;
using System.Linq;

public class Solution77
{
    public IList<IList<int>> Combine(int n, int k)
    {
        IList<IList<int>> results = new List<IList<int>>();
        List<int> tmp = new List<int>();
        BacktrackingCombine(results, tmp, 1, n, k);

        return results;
    }

    public void BacktrackingCombine(IList<IList<int>> results, List<int> tmp, int start,int n, int k)
    {
        if (k==0) {
            results.Add(new List<int>( tmp));
            return;
        }

        for (int i = start ; i <=n; ++i)
        {
            tmp.Add(i);
            BacktrackingCombine(results, tmp, i + 1, n, k-1);
            tmp.RemoveAt(tmp.Count - 1);
        }
    }
}