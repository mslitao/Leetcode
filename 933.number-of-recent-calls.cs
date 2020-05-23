using System;
using System.Collections.Generic;
using System.Linq;

public class RecentCounter
{
    public RecentCounter() {
        
    }
    private Queue<int> queue = new Queue<int>();
    public int Ping(int t) {
        queue.Enqueue(t);
        while(queue.Any() && queue.Peek() < t - 3000)
        {
            queue.Dequeue();
        }

        return queue.Count;
    }
}