using System;
using System.Collections.Generic;
using System.Linq;

public class Solution5415
{
    public int NumPoints(int[][] points, int r) {
        
        bool[,] map = new bool[points.Length, points.Length];
        int N = points.Length;
        int res = 0;
        for(int i = 0; i < points.Length; ++i)
        {
            for(int j = 0;  j < points.Length; ++j)
            {
                map[i, j] = Distance(points[i], points[j]) <= 2*r;
            }
        }

        Queue<HashSet<int>> Queue = new Queue<HashSet<int>>();
        for(int i = 0; i < points.Length; ++i)
        {
            var tmp = new HashSet<int>();
            tmp.Add(i);
            Queue.Enqueue(tmp);
        }

        while(Queue.Any())
        {
            var tmp = Queue.Dequeue();
            res = tmp.Count;

            for()
        }

        return res;
    }

    public double Distance(int[] p1, int[] p2)
    {
        return Math.Sqrt((p1[0]-p2[0])*(p1[0]-p2[0]) + (p1[1]-p2[1])*(p1[1]-p2[1]) );
    }
    public bool InCircle(int[] point, int[] cent, int r)
    {
        if((point[0] - cent[0]) * (point[0] - cent[0]) + (point[1] - cent[1]) * (point[1] - cent[1]) <= r*r)
        {
            return true;
        }
        else 
        {
            return false;
        }
    }
}