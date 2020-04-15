using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution59
{
    public int[][] GenerateMatrix(int n) {
        int[][] results = new int[n][];
        int i = 0;
        for(i = 0; i < n; ++i)
        {
            results[i] = new int[n];
        }

        int cnt =1;
        int[] iOrder = new int[]{0, 1, 0, -1};
        int[] jOrder = new int[]{1, 0, -1, 0};
        int order = 0;
        i = 0;
        int j = 0;
        while(cnt <= n*n)
        {
            if(i < 0 || i >= n || j< 0 || j>=n || results[i][j] > 0)
            {
                i = i - iOrder[order];
                j = j - jOrder[order];
                order = (order + 1) % 4;
            }
            else
            {
                //Console.Write(cnt);
                results[i][j] = cnt++;
                //Console.Write(i);
                //Console.WriteLine(j);
            }
            i = i + iOrder[order];
            j = j + jOrder[order];
        }

        return results;
    }
}