using System;
public class Solution1184
{
    public int DistanceBetweenBusStops(int[] distance, int start, int destination) {
        int dis = 0;
        int sum = 0;
        if(distance.Length<=0) return 0;
        
        for(int i =0; i < distance.Length; ++i)
        {
            if(i>=start && i< destination ||
               i<start && i>=destination)
                dis = dis + distance[i];
            sum+=distance[i];
        }
        return Math.Min(dis, sum-dis); 
    }
}