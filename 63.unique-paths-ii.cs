using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution63
{
    public int UniquePaths(int m, int n) 
    {
        if(m <=0 || n <=0) return 0;
        int[,] pathArray = new int[m, n];
        for(int i =0; i < m; i ++) pathArray[i, 0] =1;
        for(int i =0; i < n; i ++) pathArray[0, i] =1;

        for(int i = 1; i < m ; ++i)
        {
            for(int j = 1; j < n ; ++j)
            {
                pathArray[i, j] = pathArray[i-1, j] + pathArray[i, j-1];
            }
        }

        return pathArray[m-1, n-1];
    }

    /*
    Solution will be similar to the one of unique-path without the obstacle grid
    
    Only need to change the logic (0 for the position meet the obstacle)
    */
    public int UniquePathsWithObstacles(int[][] obstacleGrid) 
    {
        int m = obstacleGrid.Length;
        if(m ==0) return 0;
        int n = obstacleGrid[0].Length;
        if(n ==0) return 0;
        long[,] pathArray = new long[m, n];
        pathArray[0,0] = obstacleGrid[0][0] == 1? 0: 1;
        for(int i =1; i < m; i ++) 
        {
            if(obstacleGrid[i][0] == 1)
                pathArray[i, 0] = 0;
            else
                pathArray[i, 0] = pathArray[i-1, 0];
        }
        for(int i =1; i < n; i ++)
        {
             if(obstacleGrid[0][i] == 1)
                pathArray[0, i] = 0;
            else
                pathArray[0, i] = pathArray[0, i-1];
        }

        for(int i = 1; i < m ; ++i)
        {
            for(int j = 1; j < n ; ++j)
            {
                if(obstacleGrid[i][j] == 1) continue;
                
                pathArray[i, j] = pathArray[i-1, j] + pathArray[i, j-1];
            }
        }

        return (int)pathArray[m-1, n-1];
    }
}