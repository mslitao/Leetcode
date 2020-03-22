using System;
using System.Linq;
using System.Collections.Generic;

public class Solution406 {
    public int[][] ReconstructQueue(int[][] people) 
    {
        int cnt = people.Length;
        if(cnt == 0) return people;
        
        var sortedPeople = (from p in people
                           orderby p[0], p[1]
                           select p).ToList();

        for(int i =0; i < cnt; ++i)
        {
            int h = sortedPeople[i][0];
            int k = sortedPeople[i][1];
            
            int j = 0;
            while(j < cnt && k > 0)
            {
                if(sortedPeople[j][0]>= h)
                    k--;
                j++;
            }

            var tmp = sortedPeople[i];
            sortedPeople.RemoveAt(i);
            sortedPeople.Insert(j, tmp);
        }

        return sortedPeople.ToArray();
    }

    private static void Sort<T>(T[][] data) 
    { 
        Comparer<T> comparer = Comparer<T>.Default;
        Array.Sort<T[]>(data, (x,y) => comparer.Compare(x[0],y[0])); 
    } 
}