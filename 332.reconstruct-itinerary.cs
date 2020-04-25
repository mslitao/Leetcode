using System;
using System.Linq;
using System.Collections.Generic;


public class Solution332 {
    public IList<string> FindItinerary(IList<IList<string>> tickets) {
        var adjacencyMatrix = new Dictionary<string, List<string>>();

        var result = new List<string>();

        foreach (var ticket in tickets) {
            var from = ticket[0];
            var to = ticket[1];

            if (!adjacencyMatrix.ContainsKey(from)) {
                adjacencyMatrix[from] = new List<string>();
            }

            if (!adjacencyMatrix.ContainsKey(to)) {
                adjacencyMatrix[to] = new List<string>();
            }

            adjacencyMatrix[from].Add(to);
        }

        // Sort all lists
        foreach (var value in adjacencyMatrix.Values) {
            value.Sort();
        }

        DFS(adjacencyMatrix, "JFK", result);

        result.Reverse();

        return result;
    }

    private void DFS(Dictionary<string, List<string>> adjacencyMatrix, string cur, IList<string> result) {
        while (adjacencyMatrix[cur].Any()) {
            var next = adjacencyMatrix[cur].First();
            adjacencyMatrix[cur].Remove(next);
            DFS(adjacencyMatrix, next, result);
        }
        result.Add(cur);
    }

    public bool IsSameTree(TreeNode p, TreeNode q) {
        if(p == null && q == null) return true;
        else if(p == null || q == null) return false;
        else return  p.val == q.val && IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right); 
    }

    public double MyPow(double x, int n) {
        if(n == 0) return 1;

        double half = MyPow(x, n/2);
        if(n % 2 == 0) return half * half;
        if(n > 0) return half*half*x;
        else return half*half/x;
    }

    public int LargestRectangleArea(int[] heights) {
        if(heights == null || heights.Length == 0) return 0;
        int maxArea = 0;

        for(int i = 0; i < heights.Length; ++i)
        {
            int minHeight = heights[i];
            maxArea = Math.Max(maxArea, minHeight;
            for(int j = i - 1; j >=0; --j)
            {
                minHeight = Math.Min(minHeight, heights[j]);
                maxArea = Math.Max(maxArea, minHeight * (i - j));
            }
        }

        return maxArea;
    }
}