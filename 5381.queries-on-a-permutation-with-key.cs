using System;
using System.Collections.Generic;
using System.Linq;

public class Solution5381
{
    public int[] ProcessQueries(int[] queries, int m) {
        if(m <=0 || queries == null || queries.Length == 0) return null;
        
        int[] results = new int[queries.Length];
        List<int> tmp = new List<int>();
        for(int i =0; i < m; ++i)
        {
            tmp.Add(i + 1);
        }

        for(int i = 0; i < queries.Length; ++i)
        {
            var q = queries[i];
            
            var num = tmp[q];
            results[i] = num;

            tmp.RemoveAt(q);
            tmp.Insert(0, num);
        }
        
        return resuts;
    }
}