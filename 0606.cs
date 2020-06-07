using System;
using System.Collections.Generic;
using System.Linq;

public class Solution0606 {
    public int[] Shuffle(int[] nums, int n) {
        int[] results = new int[2*n];
        int index = 0;
        for(int i = 0; i < n; ++ i)
        {
            results[index++] = nums[i];
            results[index++] =  nums[n+i];
        }

        return results;
    }

    public int[] GetStrongest(int[] arr, int k) {
        Array.Sort(arr);
        var m = arr[(arr.Length - 1)/2];

        int start = 0;
        int end = arr.Length -1;
        int[] result = new int[k];
        int index = 0;
        while(start <= end && index < k)
        {
            int nl = Math.Abs(arr[start] - m);
            int nr = Math.Abs(arr[end] - m);
            if(nl > nr)
            {
                result[index++] = arr[start++];
            }
            else
            {
                result[index++] = arr[end--];
            }
        }

        return result;
    }

    public int MinCost(int[] houses, int[][] cost, int m, int n, int target) {
        int minCost = int.MaxValue;

        BackTrackPaint(houses, cost, -1, 0, 0, target, m, n, 0, ref minCost);

        if(minCost == int.MaxValue) return -1;
        else return minCost;
    }


    public void BackTrackPaint(int[] houses, int[][] cost, int lastColor, int h, int neighbors, int target,  int m, int n, int current, ref int minCost)
    {
        if(neighbors > target) return;
        if(h == m) 
        {
            Console.WriteLine(neighbors);
            if(neighbors == target && current < minCost )
            {
                minCost = current;
            }
            return;
        }

        if(houses[h]!= 0)
        {
            var newneighbors = neighbors + (houses[h] != lastColor? 1: 0);
            BackTrackPaint(houses, cost, houses[h], h +1, newneighbors, target, m, n, current, ref minCost);
            return;
        }

        for(int i = 0; i < n; ++ i)
        {
            var newneighbors = neighbors + ((i + 1) != lastColor? 1: 0);
            BackTrackPaint(houses, cost, i+1, h +1, newneighbors, target, m, n, current + cost[h][i], ref minCost);
        }
    }
}

public class BrowserHistory {
    public string[] urls; 

    public Dictionary<int, string> urlmap = new Dictionary<int, string>();

    int start;
    int end;
    
    int current;

    private void UpdateUrl(string url, int index)
    {
        if(!urlmap.ContainsKey(index))
        {
            urlmap.Add(index, url);
        }
        else
        {
            urlmap[index] = url;
        }
    }

    public BrowserHistory(string homepage) {
        this.start = 0;
        this.end = 0;
        this.current = 0;
        
        UpdateUrl(homepage, 0);
    }
    
    public void Visit(string url) {
        this.current ++;
        this.end = this.current;
        UpdateUrl(url, this.current);
    }
    
    public string Back(int steps) {
        var next = this.current - steps;
        this.current = Math.Max(this.start, next);

        return this.urlmap[this.current];
    }
    
    public string Forward(int steps) {
        var next = this.current + steps;
        this.current = Math.Min(next, this.end);

        return this.urlmap[this.current];
    }
}