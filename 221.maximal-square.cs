using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution221
{
    public int MaximalSquare(char[][] matrix)
    {
        int rows = matrix.Length;
        if(rows == 0) return 0;
        int columns = matrix[0].Length;
        if(columns ==0) return 0;

        int[,] dp = new int[rows, columns];
        int[,] dpRow = new int[rows, columns];
        int[,] dpCol = new int[rows, columns];
        int maxSquare = 0;
        for(int i = 0; i < rows; ++i)
        {
            for(int j =0; j <columns; ++j)
            {
                dp[i,j] = matrix[i][j]== '1'? 1: 0;
                if(dp[i, j] > maxSquare) maxSquare = 1;
                dpRow[i,j] = matrix[i][j]== '1'? (j== 0? 1: dpRow[i, j-1] +1): 0; //Row direction
                dpCol[i,j] = matrix[i][j]== '1'? (i== 0? 1: dpCol[i-1, j] +1): 0; //Column direction
            }
        }

        
        for(int i = 1; i < rows; ++i)
        {
            for(int j =1; j <columns; ++j)
            {
                if(matrix[i][j] == '1')
                {
                    dp[i,j] = Math.Min(dp[i-1,j-1], Math.Min(dpRow[i, j-1], dpCol[i-1, j])) + 1;

                    if(dp[i, j] > maxSquare) maxSquare = dp[i, j];
                }
            }
        }

        return maxSquare * maxSquare;
    }
}