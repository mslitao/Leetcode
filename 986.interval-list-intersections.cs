using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution986
{
    public int[][] IntervalIntersection(int[][] A, int[][] B) {
        List<int[]> results = new List<int[]>();
        int m = A.Length;
        int n = B.Length;
        if(m ==0 || n ==0) return results.ToArray();

        int i = 0;
        int j = 0;
        while(i < m && j < n)
        {
            int maxStart = Math.Max(A[i][0], B[j][0]);
            int minEnd = Math.Min(A[i][1], B[j][1]);

            // No overlap
            if(maxStart <= minEnd)
            {
                results.Add(new int[]{maxStart, minEnd});
            }

            if(A[i][1] < B[j][1])
            {
                i++;
            }
            else
            {
                j++;
            }
        }

        return results.ToArray();
    }
}