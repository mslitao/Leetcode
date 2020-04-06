using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution463 
{
    public int IslandPerimeter(int[][] grid) {
        int m = grid.Length;
        if(m ==0) return 0;
        int n = grid[0].Length;
        if(n ==0) return 0;

        int total = 0;
        int overlap = 0;
        for(int i = 0; i < m; ++ i)
        {
            for(int j =0; j < n; ++j)
            {
                if(grid[i][j] == 0)
                    continue;
                
                total += 4;
                if(i - 1 >=0 && grid[i - 1][j] == 1) overlap ++;
                if(i + 1 < m && grid[i + 1][j] == 1) overlap ++;
                if(j - 1 >=0 && grid[i][j - 1] == 1) overlap ++;
                if(j + 1 < n && grid[i][j + 1] == 1) overlap ++;
            }
        }

        return total - overlap;
    }
}