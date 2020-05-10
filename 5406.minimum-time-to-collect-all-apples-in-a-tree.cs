using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution5406
{
    /*
    public class AppleTree
    {
        public AppleTree Left;
        public AppleTree Right;
        
        public bool HasApple = false;

        public int Value;
    }
    */

    public int MinTime(int n, int[][] edges, IList<bool> hasApple) {

        int[] counter = new int[n];
        Array.Fill(counter, -1);

        int[] tags = new int[n];
        Array.Fill(tags, 1);

        Dictionary<int, List<int>> map = new Dictionary<int, List<int>>();
        foreach(var edge in edges)
        {
            if(!map.ContainsKey(edge[0]))
            {
                map.Add(edge[0], new List<int>());
            }
            map[edge[0]].Add(edge[1]);
        }

        DFSVisitTree(map, 0, counter, hasApple, tags);

        Console.WriteLine(string.Join(",", counter));
        int result = 0;
        for(int i = 0; i <n; ++i)
        {
            if(counter[i] > 0 && tags[i] > 0)
            {
                result +=2 * counter[i];
            }
        }

        return result;
    }

    public void DFSVisitTree(Dictionary<int, List<int>> map, int current, int[] counter, IList<bool> hasApple, int[] tags)
    {
        if(counter[current] >=0) return;
        if(!map.ContainsKey(current))
        {
            counter[current] = hasApple[current]? 1:0;
            tags[current] = 0;
            return;
        }

        int cnt = 0;
        foreach(var next in map[current])
        {
            DFSVisitTree(map, next, counter, hasApple, tags);
            
            if(counter[next] > 0 || hasApple[next])
                cnt += 1;
        }

        counter[current] = cnt;
    }
}