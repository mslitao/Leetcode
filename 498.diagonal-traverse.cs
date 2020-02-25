using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution498
{
    public int[] FindDiagonalOrder(int[][] matrix) {
        // 1 is up, 0 is down
        bool direction = true;
        int m = matrix.Length;
        if(m ==0) return new int[0];
        int n = matrix[0].Length;
        if(n ==0) return new int[0];
        int[] results = new int[m*n];

        int i = 0;
        int j = 0;
        int k = 0;
        while(true)
        {
            while(i >= 0 && i < m && j >=0 && j < n)
            {
                results[k++] = matrix[i][j];
                if(direction)
                {
                    i--;j++;
                }
                else
                {
                    i++;j--;
                }
            }
            
            if(k == m*n)
                break;
            
            if(direction)
            {
                i++;j--;
                
                if(j + 1< n)
                {
                    j++;
                }
                else
                {
                    i++;
                }
            }
            else
            {
                i--; j ++;
                if(i + 1 < m)
                {
                    i++;
                }
                else
                {
                    j++;
                }
            }
            //Console.Write(i);
            //Console.WriteLine(j);
            direction = !direction;
            if(i == m-1 && j == n-1)
            {
                results[k++] = matrix[i][j];
                break;
            }
        }

        return results;
    }
}