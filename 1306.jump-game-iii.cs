using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution1306
{
    public bool CanReach(int[] arr, int start) {
        return CanReachBFS(arr, start);
    }
    public bool CanReachBFS(int[] arr, int start) {
        //BFS
        Queue<int> queue = new Queue<int>();
        queue.Enqueue(start);
        HashSet<int> visited = new HashSet<int>();
        while(queue.Any())
        {
            var idx = queue.Dequeue();
            if(visited.Contains(idx)) continue;

            if(arr[idx] == 0) return true;
            visited.Add(idx);

            if(idx - arr[idx] >=0) queue.Enqueue(idx - arr[idx]);
            if(idx + arr[idx] < arr.Length) queue.Enqueue(idx + arr[idx]);
        }

        return false;
    }


    public bool CanReachDFS(int[] arr, int start) {
        if(arr == null  || start < 0 || start >= arr.Length ) return false;

        var val = arr[start];
        if(val == 0) return true;
        if(val == -1) return false;
        arr[start] = -1;

        return CanReach(arr, start - val) || CanReach(arr, start + val);
    }

}