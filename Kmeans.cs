using System;
using System.Collections.Generic;

// To execute C#, please define "static void Main" on a class
// named Solution.

// kmeans_cluster(2, [[1, 2], [1, 4], [1, 0], [4, 2], [4, 4], [4, 0]])
// result: ([0, 0, 0, 1, 1, 1], [[1.0, 2.0], [4.0, 2.0]])

class SolutionKmeans
{
    static void Main(string[] args)
    {
        int n =2;
        List<List<float>> data = new List<List<float>>();
        data.Add(new List<float>{1f,2f});
        data.Add(new List<float>{1f,4f});
        data.Add(new List<float>{1f,0f});
        data.Add(new List<float>{4f,2f});
        data.Add(new List<float>{4f,4f});
        data.Add(new List<float>{4f,0f});
        data.Add(new List<float>{5f,6f});
        
        Kmeans kc = new Kmeans();
        kc.KmeansCluster(n, data);
        Console.WriteLine("Here's the cluster centers");
        foreach(var c in kc.clusterCenter)
        {
            Console.WriteLine(string.Join(",", c));
        }
        
        Console.WriteLine("Here's the cluster assignment.");
        for(int i = 0; i < data.Count; ++i)
        {
            Console.WriteLine(string.Format("{0},{1} - {2}", 
                                            data[i][0],
                                            data[i][1],
                                            kc.assignedCluster[i]));
        }
    }
    
   
}
public class Kmeans
{
    public List<int> assignedCluster = null;
    public List<List<float>> clusterCenter = null;
    public List<int> current = null;
    
    public int MaxIterations = 100;
    
    public void KmeansCluster(int n, List<List<float>> data)
    {
        if(n <= 0 || data == null || data.Count == 0) 
        {
            return;
        }
        
        this.InitClusters(n, data);
        
        for(int i = 0; i < this.MaxIterations; ++i)
        {
            this.Iterarte(n, data);
        }
        
        this.clusterCenter = new List<List<float>>();
        foreach(var c in this.current)
        {
            this.clusterCenter.Add(data[c]);
        }
        
        return;
    }
    
    public void Iterarte(int n, List<List<float>> data)
    {
        Dictionary<int, List<int>> map = new Dictionary<int, List<int>>();
        for(int i = 0; i < n; ++i)
        {
            var tmp = new List<int>();
            tmp.Add(this.current[i]);
                
            map.Add(this.current[i], tmp);
        }
        
        for(int idx = 0; idx < data.Count; ++idx)
        {
            //Skip if it's already in the cluster.
            if(map.ContainsKey(idx)) continue;
            
            int centerIdx = -1;
            int centerVal = -1;
            float minDis = float.MaxValue;
            int i = 0;
            foreach(var cluster in map)
            {
                var dis = ComputeDistance(data[idx], data[cluster.Key]);
                if(dis < minDis) 
                {
                    centerIdx = i;
                    centerVal = cluster.Key;
                    minDis = dis;
                }
                i++;
            }
            
            this.assignedCluster[idx] = centerIdx;
            
            var tmp = map[centerVal];
            tmp.Add(idx);
            map[centerVal] = tmp;
        }
        
        int cnt = 0;
        int dims = data[0].Count;
        foreach(var cluster in map)
        {
            int center = -1;
            float minDis = float.MaxValue;
            List<float> centerPoint = new List<float>(new float[dims]);
            
            foreach(var p in cluster.Value)
            {
                var dp = data[p];
                for(int dim = 0; dim < dims; ++dim)
                {
                    centerPoint[dim] += dp[dim];
                }
            }
            
            for(int dim = 0; dim < dims; ++dim)
            {
                centerPoint[dim] = centerPoint[dim] / cluster.Value.Count;
            }
            
            foreach(var p in cluster.Value)
            {
                var tmpDis = ComputeDistance(data[p], centerPoint);
                if(tmpDis <= minDis)
                {
                    minDis = tmpDis;
                    center = p;
                }
            }

            this.current[cnt ++] = center;
        }
    }
    
    
    public float ComputeDistance(List<float> p1, List<float> p2)
    {
        float distance = 0.0f;
        for(int i = 0; i< p1.Count; ++i)
        {
            distance += (p1[i] - p2[i]) *(p1[i] - p2[i]);
        }
        
        return (float)Math.Sqrt(distance);
    }
    
    public void InitClusters(int n, List<List<float>> data)
    {
        this.assignedCluster = new List<int>();
        this.current = new List<int>();
        
        for(int i = 0; i < data.Count; ++i)
        {
            if(i < n)
            {
                this.assignedCluster.Add(i);
                this.current.Add(i);
            }
            else
            {
                this.assignedCluster.Add(-1);
            }
        }
        
        
        return;
    }
}