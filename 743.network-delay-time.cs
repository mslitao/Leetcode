using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution743 {
    public int NetworkDelayTime(int[][] times, int N, int K)
    {
        int[,] graph = new int[N, N];
        for (int i = 0; i < N; ++i)
            for (int j = 0; j < N; ++j)
                graph[i, j] = -1;

        for(int i =0; i < times.Length; ++i)
        {
            graph[times[i][0] - 1, times[i][1] - 1] = times[i][2];
        }

        
        Queue<int> q = new Queue<int>();
        for (int i = 0; i < N; ++i)
        {
            if (graph[K - 1, i] != -1)
                q.Enqueue(i);
        }
        while (q.Count > 0)
        {
            int x = (int)q.Dequeue();
            for (int i = 0; i < N; ++i)
            {
                if (i != K - 1 && graph[x, i] != -1)
                {
                    if (graph[K - 1, i] == -1 || graph[K - 1, x] + graph[x, i] < graph[K - 1, i])
                    {
                        graph[K - 1, i] = graph[K - 1, x] + graph[x, i];
                        q.Enqueue(i);
                    }
                }
            }
        }
        int res = 0;
        for (int i = 0; i < N; ++i)
        {
            if (i == K - 1)
                continue;
            if (graph[K-1, i] == -1)
                return -1;
            if (graph[K - 1, i] > res)
                res = graph[K - 1, i];
        }
        return res;
    }
}