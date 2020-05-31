using System;
using System.Collections.Generic;
using System.Linq;

public class Solution1466
{
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

            if(!mapTo.ContainsKey(to)) mapTo.Add(to, new List<int>());
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