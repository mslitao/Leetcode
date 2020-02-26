using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class Solution797
{
    public IList<IList<int>> AllPathsSourceTarget(int[][] graph)
    {
        return AllPathsSourceTarget(graph, 0);
    }

    public IList<IList<int>> AllPathsSourceTarget(int[][] graph, int node)
    {
        int N = graph.Length;
        IList<IList<int>> results = new List<IList<int>>();

        if (node == N - 1)
        {
            List<int> path = new List<int>();
            path.Add(N - 1);
            results.Add(path);
            return results;
        }

        foreach (var nei in graph[node])
        {
            foreach (var path in AllPathsSourceTarget(graph, nei))
            {
                path.Insert(0, node);
                results.Add(path);
            }
        }
        return results;
    }
}