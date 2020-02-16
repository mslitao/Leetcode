using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution64
{
    public int MinPathSum(int[][] grid) {
        if(grid == null) return 0;
        int rows = grid.Length;
        if(rows ==0) return 0;
        int columns = grid[0].Length;
        if(columns ==0) return 0;

        int[,] pathMap = new int[rows, columns];

        for(int i =0; i < rows; i++)
        {
            pathMap[i, 0] = i ==0? grid[i][0]: grid[i][0]+ pathMap[i-1, 0];
        }
        
        for(int j =0; j < columns; j++)
        {
            pathMap[0, j] = j ==0? grid[0][j]: grid[0][j]+ pathMap[0, j-1];
        }
            
        for(int i =1; i < rows; i ++)
            for (int j =1; j < columns; j ++)
            {
                pathMap[i,j] =Math.Min(pathMap[i-1, j], pathMap[i,j-1]) + grid[i][j];
            }

        return pathMap[rows-1,columns-1];
    }
}