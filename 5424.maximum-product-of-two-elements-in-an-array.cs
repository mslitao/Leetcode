using System;
using System.Collections.Generic;
using System.Linq;

public class Solution5424
{
    public int MaxProduct(int[] nums) {
        int max = int.MinValue;

        for(int i = 0; i < nums.Length; ++i)
        {
            nums[i] = nums[i] -1;
        }
        for(int i = 0; i < nums.Length; ++i)
        {
            for(int j = 0; j < nums.Length; ++j)
            {
                int tmp =nums[i] * nums[j];
                max = Math.Max(max, tmp);
            }
        }

        return max;
    }

    public int MaxArea(int h, int w, int[] horizontalCuts, int[] verticalCuts) {
        int mh = GetMaxPart(h, horizontalCuts);
        int mw = GetMaxPart(w, verticalCuts);

        int MOD = (int)1E9 + 7;
         
        long result =(long)mh*(long)mw;
        return (int)(result % MOD);
    }

    public int GetMaxPart(int size, int[] cuts)
    {
        List<int> allCuts = new List<int>();
        allCuts.Add(0);
        allCuts.Add(size);
        foreach(var hc in cuts)
        {
            if(hc != 0 && hc != size)
                allCuts.Add(hc);
        }
        allCuts.Sort();
        
        int max = 0;
        for(int i = 1; i < allCuts.Count; ++i)
        {
            max = Math.Max(max, allCuts[i] - allCuts[i -1]);
        }

        return max;
    }


    public int MinReorder(int n, int[][] connections) 
    {
        Dictionary<int, List<int>> mapFrom = new Dictionary<int, List<int>>();
        Dictionary<int, List<int>> mapTo = new Dictionary<int, List<int>>();
        for(int i= 0; i < connections.Length; i++)
        {
            int from = connections[i][0];
            int to = connections[i][1];

            if(!mapFrom.ContainsKey(from)) mapFrom.Add(from, new List<int>());
            mapFrom[from].Add(to);

            if(!mapTo.ContainsKey(to)) mapFrom.Add(to, new List<int>());
            mapTo[to].Add(from);
        }

        HashSet<int> visited = new HashSet<int>();
        visited.Add(0);
        RecursiveVisits(0, mapFrom, mapTo, visited, 0);

        return this.reorders;
    }

    int reorders = 0;
    public void RecursiveVisits(int city, Dictionary<int, List<int>> mapFrom, Dictionary<int, List<int>> mapTo,
                                HashSet<int> visited,
                                int n)
    {
        if(visited.Count == n) return;

        if(mapTo.ContainsKey(city))
        {
            foreach(var from in mapTo[city])
            {
                visited.Add(from);
                RecursiveVisits(from, mapFrom, mapTo, visited, n);
            }
        }

        if(mapFrom.ContainsKey(city))
        {
            foreach(var to in mapFrom[city])
            {
                if(visited.Contains(to)) continue;

                Console.WriteLine(string.Format("from{0} to {1}", city, to));
                reorders ++;
                visited.Add(to);
                RecursiveVisits(to, mapFrom, mapTo, visited, n);
            }
        }
    }

}
