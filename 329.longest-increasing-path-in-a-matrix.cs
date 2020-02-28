using System;
using System.Collections.Generic;
using System.Linq;

public class Solution329
{
    public int LongestIncreasingPath(int[][] matrix) {
        int rows = matrix.Length;
        if(rows ==0) return 0;
        int columns = matrix[0].Length;
        if(columns ==0 ) return 0;

        int[,] dp = new int[rows, columns];
        int maxLen = 0;
        for(int i=0; i < rows; ++i)
            for(int j =0; j < columns; ++j)
            {
                maxLen = Math.Max(maxLen, DFS(matrix, dp, i, j, rows, columns));
            }

        return maxLen;
    }

    int[,] Moves = new int[,]{{-1, 0}, {1, 0}, {0, -1}, {0, 1}};

    public int DFS(int[][] matrix, int[,] dp, int i, int j, int rows, int columns)
    {
        if(dp[i, j] > 0) return dp[i, j];
        
        int maxLen = 1;
        for(int k =0; k < 4; ++k)
        {
            int i1 = i + Moves[k,0];
            int j1 = j + Moves[k,1];

            if(j1 <0 || j1>= columns || i1 <0 || i1 >= rows
            ||matrix[i1][j1] >= matrix[i][j])
            {
                continue;
            }

            maxLen = Math.Max(maxLen, 1 + DFS(matrix, dp, i1, j1, rows, columns));
        }

        dp[i, j] = maxLen;
        return maxLen;
    }
}