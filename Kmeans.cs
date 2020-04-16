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
        
        Kmeans kc = new Kmeans();
        kc.KmeansCluster(n, data);
        foreach(var c in kc.clusterCenter)
        {
            Console.WriteLine(string.Join("-", c));
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
            if(this.current.Contains(idx)) continue;
            
            int centerIdx = -1;
            float minDis = float.MaxValue;
            foreach(var c in this.current)
            {
                var dis = ComputeDistance(data[idx], data[c]);
                if(dis < minDis) 
                {
                    centerIdx = c;
                }
            }
            
            this.assignedCluster[idx] = centerIdx;
            
            var tmp = map[centerIdx];
            tmp.Add(idx);
            map[centerIdx] = tmp;
        }
        
        int cnt = 0;
        foreach(var cluster in map)
        {
            int center = -1;
            float minDis = float.MaxValue;
            foreach(var p1 in cluster.Value)
            {
                float sumVal = 0.0f;
                foreach(var p2 in cluster.Value)
                {
                    sumVal += ComputeDistance(data[p1], data[p2]);
                }
                
                if(sumVal < minDis) 
                {
                    center = p1;
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
        
        return distance;
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