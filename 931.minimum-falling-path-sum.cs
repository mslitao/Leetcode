using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution931
{
    public int MinFallingPathSum(int[][] A) 
    {
        if(A == null ) return 0;
        int rows = A.Length;
        if(rows ==0) return 0;
        int columns = A[0].Length;
        if(columns == 0) return 0;

        int[,] dp = new int[rows, columns];
        for(int i =0; i < columns; ++i)
        {
            dp[0, i] = A[0][i];
        }
        
        for(int i = 1; i < rows; ++i)
        {
            for(int j =0; j < columns; ++j)
            {
                if(j ==0)
                {
                    dp[i, j] = Math.Min(dp[i-1, j], dp[i-1, j+1]) + A[i][j];
                }
                else if (j == columns -1)
                {
                    dp[i, j] = Math.Min(dp[i-1, j], dp[i-1, j-1]) + A[i][j];
                }
                else
                {
                    dp[i, j] = Math.Min(dp[i-1, j], Math.Min(dp[i-1, j-1], dp[i-1, j + 1])) + A[i][j];
                }
            }
        }

        int min = int.MaxValue;
        for(int i =0; i < columns; ++i)
        {
            if(dp[rows-1, i] < min)
                min = dp[rows-1, i];
        }
        return min;
    }
}