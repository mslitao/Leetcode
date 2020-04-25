using System;
using System.Collections.Generic;
using System.Linq;

class SolutionMock0424
{
    public int KthSmallest(TreeNode root, int k) {
        return PreOrderTraverse(root, k);
    }

    public int PreOrderTraverse(TreeNode root, int k)
    {
        int index = 0;
        Stack<TreeNode> stack = new Stack<TreeNode>();
        while(root != null || stack.Any())
        {
            while(root != null )
            {
                stack.Push(root);
                root = root.left;
            }

            root = stack.Pop();
            if(++index == k) return root.val;
            root = root.right;
        }

        return -1;
    }


    public IList<string> FindItinerary(IList<IList<string>> tickets) {
        Dictionary<string, List<string>> map = new Dictionary<string, List<string>>();
        for(int i = 0; i< tickets.Count; ++i)
        {
            var ticket = tickets[i];
            if(!map.ContainsKey(ticket[0]))
            {
                map.Add(ticket[0], new List<string>());
            }

            var tmp = map[ticket[0]];
            tmp.Add(ticket[1] + "|" +  i.ToString());
            map[ticket[0]] = tmp;
        }
        
        var keys = new List<string>( map.Keys);
        foreach(var key in keys)
        {
            var tmp = map[key];
            map[key].Sort();
        }

        int k = tickets.Count + 1;
        List<string> results = new List<string>();
        List<string> itinerary = new List<string>();
        HashSet<string> visited = new HashSet<string>();
        var start = "JFK";
        itinerary.Add(start);
        DFSVisit(itinerary, k, start, map, visited, ref results);

        return results;
        //DFS
    }

    public void DFSVisit(List<string> itinerary, int k, string current,
                                Dictionary<string, List<string>> map,
                                HashSet<string> visited,
                                ref List<string> result)
    {
        if(result.Count > 0)
        {
            return;
        }
        
        if(k == itinerary.Count)
        {
            result = new List<string>(itinerary);
            return;
        }
        
        if(!map.ContainsKey(current)) 
            return;

        var tmp = map[current];
        foreach(var des in tmp)
        {
            var name = des.Split('|')[0];
            var id = des.Split('|')[1];
            if(visited.Contains(id))
                continue;

            itinerary.Add(name);
            visited.Add(id);
            DFSVisit(itinerary, k, name, map, visited, ref result);
            itinerary.Remove(name);
            visited.Remove(id);
        }
    }

    private void DFS(Dictionary<string, List<string>> adjacencyMatrix, string cur, IList<string> result) {
        while (adjacencyMatrix[cur].Any()) {
            var next = adjacencyMatrix[cur].First();
            adjacencyMatrix[cur].Remove(next);
            DFS(adjacencyMatrix, next, result);
        }
        result.Add(cur);
    }
}