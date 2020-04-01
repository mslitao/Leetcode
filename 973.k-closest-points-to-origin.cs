using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution973
{
    public int[][] KClosest(int[][] points, int K) {
        Dictionary<int, List<int[]>> dis2Points = new Dictionary<int, List<int[]>>();
        foreach(var p in points)
        {
            var dis = p[0] * p[0] + p[1]*p[1];
            if(!dis2Points.ContainsKey(dis))
            {
                dis2Points.Add(dis, new List<int[]>());
            }

            var tmp = dis2Points[dis];
            tmp.Add(p);
            dis2Points[dis] = tmp;
        }

        var orderedDis2Points = dis2Points.OrderBy(n => n.Key);
        Console.WriteLine(string.Join("-", orderedDis2Points.Select(n => n.Key)));
        List<int[]> results = new List<int[]>();
        int cnt = 0;
        foreach(var item in orderedDis2Points)
        {
            if(cnt >= K) break;
            foreach(var p in item.Value)
            {
                results.Add(p);
                cnt ++;
                if(cnt >= K) 
                    break;
            }
        }

        return results.ToArray();
    }
}