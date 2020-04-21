using System;
using System.Collections.Generic;
using System.Linq;

class SolutionMock0420
{
    public uint reverseBits(uint n) {
        int[] bits = new int[32];
        
        uint result = 0;
        for(int i = 0; i < 32; ++i)
        {
            result = result <<1;
            result = result | (n & 1);
            n = n>> 1;
        }
        return result;
    }

    public int UniquePaths(int m, int n) {
        int[,] map = new int[m, n];
        return BackTrackingUniquePaths(m, n, 0, 0, map);
    }

    public int BackTrackingUniquePaths(int m, int n, int i, int j, int[,] map)
    {
        if(i <0 || i >= m || j<0 || j>=n)
        {
            return 0;
        }

        if(map[i, j] > 0)
        {
            return map[i, j];
        }

        if(i == m-1 && j == n-1)
        {
            map[i, j] = 1;
        }
        else
        {
            int cnt1 = BackTrackingUniquePaths(m, n, i +1, j, map);
            int cnt2 = BackTrackingUniquePaths(m, n, i, j + 1, map);
            map[i, j] = cnt1 + cnt2;
        }

        return map[i, j];
    }

    public int MaxPoints(int[][] points) {
        if(points == null) return 0;
        int m = points.Length;
        if(m == 0) return 0;
        int n = points[0].Length;
        if(n == 0) return 0;

        if(m <= 2) return m;
        
        Dictionary<Tuple<int, int>, HashSet<int>> map = new Dictionary<Tuple<int, int>, HashSet<int>>();
        List<List<int>> duplicates= new List<List<int>>();
        List<HashSet<Tuple<int, int>>> slopes= new List<HashSet<Tuple<int, int>>>();
        for(int i = 0; i < m; ++i)
        {
            List<int> dup = new List<int>();
            HashSet<Tuple<int, int>> slp = new HashSet<Tuple<int, int>>();
            for(int j = i+1; j < m; ++j)
            {
                if(points[i][0] == points[i][0] && points[i][1] == points[i][1])
                {
                    dup.Add(j);
                }
                var a = points[i][0] == points[j][0] ? int.MaxValue:  
                        (points[i][1] - points[j][1]) /(points[i][0] - points[j][0]);
                var b = a == int.MaxValue? points[i][0]: points[i][1] - a * points[i][0];

                Tuple<int, int> lr = Tuple.Create(a, b);

                if(!map.ContainsKey(lr))
                {
                    map.Add(lr, new HashSet<int>());
                }
                var tmp = map[lr];
                tmp.Add(i);
                tmp.Add(j);
                map[lr] = tmp;

                slp.Add(lr);
            }

            duplicates.Add(dup);
            slopes.Add(slp);
        }
        foreach(var item in map)
        {
            Console.WriteLine(string.Format("{0}-{1},{2}", item.Key.Item1, item.Key.Item2, item.Value.Count));
        }

        for(int i = 0; i < m; i ++)
        {
            
        }
        return map.Values.Select(x=>x.Count).Max();
    }
}