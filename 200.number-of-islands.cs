using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution200
{
    public int NumIslands(char[][] grid) {
        //Count island 
        // Given a 2d grid map of '1's (land) and '0's (water),
        // count the number of islands. 
        // An island is surrounded by water and is formed by connecting adjacent lands horizontally or vertically.
        // You may assume all four edges of the grid are all surrounded by water.
        int rows = grid.Length;
        if(rows == 0) return 0;
        int columns = grid[0].Length;
        if(columns == 0) return 0;

        int[,] islandWithIds = new int[rows, columns];

        
        int islandCnt = 0;
        for(int i = 0; i < rows; ++i)
        {
            for(int j =0; j <columns; ++j)
            {
                if(grid[i][j] != '1')
                {
                    continue;
                }

                // Use BFS to travese the island and update the 1 to 2.
                grid[i][j] = '2';
                Queue<int[]> queue = new Queue<int[]>();
                queue.Enqueue(new int[2]{i, j});
                while(queue.Count > 0)
                {
                    bool adjacentToBoundry = i == 0 || i == rows -1 || j == 0 || j == columns -1;
                    bool insideIsland = i>0 && grid[i-1][j] == '1' || j>0 && grid[i][j-1] == '1';  
                    int[] current = queue.Dequeue();
                    // Going down
                    if (current[0] < rows - 1 && grid[current[0] + 1][current[1]] == '1')
                    {
                        grid[current[0] + 1][current[1]] = '2';
                        queue.Enqueue(new int[2] { current[0] + 1, current[1] });
                    }
                    // Going up
                    if (current[0] > 0 && grid[current[0] - 1][current[1]] == '1')
                    {
                        grid[current[0] - 1][current[1]] = '2';
                        queue.Enqueue(new int[2] { current[0] - 1, current[1] });
                    }
                    if (current[1] < columns - 1 && grid[current[0]][current[1] + 1] == '1')
                    {
                        grid[current[0]][current[1] + 1] = '2';
                        queue.Enqueue(new int[2] { current[0], current[1] + 1 });
                    }
                    if (current[1] > 0 && grid[current[0]][current[1] - 1] == '1')
                    {
                        grid[current[0]][current[1] - 1] = '2';
                        queue.Enqueue(new int[2] { current[0], current[1] - 1 });
                    }
                }
                islandCnt ++;
            }
        }

        return islandCnt;
    }
}