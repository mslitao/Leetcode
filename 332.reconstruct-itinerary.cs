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
}