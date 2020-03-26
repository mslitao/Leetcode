using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution310
{
    public IList<int> FindMinHeightTrees(int n, int[][] edges) {
        List<List<int>> childrenPerNode = new List<List<int>>();
        IList<int> results = new List<int>();

        for(int i =0; i < n; ++i)
        {
            childrenPerNode.Add(new List<int>());
        }

        foreach(var e in edges)
        {
            var tmp = childrenPerNode[e[0]];
            tmp.Add(e[1]);
            childrenPerNode[e[0]] = tmp;

            tmp = childrenPerNode[e[1]];
            tmp.Add(e[0]);
            childrenPerNode[e[1]] = tmp;
        }

        List<int> heightByRoot = new List<int>();
        int minHeight = int.MaxValue;
        for(int i =0; i < n; ++i)
        {
            var height = BFSTreeHeight(childrenPerNode, i, minHeight);
            heightByRoot.Add(height);
            minHeight = Math.Min(minHeight, height);
        }
        
        
        for(int i =0; i < n; ++i)
        {
            if(heightByRoot[i] == minHeight)
                results.Add(i);
        }

        return results;
    }

    public int BFSTreeHeight(List<List<int>> childrenPerNode, int root, int minHeight)
    {
        Queue<int> queue = new Queue<int>();
        HashSet<int> visited = new HashSet<int>();
        queue.Enqueue(root);

        int height = 0;
        while(queue.Any())
        {
            height ++;

            if(height > minHeight)
                return int.MaxValue;
            int cnt = queue.Count();
            for(int i =0; i < cnt; ++i)
            {
                var node = queue.Dequeue();
                visited.Add(node);

                var childs = childrenPerNode[node];
                foreach(var c in childs)
                {
                    if(!visited.Contains(c))
                        queue.Enqueue(c);
                }
            }
        }

        return height;
    }
}